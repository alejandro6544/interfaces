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
    public partial class ConsultasE : Form
    {
        Controller.Controller objC;
        public ConsultasE()
        {
            InitializeComponent();
            objC = new Controller.Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cod = txtCodigoB.Text;
            String fechaI = monthCalendar1.SelectionRange.Start.ToShortDateString();
            String fechaF = monthCalendar2.SelectionRange.Start.ToShortDateString();
            dataGridView1.DataSource = objC.matriculaEstudiante(cod, fechaI, fechaF);

           // MessageBox.Show("f " + fechaF);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objC.buscarTodoslosEstudiantes();
        }
    }
}
