using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace interfaces.modelo
{
    class Estudiante
    {

        #region Atributos de clase
        private String idestudiante;
        private String codigoestudiante;
        private String nombreestudiante;
        private String apellidoestudiante;
        private String telefonoestudiante;
        private String direccionestudiante;
        private String correoestudiante;
        private String rutafotoestudiante;
        #endregion

        #region Métodos generales de clase
        public Estudiante()
        {

        }
        public Estudiante(String idestudiante, String codigoestudiante, String nombreestudiante, String apellidoestudiante,
            String telefonoestudiante, String direccionestudiante, String correoestudiante, String rutafotoestudiante)
        {
            this.idestudiante = idestudiante;
            this.codigoestudiante = codigoestudiante;
            this.nombreestudiante = nombreestudiante;
            this.apellidoestudiante = apellidoestudiante;
            this.telefonoestudiante = telefonoestudiante;
            this.direccionestudiante = direccionestudiante;
            this.correoestudiante = correoestudiante;
            this.rutafotoestudiante = rutafotoestudiante;
        }

        public String getIdEstudiante()
        {
            return idestudiante;
        }

        public void setIdEstudiante(String idestudiante)
        {
            this.idestudiante = idestudiante;
        }
        public String getCodigoEstudiante()
        {
            return codigoestudiante;
        }

        public void setCodigoEstudiante(String codigoestudiante)
        {
            this.codigoestudiante = codigoestudiante;
        }

        public String getNombreEstudiante()
        {
            return nombreestudiante;
        }

        public void setNombreEstudiante(String nombreestudiante)
        {
            this.nombreestudiante = nombreestudiante;
        }
        public String getApellidoEstudiante()
        {
            return apellidoestudiante;
        }

        public void setApellidoEstudiante(String apellidoestudiante)
        {
            this.apellidoestudiante = apellidoestudiante;
        }
        public String getTelefonoEstudiante()
        {
            return telefonoestudiante;
        }

        public void setTelefonoEstudiante(String telefonoestudiante)
        {
            this.telefonoestudiante = telefonoestudiante;
        }
        public String getDireccionEstudiante()
        {
            return direccionestudiante;
        }

        public void setDireccionEstudiante(String direccionestudiante)
        {
            this.direccionestudiante = direccionestudiante;
        }
        public String getCorreoEstudiante()
        {
            return correoestudiante;
        }

        public void setCorreoEstudiante(String correoestudiante)
        {
            this.correoestudiante = correoestudiante;
        }
        public String getRutaFotoEstudiante()
        {
            return rutafotoestudiante;
        }

        public void setRutaFotoEstudiante(String rutafotoestudiante)
        {
            this.rutafotoestudiante = rutafotoestudiante;
        }
        #endregion

        #region Métodos de Base de Datos
        public bool insertEstudiante(Estudiante objE)
        {
            bool resultado = false;
            String sql = "";
            Controller.DBConnect objBD = new Controller.DBConnect();
            if (objBD.openConnection())
            {
                if (objE.getRutaFotoEstudiante().Equals("0"))
                {
                    sql = "INSERT INTO estudiantes (idestudiantes, codigoestudiante, nombreestudiante, apellidoestudiante, telefonoestudiante, direccionestudiante, correoestudiante)" +
                        "VALUES ('"+objE.getIdEstudiante()+"', '"+objE.getCodigoEstudiante()+"', '"+objE.getNombreEstudiante()+"', '"+
                        objE.getApellidoEstudiante()+"', '"+objE.getTelefonoEstudiante()+"', '"+objE.getDireccionEstudiante() +"', '"+objE.getCorreoEstudiante()+"')";

                    MySqlCommand cmd = new MySqlCommand(sql, objBD.getConnection());
                    cmd.ExecuteNonQuery();


                    resultado = true;

                }
            }
            

            return resultado;
        }

        #endregion
    }
}
