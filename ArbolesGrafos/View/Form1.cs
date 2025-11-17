using ArbolesGrafos.Controller;
using ArbolesGrafos.Model;
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
        private RutaController _rutaController;
        public Form1()
        {
            InitializeComponent();
            btnJerarquia.Enabled = false;
            tabControlJerarquia.Appearance = TabAppearance.FlatButtons;
            tabControlJerarquia.ItemSize = new Size(0, 1);
            tabControlJerarquia.SizeMode = TabSizeMode.Fixed;
            _rutaController = new RutaController();
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
        /// <summary>
        /// Añade una nueva raíz al árbol. También actualiza nodos totales e hijos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Añade un nuevo nodo hijo al nodo seleccionado. También actauliza nodos totales e hijos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Resalta los nodos pasados como argumento con el color seleccionado si coinciden con la búsqueda.
        /// </summary>
        /// <param name="nodos"></param>
        /// <param name="busqueda"></param>
        /// <param name="colorResaltado"></param>
        /// <param name="colorDefecto"></param>
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

        /// <summary>
        /// Maneja el evento de cambio de texto en el tbBuscar. Setea los colores de resaltado y por defecto y llama a la función para resaltar nodos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Llama a la función correspondiente según el tipo de recorrido seleccionado. Setea los colores por defecto y de resaltado, pasándoles como argumento las raíces del árbol y los colores.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Cambia el color del nodo por 500 milisegundos.
        /// </summary>
        /// <param name="nodo"></param>
        /// <param name="fuenteRes"></param>
        /// <param name="fuenteDef"></param>
        /// <returns></returns>
        private async Task VisitarNodo(TreeNode nodo, Color fuenteRes, Color fuenteDef)
        {
            nodo.ForeColor = fuenteRes;
            nodo.EnsureVisible();

            await Task.Delay(500);
       
            nodo.ForeColor = fuenteDef;
        }

        /// <summary>
        /// Recorre el árbol en preorden, llamando a la función VisitarNodo y a sí misma recursivamente.
        /// </summary>
        /// <param name="nodo"></param>
        /// <param name="fuenteRes"></param>
        /// <param name="fuenteDef"></param>
        /// <returns></returns>
        private async Task RecorrerPreorden(TreeNode nodo, Color fuenteRes, Color fuenteDef)
        {
            if (nodo == null) return;
            await VisitarNodo(nodo, fuenteRes, fuenteDef);

            foreach (TreeNode hijo in nodo.Nodes)
            {
                await RecorrerPreorden(hijo, fuenteRes, fuenteDef);
            }
        }

        /// <summary>
        /// Recorre el árbol en inorden, llamando a la función VisitarNodo y a sí misma recursivamente.
        /// </summary>
        /// <param name="nodo"></param>
        /// <param name="fuenteRes"></param>
        /// <param name="fuenteDef"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Recorre el árbol en postorden, llamando a la función VisitarNodo y a sí misma recursivamente.
        /// </summary>
        /// <param name="nodo"></param>
        /// <param name="fuenteRes"></param>
        /// <param name="fuenteDef"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Actualiza la cuenta de nodos después de una selección en el árbol.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvJerarquia_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lbNodosTotales.Text = Convert.ToString(tvJerarquia.GetNodeCount(true));
            if (tvJerarquia.SelectedNode != null)
            {
                lbNodosHijos.Text = Convert.ToString(tvJerarquia.SelectedNode.GetNodeCount(true));
            }
        }

        #region Eventos de la Pestaña Rutas

        private void btnAgregarEdificio_Click(object sender, EventArgs e)
        {
            EstadoRuta resultado = _rutaController.AgregarEdificio(tbEdificio.Text);

            if (resultado == EstadoRuta.Exito)
            {
                ActualizarComboBoxEdificios();
                tbEdificio.Clear();
                ActualizarVistaAdyacencia();
            }
            else if (resultado == EstadoRuta.NombreVacio)
            {
                MessageBox.Show("El nombre del edificio no puede estar vacío.");
            }
            else if (resultado == EstadoRuta.EdificioYaExiste)
            {
                MessageBox.Show("Ese edificio ya fue registrado.");
            }
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            string origen = cbOrigen.SelectedItem?.ToString();
            string destino = cbDestino.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(origen) || string.IsNullOrEmpty(destino))
            {
                MessageBox.Show("Debe seleccionar un origen y un destino.");
                return;
            }

            if (!int.TryParse(tbDistancia.Text, out int distancia))
            {
                MessageBox.Show("La distancia debe ser un número entero válido.");
                return;
            }

            EstadoRuta resultado = _rutaController.AgregarRuta(origen, destino, distancia);

            if (resultado == EstadoRuta.Exito)
            {
                MessageBox.Show("Ruta agregada exitosamente.");
                tbDistancia.Clear();
                ActualizarVistaAdyacencia();
            }
            else if (resultado == EstadoRuta.DistanciaInvalida)
            {
                MessageBox.Show("La distancia debe ser un número positivo.");
            }
            else if (resultado == EstadoRuta.RutaYaExiste)
            {
                MessageBox.Show("Error: Esa ruta ya existe entre los dos edificios.");
            }
            else if (resultado == EstadoRuta.RutaHaciaSiMismo)
            {
                MessageBox.Show("Error: Un edificio no puede tener una ruta hacia sí mismo.");
            }
        }

        private void btnCalcularRuta_Click(object sender, EventArgs e)
        {
            string origen = cbOrigen.SelectedItem?.ToString();
            string destino = cbDestino.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(origen) || string.IsNullOrEmpty(destino))
            {
                MessageBox.Show("Debe seleccionar un origen y un destino.");
                return;
            }

            RutaResultado resultado = _rutaController.CalcularRutaMasCorta(origen, destino);

            if (resultado.Encontrada)
            {
                string rutaFormateada = string.Join(" -> ", resultado.Ruta);
                lblListaAdyacencia.Text = $"Ruta más corta: {rutaFormateada}\r\n";
                lblListaAdyacencia.Text += $"Distancia total: {resultado.DistanciaTotal} metros.";
            }
            else
            {
                lblListaAdyacencia.Text = $"Error: {resultado.MensajeError}";
            }
        }

        private void btnValidarConexion_Click(object sender, EventArgs e)
        {
            bool esConexo = _rutaController.EsConexo();

            if (esConexo)
            {
                MessageBox.Show("¡Conectado! Todos los edificios son accesibles.");
            }
            else
            {
                MessageBox.Show("¡No Conectado! Hay edificios aislados.");
            }
        }

        private void ActualizarVistaAdyacencia()
        {
            var adyacencias = _rutaController.GetAdyacencias();

            var sb = new System.Text.StringBuilder();
            foreach (var par in adyacencias)
            {
                string edificio = par.Key;
                List<Conexion> conexiones = par.Value;

                sb.Append(edificio + ": ");
                if (conexiones.Count == 0)
                {
                    sb.Append("(Sin conexiones)");
                    sb.Append(Environment.NewLine);
                }
                else
                {
                    var conexionesFormateadas = new List<string>();
                    foreach (var con in conexiones)
                    {
                        conexionesFormateadas.Add($"-> {con.EdificioDestino} ({con.Distancia}m)");
                    }
                    sb.Append(string.Join(", ", conexionesFormateadas));
                    sb.Append(Environment.NewLine);
                }
            }
            lblListaAdyacencia.Text = sb.ToString();
        }

        #endregion

        #region Métodos de Actualización de la Vista
        private void ActualizarComboBoxEdificios()
        {
            List<string> edificios = _rutaController.GetEdificios();

            cbOrigen.DataSource = new List<string>(edificios);
            cbDestino.DataSource = new List<string>(edificios);
        }

        #endregion

        private void btnVerListaAdyacencia_Click(object sender, EventArgs e)
        {
            ActualizarVistaAdyacencia();
        }
    }
}
