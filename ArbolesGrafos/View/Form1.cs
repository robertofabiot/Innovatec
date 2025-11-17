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
            btnJerarquia.Enabled = false;
            tabControl2.Appearance = TabAppearance.FlatButtons;
            tabControl2.ItemSize = new Size(0, 1);
            tabControl2.SizeMode = TabSizeMode.Fixed;

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
            btnJerarquia.Enabled = false;
            btnRutas.Enabled = true;
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Rutas;
            btnJerarquia.Enabled = true;
            btnRutas.Enabled = false;
        }

        private void Jerarquia_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoPuestoPrincipal_Click(object sender, EventArgs e)
        {
            string nombreRaiz = tbNuevoPuesto.Text;

            if (!string.IsNullOrEmpty(nombreRaiz))
            {
                tvJerarquia.Nodes.Add(nombreRaiz);
                tbNuevoPuesto.Clear(); // Limpiamos el textbox
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre para el puesto principal.", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNuevoPuestoSubordinado_Click(object sender, EventArgs e)
        {
            string nombrePuesto = tbNuevoPuesto.Text;
            if (string.IsNullOrEmpty(nombrePuesto))
            {
                MessageBox.Show("Por favor, ingrese un nombre para el puesto subordinado.", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            TreeNode nodoSeleccionado = tvJerarquia.SelectedNode;

            if (nodoSeleccionado != null)
            {
                nodoSeleccionado.Nodes.Add(nombrePuesto);
                nodoSeleccionado.Expand();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un puesto para añadirle un subordinado.", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            tbNuevoPuesto.Clear(); 
        }
    }
    }
}
