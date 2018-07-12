using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace interfaces.Controller
{
    class DBConnect
    {
        private MySqlConnection connection;
        private String server;
        private String database;
        private String uid;
        private String pass;

        public DBConnect()
        {
            Initialize();
        }
        #region Inicia parametros para conexión
        private void Initialize()
        {
            server = "localhost";
            database = "uao";
            uid = "root";
            pass = "root";

            String conect = "SERVER=" + server + ";" + "DATABASE=" + database +
                ";" + "UID=" + uid + ";" + "PASSWORD=" + pass + ";";
            connection = new MySqlConnection(conect);
        }
        #endregion

        #region Abrir conexión
        public bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException er)
            {
                switch (er.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server ... ");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again!!!");
                        break;
                }
                return false;
            }
        }
        #endregion

        public MySqlConnection getConnection()
        {
            return connection;
        }

        #region Cerrar la conexión
        public bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

    }
}
