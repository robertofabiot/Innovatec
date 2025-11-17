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

        //No hace nada, pero si la borran se daña TODO
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #region botones del menú
        private void btnJerarquia_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Jerarquia;
            btnJerarquia.Enabled = false;
            btnRutas.Enabled = true;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRutas_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Rutas;
            btnJerarquia.Enabled = true;
            btnRutas.Enabled = false;
        }
        #endregion

        #region funciones de insertar
        private void btnTabInsertar_Click(object sender, EventArgs e)
        {
            tabControlJerarquia.SelectedTab = tabInsertar;
            btnTabInsertar.Enabled = false;
            btnTabRecorrer.Enabled = true;

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
            lbNodosTotales.Text = Convert.ToString(tvJerarquia.GetNodeCount(true));
            if (tvJerarquia.SelectedNode != null)
            {
                lbNodosHijos.Text = Convert.ToString(tvJerarquia.SelectedNode.GetNodeCount(true));
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
            lbNodosTotales.Text = Convert.ToString(tvJerarquia.GetNodeCount(true));
            if (tvJerarquia.SelectedNode != null) 
            { 
                lbNodosHijos.Text = Convert.ToString(tvJerarquia.SelectedNode.GetNodeCount(true)); 
            }
        }
        #endregion

        #region funciones de buscar
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
            tvJerarquia.SelectedNode = null;
            string busqueda = tbBuscar.Text.ToLower();

            Color colorResaltado = Color.Red;
            Color colorDefecto = tvJerarquia.ForeColor;
            ResaltarNodos(tvJerarquia.Nodes, busqueda, colorResaltado, colorDefecto);
            tvJerarquia.ExpandAll();
        }

        #endregion

        #region Funciones Para Recorrer
        private void btnTabRecorrer_Click(object sender, EventArgs e)
        {
            tabControlJerarquia.SelectedTab = tabRecorrer;
            btnTabInsertar.Enabled = true;
            btnTabRecorrer.Enabled = false;
        }
        private async void btnRecorrer_Click_1(object sender, EventArgs e)
        {
            Color colorDefectoFuente = tvJerarquia.ForeColor;
            Color colorResaltadoFuente = Color.Red;
            string tipo = cbTipoRecorrido.SelectedItem.ToString();
            tvJerarquia.SelectedNode = null;
            tvJerarquia.ExpandAll();

            foreach (TreeNode raiz in tvJerarquia.Nodes)
            {
                switch (tipo)
                {
                    case "Preorden":
                        await RecorrerPreorden(raiz, colorResaltadoFuente, colorDefectoFuente);
                        break;
                    case "Inorden":
                        await RecorrerInorden(raiz, colorResaltadoFuente, colorDefectoFuente);
                        break;
                    case "Postorden":
                        await RecorrerPostorden(raiz, colorResaltadoFuente, colorDefectoFuente);
                        break;
                }
            }
        }

        private async Task VisitarNodo(TreeNode nodo, Color fuenteRes, Color fuenteDef)
        {
            nodo.ForeColor = fuenteRes;
            nodo.EnsureVisible();

            await Task.Delay(500);
       
            nodo.ForeColor = fuenteDef;
        }

        private async Task RecorrerPreorden(TreeNode nodo, Color fuenteRes, Color fuenteDef)
        {
            if (nodo == null) return;
            await VisitarNodo(nodo, fuenteRes, fuenteDef);

            foreach (TreeNode hijo in nodo.Nodes)
            {
                await RecorrerPreorden(hijo, fuenteRes, fuenteDef);
            }
        }

        private async Task RecorrerInorden(TreeNode nodo, Color fuenteRes, Color fuenteDef)
        {
            if (nodo == null) return;
        
            if (nodo.Nodes.Count > 0)
            {
                await RecorrerInorden(nodo.Nodes[0], fuenteRes, fuenteDef);
            }

            await VisitarNodo(nodo, fuenteRes, fuenteDef);

            for (int i = 1; i < nodo.Nodes.Count; i++)
            {
                await RecorrerInorden(nodo.Nodes[i], fuenteRes, fuenteDef);
            }
        }

        private async Task RecorrerPostorden(TreeNode nodo, Color fuenteRes, Color fuenteDef)
        {
            if (nodo == null) return;

            foreach (TreeNode hijo in nodo.Nodes)
            {
                await RecorrerPostorden(hijo, fuenteRes, fuenteDef);
            }

            await VisitarNodo(nodo, fuenteRes, fuenteDef);
        }
        #endregion
        private void tvJerarquia_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lbNodosTotales.Text = Convert.ToString(tvJerarquia.GetNodeCount(true));
            if (tvJerarquia.SelectedNode != null)
            {
                lbNodosHijos.Text = Convert.ToString(tvJerarquia.SelectedNode.GetNodeCount(true));
            }
        }
    }
}
