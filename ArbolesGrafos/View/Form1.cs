using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolesGrafos.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJerarquia_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Jerarquia;
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Rutas;
        }
    }
}
