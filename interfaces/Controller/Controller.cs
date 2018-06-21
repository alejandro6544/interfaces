using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace interfaces.Controller
{
    class Controller
    {
        public bool pasarDatosInsertE(modelo.Estudiante objE)
        {

            modelo.Estudiante objEl = new modelo.Estudiante();
            bool resu = objEl.insertEstudiante(objE);

            return resu;

        }
        //envío de datos
        public LinkedList<String> buscarEstudiante(String cod)
        {
            modelo.Estudiante objEl = new modelo.Estudiante();
            modelo.Estudiante objE1 = objEl.buscarEstudiante(cod);
            LinkedList<String> listaS = new LinkedList<String>();

            listaS.AddLast(objE1.getIdEstudiante());
            listaS.AddLast(objE1.getCodigoEstudiante());
            listaS.AddLast(objE1.getNombreEstudiante());
            listaS.AddLast(objE1.getApellidoEstudiante());
            listaS.AddLast(objE1.getTelefonoEstudiante());
            listaS.AddLast(objE1.getDireccionEstudiante());
            listaS.AddLast(objE1.getCorreoEstudiante());

            return listaS;
        }
        //modificar datos de estudiante
        public bool modificarEstudiante(modelo.Estudiante objE, String cod)
        {
            modelo.Estudiante objEl = new modelo.Estudiante();
            bool resu = objEl.modificarEstudiante(objE, cod);

            return resu;
        }

        public DataTable buscarTodoslosEstudiantes()
        {
            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
            DataTable dtDatos = new DataTable();
            modelo.Estudiante objEl = new modelo.Estudiante();
            MySqlDataAdapter mdaDatos = objEl.buscarTodoslosEstudiantes();
            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);

            return dtDatos;
        }


    }
}
