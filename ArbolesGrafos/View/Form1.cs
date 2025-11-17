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
            tabControlJerarquia.Appearance = TabAppearance.FlatButtons;
            tabControlJerarquia.ItemSize = new Size(0, 1);
            tabControlJerarquia.SizeMode = TabSizeMode.Fixed;

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
                tbNuevoPuesto.Clear();
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

        private void ResaltarNodos(TreeNodeCollection nodos, string busqueda, Color colorResaltado, Color colorDefecto)
        {
            foreach (TreeNode nodo in nodos)
            {
                if (!string.IsNullOrEmpty(busqueda) && nodo.Text.ToLower().StartsWith(busqueda))
                {
                    nodo.ForeColor = colorResaltado;
                }
                else
                {
                    nodo.ForeColor = colorDefecto;
                }
                if (nodo.Nodes.Count > 0)
                {
                    ResaltarNodos(nodo.Nodes, busqueda, colorResaltado, colorDefecto);
                }
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = tbBuscar.Text.ToLower();

            Color colorResaltado = Color.Red;
            Color colorDefecto = tvJerarquia.ForeColor;
            ResaltarNodos(tvJerarquia.Nodes, busqueda, colorResaltado, colorDefecto);
            tvJerarquia.ExpandAll();
        }

        private void btnTabInsertar_Click(object sender, EventArgs e)
        {
            tabControlJerarquia.SelectedTab = tabInsertar;
            btnTabInsertar.Enabled = false;
            btnTabRecorrer.Enabled = true;
            btnTabContar.Enabled = true;
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            tabControlJerarquia.SelectedTab = tabRecorrer;
            btnTabInsertar.Enabled = true;
            btnTabRecorrer.Enabled = false;
            btnTabContar.Enabled = true;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            tabControlJerarquia.SelectedTab = tabContar;
            btnTabInsertar.Enabled = true;
            btnTabRecorrer.Enabled = true;
            btnTabContar.Enabled = false;
        }

        private void btnRecorrer_Click_1(object sender, EventArgs e)
        {
            string tipo = cbTipoRecorrido.SelectedItem.ToString();
            tvJerarquia.ExpandAll();
        }
    }
    
}
