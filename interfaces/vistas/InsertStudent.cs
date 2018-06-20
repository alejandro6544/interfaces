using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        String rutafotoestudiante;
        bool f=false;
        private void btnAceptarE_Click(object sender, EventArgs e)
        {
            String idestudiante= txtId.Text;
            String codigoestudiante= txtCodigo.Text;
            String nombreestudiante= txtNombre.Text;
            String apellidoestudiante= txtApellido.Text;
            String telefonoestudiante= txtTelefono.Text;
            String direccionestudiante= txtDireccion.Text;
            String correoestudiante= txtCorreo.Text;
            
            if (f==false)
            {
                rutafotoestudiante = "0";
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            f = true;
           // Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "JPG files (*.jpg, *.bmp, *.png)|*.jpg; *.bmp; *.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutafotoestudiante = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
               
            }

        }
    }
}
