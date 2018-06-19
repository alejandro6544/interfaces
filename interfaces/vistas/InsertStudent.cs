using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.vistas
{
    public partial class InsertStudent : Form
    {
        public InsertStudent()
        {
            InitializeComponent();
        }

        private void btnAceptarE_Click(object sender, EventArgs e)
        {
            String idestudiante= txtId.Text;
            String codigoestudiante= txtCodigo.Text;
            String nombreestudiante= txtNombre.Text;
            String apellidoestudiante= txtApellido.Text;
            String telefonoestudiante= txtTelefono.Text;
            String direccionestudiante= txtDireccion.Text;
            String correoestudiante= txtCorreo.Text;
            String rutafotoestudiante="0";

            modelo.Estudiante objE = new modelo.Estudiante(idestudiante, codigoestudiante, nombreestudiante, apellidoestudiante,
            telefonoestudiante, direccionestudiante, correoestudiante, rutafotoestudiante);

            Controller.Controller objC = new Controller.Controller();
           bool resul= objC.pasarDatosInsertE(objE);
            if (resul)
            {
                MessageBox.Show("Datos insertados");
            }else
            {
                MessageBox.Show("Datos No insertados");
            }


        }
    }
}
