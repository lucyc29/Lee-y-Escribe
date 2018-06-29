using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lee_y_Escribe
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            PFlechaL.Visible = false;
            PFlechaR.Visible = false;
            TVelocidad.Visible = false;
            BRepetir.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
