using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;

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
        //insertar imagen 
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
                else
                {
                    
                    Image img = Image.FromFile(@objE.getRutaFotoEstudiante());
                    //  Console.WriteLine("rutafotoestudiante imagen "  + objE.getRutaFotoEstudiante());
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    //MySqlParameter blob = new MySqlParameter("@imagenestudiante", MySqlDbType.Blob, arr.Length);
                    //blob.Value = arr;
                    sql = "INSERT INTO estudiantes (idestudiantes, codigoestudiante, nombreestudiante, apellidoestudiante, telefonoestudiante, direccionestudiante, correoestudiante, imagenestudiante)" +
                                            "VALUES (@idestudiantes, @codigoestudiante, @nombreestudiante, @apellidoestudiante, @telefonoestudiante, @direccionestudiante, @correoestudiante, @imagenestudiante)";
                    MySqlCommand cmd = new MySqlCommand(sql, objBD.getConnection());
                    cmd.Parameters.AddWithValue("@idestudiantes", objE.getIdEstudiante());
                    cmd.Parameters.AddWithValue("@codigoestudiante", objE.getCodigoEstudiante());
                    cmd.Parameters.AddWithValue("@nombreestudiante", objE.getNombreEstudiante());
                    cmd.Parameters.AddWithValue("@apellidoestudiante", objE.getApellidoEstudiante());
                    cmd.Parameters.AddWithValue("@telefonoestudiante", objE.getTelefonoEstudiante());
                    cmd.Parameters.AddWithValue("@direccionestudiante", objE.getDireccionEstudiante());
                    cmd.Parameters.AddWithValue("@correoestudiante", objE.getCorreoEstudiante());
                    cmd.Parameters.AddWithValue("@imagenestudiante", arr);
                    cmd.ExecuteNonQuery();
                    objBD.closeConnection();
                    resultado = true;
                }
            }
            return resultado;
        }

        //Se busca un estudiante por medio del código
        public Estudiante buscarEstudiante(String codigoE)
        {
            Estudiante objE=null;
            String sql = "Select * from estudiantes where codigoestudiante= '"+codigoE+"'";
            Controller.DBConnect objBD = new Controller.DBConnect();
            MySqlCommand cmd = new MySqlCommand();

            MySqlDataReader reader;
            if (objBD.openConnection())
            {
                cmd.CommandText = sql;
                cmd.Connection = objBD.getConnection();
                reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        String idestudiante = reader.GetString(0);
                        String codigoestudiante = reader.GetString(1);
                        String nombreestudiante = reader.GetString(2);
                        String apellidoestudiante = reader.GetString(3);
                        String telefonoestudiante = reader.GetString(4);
                        String direccionestudiante = reader.GetString(5);
                        String correoestudiante = reader.GetString(6);
                        String rutafotoestudiante = "0";

                        objE = new Estudiante(idestudiante, codigoestudiante, nombreestudiante, apellidoestudiante,
                                telefonoestudiante, direccionestudiante, correoestudiante, rutafotoestudiante);
                    }
                }
                
            }


                return objE;
        }

        //UpDate un estudiante 
        public bool modificarEstudiante(Estudiante objE, String cod)
        {
            bool resultado = false;
            String sql = "UPDATE estudiantes SET nombreestudiante = '" + objE.getNombreEstudiante() + "', apellidoestudiante = '" + objE.getApellidoEstudiante()+"', telefonoestudiante= '"+objE.getTelefonoEstudiante()+"', " +
                "direccionestudiante= '"+objE.getDireccionEstudiante()+"', correoestudiante='"+objE.getCorreoEstudiante()+ "' WHERE codigoestudiante= '"+cod+"'";
            Controller.DBConnect objBD = new Controller.DBConnect();
            MySqlCommand cmd = new MySqlCommand();
            if (objBD.openConnection())
            {

                cmd = new MySqlCommand(sql, objBD.getConnection());
                cmd.ExecuteNonQuery();
                resultado = true;
            }

                return resultado;
        }

        //buscar a todos los estudiantes
        public MySqlDataAdapter buscarTodoslosEstudiantes()
        {
            Controller.DBConnect objBD = new Controller.DBConnect();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "Select idestudiantes as 'Identificación Estudiante', codigoestudiante as 'Código Estudiante', nombreestudiante as Nombre, apellidoestudiante as Apellido, telefonoestudiante as Teléfono, direccionestudiante as Dirección, correoestudiante as Correo from estudiantes";
            MySqlDataAdapter mdaDatos=null;
            if (objBD.openConnection())
            {
                mdaDatos = new MySqlDataAdapter(sql, objBD.getConnection());

            }
                return mdaDatos;
        }

        //buscar a los estudiante matriculados en un periodo (una fecha inicio y una fecha fin)
        public MySqlDataAdapter matriculaEstudiante(String codigo, String fechaI, String fechaF)
        {
            Controller.DBConnect objBD = new Controller.DBConnect();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter mdaDatos = null;
            String sql = "SELECT nombreCurso as 'Cursos Matriculados' from cursos c, estudiantes e, matriculas m where " +
                         "e.codigoestudiante = m.codigoestudiantem and m.codigocursom = c.codigocurso and " +
                         "e.codigoestudiante = '" + codigo + "' and m.fechaMatricula between '" + fechaI + "' and '" + fechaF + "'";

            if (objBD.openConnection())
            {
                mdaDatos = new MySqlDataAdapter(sql, objBD.getConnection());
            }


                return mdaDatos;
        }
        #endregion
    }
}
