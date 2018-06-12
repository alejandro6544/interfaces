using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureMaximizar.Visible = false;
            pictureRestaurar.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureRestaurar.Visible = false;
            pictureMaximizar.Visible = true;
        }

        private void pictureMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hMnd,int wMsg, int wParam, int IParam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            panelSubReporte.Visible = true;
        }

        private void btnrepEstudiantes_Click(object sender, EventArgs e)
        {
            panelSubReporte.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new vistas.InsertStudent());
        }
        private void abrirFormulario(object objForm)
        {
            if (this.panelcontenedor.Controls.Count > 0)
            {
                this.panelcontenedor.Controls.RemoveAt(0);
            }
            Form fh = objForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

    }
}
