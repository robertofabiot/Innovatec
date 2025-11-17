namespace ArbolesGrafos.View
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnJerarquia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Jerarquia = new System.Windows.Forms.TabPage();
            this.lbNodosHijos = new System.Windows.Forms.Label();
            this.lbNodosTotales = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTabRecorrer = new System.Windows.Forms.Button();
            this.btnTabInsertar = new System.Windows.Forms.Button();
            this.tabControlJerarquia = new System.Windows.Forms.TabControl();
            this.tabInsertar = new System.Windows.Forms.TabPage();
            this.btnNuevoPuestoSubordinado = new System.Windows.Forms.Button();
            this.btnNuevoPuestoPrincipal = new System.Windows.Forms.Button();
            this.tbNuevoPuesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabRecorrer = new System.Windows.Forms.TabPage();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.cbTipoRecorrido = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.tvJerarquia = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.Rutas = new System.Windows.Forms.TabPage();
            this.lblResultadoRuta = new System.Windows.Forms.Label();
            this.btnMostrarAdyacencia = new System.Windows.Forms.Button();
            this.btnValidarConexion = new System.Windows.Forms.Button();
            this.btnCalcularRuta = new System.Windows.Forms.Button();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.btnAgregarEdificio = new System.Windows.Forms.Button();
            this.tbEdificio = new System.Windows.Forms.TextBox();
            this.lblListaAdyacencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Jerarquia.SuspendLayout();
            this.tabControlJerarquia.SuspendLayout();
            this.tabInsertar.SuspendLayout();
            this.tabRecorrer.SuspendLayout();
            this.Rutas.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.splitContainer1.Panel1.Controls.Add(this.btnSalir);
            this.splitContainer1.Panel1.Controls.Add(this.btnRutas);
            this.splitContainer1.Panel1.Controls.Add(this.btnJerarquia);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1190, 635);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(90)))), ((int)(((byte)(193)))));
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 440);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(183, 82);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(90)))), ((int)(((byte)(193)))));
            this.btnRutas.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutas.Location = new System.Drawing.Point(12, 327);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(183, 82);
            this.btnRutas.TabIndex = 2;
            this.btnRutas.Text = "Sistema de Rutas";
            this.btnRutas.UseVisualStyleBackColor = false;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnJerarquia
            // 
            this.btnJerarquia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(90)))), ((int)(((byte)(193)))));
            this.btnJerarquia.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJerarquia.Location = new System.Drawing.Point(12, 212);
            this.btnJerarquia.Name = "btnJerarquia";
            this.btnJerarquia.Size = new System.Drawing.Size(183, 82);
            this.btnJerarquia.TabIndex = 1;
            this.btnJerarquia.Text = "Jerarquia Organizativa";
            this.btnJerarquia.UseVisualStyleBackColor = false;
            this.btnJerarquia.Click += new System.EventHandler(this.btnJerarquia_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Innovatec";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Jerarquia);
            this.tabControl1.Controls.Add(this.Rutas);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 658);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // Jerarquia
            // 
            this.Jerarquia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.Jerarquia.Controls.Add(this.lbNodosHijos);
            this.Jerarquia.Controls.Add(this.lbNodosTotales);
            this.Jerarquia.Controls.Add(this.label7);
            this.Jerarquia.Controls.Add(this.label6);
            this.Jerarquia.Controls.Add(this.btnTabRecorrer);
            this.Jerarquia.Controls.Add(this.btnTabInsertar);
            this.Jerarquia.Controls.Add(this.tabControlJerarquia);
            this.Jerarquia.Controls.Add(this.tbBuscar);
            this.Jerarquia.Controls.Add(this.tvJerarquia);
            this.Jerarquia.Controls.Add(this.label3);
            this.Jerarquia.Location = new System.Drawing.Point(4, 25);
            this.Jerarquia.Margin = new System.Windows.Forms.Padding(0);
            this.Jerarquia.Name = "Jerarquia";
            this.Jerarquia.Padding = new System.Windows.Forms.Padding(3);
            this.Jerarquia.Size = new System.Drawing.Size(943, 629);
            this.Jerarquia.TabIndex = 0;
            this.Jerarquia.Text = "tabPage1";
            // 
            // lbNodosHijos
            // 
            this.lbNodosHijos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNodosHijos.AutoSize = true;
            this.lbNodosHijos.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNodosHijos.Location = new System.Drawing.Point(558, 505);
            this.lbNodosHijos.Name = "lbNodosHijos";
            this.lbNodosHijos.Size = new System.Drawing.Size(29, 39);
            this.lbNodosHijos.TabIndex = 14;
            this.lbNodosHijos.Text = "0";
            // 
            // lbNodosTotales
            // 
            this.lbNodosTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNodosTotales.AutoSize = true;
            this.lbNodosTotales.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNodosTotales.Location = new System.Drawing.Point(583, 465);
            this.lbNodosTotales.Name = "lbNodosTotales";
            this.lbNodosTotales.Size = new System.Drawing.Size(29, 39);
            this.lbNodosTotales.TabIndex = 13;
            this.lbNodosTotales.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(421, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nodos hijos:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nodos totales:";
            // 
            // btnTabRecorrer
            // 
            this.btnTabRecorrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(235)))));
            this.btnTabRecorrer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabRecorrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.btnTabRecorrer.Location = new System.Drawing.Point(643, 78);
            this.btnTabRecorrer.Name = "btnTabRecorrer";
            this.btnTabRecorrer.Size = new System.Drawing.Size(122, 47);
            this.btnTabRecorrer.TabIndex = 11;
            this.btnTabRecorrer.Text = "Recorrer";
            this.btnTabRecorrer.UseVisualStyleBackColor = false;
            this.btnTabRecorrer.Click += new System.EventHandler(this.btnTabRecorrer_Click);
            // 
            // btnTabInsertar
            // 
            this.btnTabInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(235)))));
            this.btnTabInsertar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabInsertar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.btnTabInsertar.Location = new System.Drawing.Point(479, 78);
            this.btnTabInsertar.Name = "btnTabInsertar";
            this.btnTabInsertar.Size = new System.Drawing.Size(122, 47);
            this.btnTabInsertar.TabIndex = 10;
            this.btnTabInsertar.Text = "Insertar";
            this.btnTabInsertar.UseVisualStyleBackColor = false;
            this.btnTabInsertar.Click += new System.EventHandler(this.btnTabInsertar_Click);
            // 
            // tabControlJerarquia
            // 
            this.tabControlJerarquia.Controls.Add(this.tabInsertar);
            this.tabControlJerarquia.Controls.Add(this.tabRecorrer);
            this.tabControlJerarquia.Location = new System.Drawing.Point(416, 114);
            this.tabControlJerarquia.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlJerarquia.Name = "tabControlJerarquia";
            this.tabControlJerarquia.Padding = new System.Drawing.Point(0, 0);
            this.tabControlJerarquia.SelectedIndex = 0;
            this.tabControlJerarquia.Size = new System.Drawing.Size(393, 344);
            this.tabControlJerarquia.TabIndex = 6;
            // 
            // tabInsertar
            // 
            this.tabInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.tabInsertar.Controls.Add(this.btnNuevoPuestoSubordinado);
            this.tabInsertar.Controls.Add(this.btnNuevoPuestoPrincipal);
            this.tabInsertar.Controls.Add(this.tbNuevoPuesto);
            this.tabInsertar.Controls.Add(this.label4);
            this.tabInsertar.Location = new System.Drawing.Point(4, 25);
            this.tabInsertar.Margin = new System.Windows.Forms.Padding(0);
            this.tabInsertar.Name = "tabInsertar";
            this.tabInsertar.Size = new System.Drawing.Size(385, 315);
            this.tabInsertar.TabIndex = 0;
            this.tabInsertar.Text = "Insertar";
            // 
            // btnNuevoPuestoSubordinado
            // 
            this.btnNuevoPuestoSubordinado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(195)))), ((int)(((byte)(217)))));
            this.btnNuevoPuestoSubordinado.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPuestoSubordinado.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPuestoSubordinado.Location = new System.Drawing.Point(59, 166);
            this.btnNuevoPuestoSubordinado.Name = "btnNuevoPuestoSubordinado";
            this.btnNuevoPuestoSubordinado.Size = new System.Drawing.Size(275, 62);
            this.btnNuevoPuestoSubordinado.TabIndex = 9;
            this.btnNuevoPuestoSubordinado.Text = "Nuevo Puesto Subordinado";
            this.btnNuevoPuestoSubordinado.UseVisualStyleBackColor = false;
            this.btnNuevoPuestoSubordinado.Click += new System.EventHandler(this.btnNuevoPuestoSubordinado_Click);
            // 
            // btnNuevoPuestoPrincipal
            // 
            this.btnNuevoPuestoPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(195)))), ((int)(((byte)(217)))));
            this.btnNuevoPuestoPrincipal.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPuestoPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPuestoPrincipal.Location = new System.Drawing.Point(59, 72);
            this.btnNuevoPuestoPrincipal.Name = "btnNuevoPuestoPrincipal";
            this.btnNuevoPuestoPrincipal.Size = new System.Drawing.Size(273, 62);
            this.btnNuevoPuestoPrincipal.TabIndex = 8;
            this.btnNuevoPuestoPrincipal.Text = "Nuevo Puesto Principal";
            this.btnNuevoPuestoPrincipal.UseVisualStyleBackColor = false;
            this.btnNuevoPuestoPrincipal.Click += new System.EventHandler(this.btnNuevoPuestoPrincipal_Click);
            // 
            // tbNuevoPuesto
            // 
            this.tbNuevoPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNuevoPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNuevoPuesto.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevoPuesto.Location = new System.Drawing.Point(153, 13);
            this.tbNuevoPuesto.Name = "tbNuevoPuesto";
            this.tbNuevoPuesto.Size = new System.Drawing.Size(218, 29);
            this.tbNuevoPuesto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nuevo puesto:";
            // 
            // tabRecorrer
            // 
            this.tabRecorrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.tabRecorrer.Controls.Add(this.btnRecorrer);
            this.tabRecorrer.Controls.Add(this.cbTipoRecorrido);
            this.tabRecorrer.Controls.Add(this.label5);
            this.tabRecorrer.Location = new System.Drawing.Point(4, 25);
            this.tabRecorrer.Name = "tabRecorrer";
            this.tabRecorrer.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecorrer.Size = new System.Drawing.Size(385, 315);
            this.tabRecorrer.TabIndex = 1;
            this.tabRecorrer.Text = "Recorrer";
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(195)))), ((int)(((byte)(217)))));
            this.btnRecorrer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorrer.ForeColor = System.Drawing.Color.White;
            this.btnRecorrer.Location = new System.Drawing.Point(124, 59);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(160, 62);
            this.btnRecorrer.TabIndex = 10;
            this.btnRecorrer.Text = "Ir";
            this.btnRecorrer.UseVisualStyleBackColor = false;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click_1);
            // 
            // cbTipoRecorrido
            // 
            this.cbTipoRecorrido.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRecorrido.FormattingEnabled = true;
            this.cbTipoRecorrido.Items.AddRange(new object[] {
            "Preorden",
            "Inorden",
            "Postorden"});
            this.cbTipoRecorrido.Location = new System.Drawing.Point(192, 7);
            this.cbTipoRecorrido.Name = "cbTipoRecorrido";
            this.cbTipoRecorrido.Size = new System.Drawing.Size(176, 36);
            this.cbTipoRecorrido.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de recorrido:";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(527, 28);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(412, 33);
            this.tbBuscar.TabIndex = 5;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // tvJerarquia
            // 
            this.tvJerarquia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(235)))));
            this.tvJerarquia.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvJerarquia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.tvJerarquia.HideSelection = false;
            this.tvJerarquia.Location = new System.Drawing.Point(6, 5);
            this.tvJerarquia.Name = "tvJerarquia";
            this.tvJerarquia.Size = new System.Drawing.Size(395, 542);
            this.tvJerarquia.TabIndex = 4;
            this.tvJerarquia.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvJerarquia_AfterSelect);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Buscar";
            // 
            // Rutas
            // 
            this.Rutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.Rutas.Controls.Add(this.lblResultadoRuta);
            this.Rutas.Controls.Add(this.btnMostrarAdyacencia);
            this.Rutas.Controls.Add(this.btnValidarConexion);
            this.Rutas.Controls.Add(this.btnCalcularRuta);
            this.Rutas.Controls.Add(this.btnAgregarRuta);
            this.Rutas.Controls.Add(this.tbDistancia);
            this.Rutas.Controls.Add(this.cbDestino);
            this.Rutas.Controls.Add(this.button2);
            this.Rutas.Controls.Add(this.cbOrigen);
            this.Rutas.Controls.Add(this.btnAgregarEdificio);
            this.Rutas.Controls.Add(this.tbEdificio);
            this.Rutas.Controls.Add(this.lblListaAdyacencia);
            this.Rutas.Location = new System.Drawing.Point(4, 25);
            this.Rutas.Name = "Rutas";
            this.Rutas.Padding = new System.Windows.Forms.Padding(3);
            this.Rutas.Size = new System.Drawing.Size(943, 629);
            this.Rutas.TabIndex = 1;
            this.Rutas.Text = "tabPage2";
            // 
            // lblResultadoRuta
            // 
            this.lblResultadoRuta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultadoRuta.AutoSize = true;
            this.lblResultadoRuta.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoRuta.Location = new System.Drawing.Point(657, 245);
            this.lblResultadoRuta.Name = "lblResultadoRuta";
            this.lblResultadoRuta.Size = new System.Drawing.Size(188, 35);
            this.lblResultadoRuta.TabIndex = 21;
            this.lblResultadoRuta.Text = "ResultadoRuta";
            // 
            // btnMostrarAdyacencia
            // 
            this.btnMostrarAdyacencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(235)))));
            this.btnMostrarAdyacencia.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAdyacencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.btnMostrarAdyacencia.Location = new System.Drawing.Point(453, 245);
            this.btnMostrarAdyacencia.Name = "btnMostrarAdyacencia";
            this.btnMostrarAdyacencia.Size = new System.Drawing.Size(198, 47);
            this.btnMostrarAdyacencia.TabIndex = 20;
            this.btnMostrarAdyacencia.Text = "Mostrar Adyacencia";
            this.btnMostrarAdyacencia.UseVisualStyleBackColor = false;
            // 
            // btnValidarConexion
            // 
            this.btnValidarConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(235)))));
            this.btnValidarConexion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarConexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.btnValidarConexion.Location = new System.Drawing.Point(463, 457);
            this.btnValidarConexion.Name = "btnValidarConexion";
            this.btnValidarConexion.Size = new System.Drawing.Size(198, 47);
            this.btnValidarConexion.TabIndex = 19;
            this.btnValidarConexion.Text = "Validar conexión";
            this.btnValidarConexion.UseVisualStyleBackColor = false;
            // 
            // btnCalcularRuta
            // 
            this.btnCalcularRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(235)))));
            this.btnCalcularRuta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.btnCalcularRuta.Location = new System.Drawing.Point(666, 119);
            this.btnCalcularRuta.Name = "btnCalcularRuta";
            this.btnCalcularRuta.Size = new System.Drawing.Size(198, 47);
            this.btnCalcularRuta.TabIndex = 18;
            this.btnCalcularRuta.Text = "Calcular Ruta";
            this.btnCalcularRuta.UseVisualStyleBackColor = false;
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(235)))));
            this.btnAgregarRuta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.btnAgregarRuta.Location = new System.Drawing.Point(453, 119);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(198, 47);
            this.btnAgregarRuta.TabIndex = 17;
            this.btnAgregarRuta.Text = "Agregar Ruta";
            this.btnAgregarRuta.UseVisualStyleBackColor = false;
            // 
            // tbDistancia
            // 
            this.tbDistancia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDistancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDistancia.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDistancia.Location = new System.Drawing.Point(475, 395);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(397, 33);
            this.tbDistancia.TabIndex = 16;
            this.tbDistancia.Text = "tbDistancia";
            // 
            // cbDestino
            // 
            this.cbDestino.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(666, 172);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(176, 36);
            this.cbDestino.TabIndex = 15;
            this.cbDestino.Text = "destino";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(195)))), ((int)(((byte)(217)))));
            this.button2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(19, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 62);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cbOrigen
            // 
            this.cbOrigen.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(463, 172);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(176, 36);
            this.cbOrigen.TabIndex = 13;
            this.cbOrigen.Text = "origen";
            // 
            // btnAgregarEdificio
            // 
            this.btnAgregarEdificio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(235)))));
            this.btnAgregarEdificio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEdificio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.btnAgregarEdificio.Location = new System.Drawing.Point(462, -6);
            this.btnAgregarEdificio.Name = "btnAgregarEdificio";
            this.btnAgregarEdificio.Size = new System.Drawing.Size(198, 47);
            this.btnAgregarEdificio.TabIndex = 11;
            this.btnAgregarEdificio.Text = "Agregar Edificio";
            this.btnAgregarEdificio.UseVisualStyleBackColor = false;
            // 
            // tbEdificio
            // 
            this.tbEdificio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEdificio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEdificio.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdificio.Location = new System.Drawing.Point(463, 47);
            this.tbEdificio.Name = "tbEdificio";
            this.tbEdificio.Size = new System.Drawing.Size(397, 33);
            this.tbEdificio.TabIndex = 6;
            this.tbEdificio.Text = "tbEdificio";
            // 
            // lblListaAdyacencia
            // 
            this.lblListaAdyacencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListaAdyacencia.AutoSize = true;
            this.lblListaAdyacencia.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaAdyacencia.Location = new System.Drawing.Point(13, 144);
            this.lblListaAdyacencia.Name = "lblListaAdyacencia";
            this.lblListaAdyacencia.Size = new System.Drawing.Size(206, 35);
            this.lblListaAdyacencia.TabIndex = 4;
            this.lblListaAdyacencia.Text = "ListaAdyacencia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1190, 635);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Innovatec";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Jerarquia.ResumeLayout(false);
            this.Jerarquia.PerformLayout();
            this.tabControlJerarquia.ResumeLayout(false);
            this.tabInsertar.ResumeLayout(false);
            this.tabInsertar.PerformLayout();
            this.tabRecorrer.ResumeLayout(false);
            this.tabRecorrer.PerformLayout();
            this.Rutas.ResumeLayout(false);
            this.Rutas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Jerarquia;
        private System.Windows.Forms.TabPage Rutas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJerarquia;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TreeView tvJerarquia;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.TabControl tabControlJerarquia;
        private System.Windows.Forms.TabPage tabInsertar;
        private System.Windows.Forms.TabPage tabRecorrer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevoPuestoPrincipal;
        private System.Windows.Forms.TextBox tbNuevoPuesto;
        private System.Windows.Forms.Button btnNuevoPuestoSubordinado;
        private System.Windows.Forms.Button btnTabInsertar;
        private System.Windows.Forms.Button btnTabRecorrer;
        private System.Windows.Forms.ComboBox cbTipoRecorrido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lbNodosHijos;
        private System.Windows.Forms.Label lbNodosTotales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Button btnAgregarEdificio;
        private System.Windows.Forms.TextBox tbEdificio;
        private System.Windows.Forms.Label lblListaAdyacencia;
        private System.Windows.Forms.Button btnValidarConexion;
        private System.Windows.Forms.Button btnCalcularRuta;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.Button btnMostrarAdyacencia;
        private System.Windows.Forms.Label lblResultadoRuta;
    }
}