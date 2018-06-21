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
        public ConsultasE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.Controller objC = new Controller.Controller();
            dataGridView1.DataSource = objC.buscarTodoslosEstudiantes();
        }
    }
}
