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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.Controller objC = new Controller.Controller();
            String cod = txtCodigoB.Text;
            LinkedList<String> l= objC.buscarEstudiante(cod);
            if (l != null)
            {
                txtId.Text = l.ElementAt(0);
                txtCodigo.Text = l.ElementAt(1);
                txtNombre.Text = l.ElementAt(2);
                txtApellido.Text = l.ElementAt(3);
                txtTelefono.Text = l.ElementAt(4);
                txtDireccion.Text = l.ElementAt(5);
                txtCorreo.Text = l.ElementAt(6);
            }else
            {
                MessageBox.Show("No se encontro el usuario, verifique el número de identificación!!!");
            }
        }

        private void btnAceptarE_Click(object sender, EventArgs e)
        {
            String idestudiante = txtId.Text;
            String codigoestudiante = txtCodigo.Text;
            String nombreestudiante = txtNombre.Text;
            String apellidoestudiante = txtApellido.Text;
            String telefonoestudiante = txtTelefono.Text;
            String direccionestudiante = txtDireccion.Text;
            String correoestudiante = txtCorreo.Text;
            String rutafotoestudiante = "0";

            modelo.Estudiante objE = new modelo.Estudiante(idestudiante, codigoestudiante, nombreestudiante, apellidoestudiante,
            telefonoestudiante, direccionestudiante, correoestudiante, rutafotoestudiante);

            Controller.Controller objC = new Controller.Controller();
            String cod = txtCodigo.Text;
            bool r= objC.modificarEstudiante(objE, cod);
            if (r)
            {
                MessageBox.Show("Se ha modificado el estudiante correctamente");
            }else
            {
                MessageBox.Show("No se ha modificado el estudiante correctamente");
            }

        }
    }
}
