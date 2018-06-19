using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Controller
{
    class Controller
    {
        public bool pasarDatosInsertE(modelo.Estudiante objE)
        {

            modelo.Estudiante objEl = new modelo.Estudiante();
            bool resu= objEl.insertEstudiante(objE);

            return resu;

        }
        
    }
}
