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
            this.tabControlJerarquia = new System.Windows.Forms.TabControl();
            this.tabInsertar = new System.Windows.Forms.TabPage();
            this.tabRecorrer = new System.Windows.Forms.TabPage();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.tvJerarquia = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.Rutas = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabContar = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNuevoPuesto = new System.Windows.Forms.TextBox();
            this.btnNuevoPuestoPrincipal = new System.Windows.Forms.Button();
            this.btnNuevoPuestoSubordinado = new System.Windows.Forms.Button();
            this.btnTabInsertar = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Jerarquia.SuspendLayout();
            this.tabControlJerarquia.SuspendLayout();
            this.tabInsertar.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1031, 557);
            this.splitContainer1.SplitterDistance = 207;
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
            this.tabControl1.Location = new System.Drawing.Point(-5, -25);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 582);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // Jerarquia
            // 
            this.Jerarquia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.Jerarquia.Controls.Add(this.btnContar);
            this.Jerarquia.Controls.Add(this.btnRecorrer);
            this.Jerarquia.Controls.Add(this.btnTabInsertar);
            this.Jerarquia.Controls.Add(this.tabControlJerarquia);
            this.Jerarquia.Controls.Add(this.tbBuscar);
            this.Jerarquia.Controls.Add(this.tvJerarquia);
            this.Jerarquia.Controls.Add(this.label3);
            this.Jerarquia.Location = new System.Drawing.Point(4, 25);
            this.Jerarquia.Margin = new System.Windows.Forms.Padding(0);
            this.Jerarquia.Name = "Jerarquia";
            this.Jerarquia.Padding = new System.Windows.Forms.Padding(3);
            this.Jerarquia.Size = new System.Drawing.Size(828, 553);
            this.Jerarquia.TabIndex = 0;
            this.Jerarquia.Text = "tabPage1";
            this.Jerarquia.Click += new System.EventHandler(this.Jerarquia_Click);
            // 
            // tabControlJerarquia
            // 
            this.tabControlJerarquia.Controls.Add(this.tabInsertar);
            this.tabControlJerarquia.Controls.Add(this.tabRecorrer);
            this.tabControlJerarquia.Controls.Add(this.tabContar);
            this.tabControlJerarquia.Location = new System.Drawing.Point(416, 115);
            this.tabControlJerarquia.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlJerarquia.Name = "tabControlJerarquia";
            this.tabControlJerarquia.Padding = new System.Drawing.Point(0, 0);
            this.tabControlJerarquia.SelectedIndex = 0;
            this.tabControlJerarquia.Size = new System.Drawing.Size(393, 432);
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
            this.tabInsertar.Size = new System.Drawing.Size(385, 403);
            this.tabInsertar.TabIndex = 0;
            this.tabInsertar.Text = "Insertar";
            // 
            // tabRecorrer
            // 
            this.tabRecorrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.tabRecorrer.Location = new System.Drawing.Point(4, 25);
            this.tabRecorrer.Name = "tabRecorrer";
            this.tabRecorrer.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecorrer.Size = new System.Drawing.Size(385, 403);
            this.tabRecorrer.TabIndex = 1;
            this.tabRecorrer.Text = "Recorrer";
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
            this.tbBuscar.Size = new System.Drawing.Size(282, 33);
            this.tbBuscar.TabIndex = 5;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // tvJerarquia
            // 
            this.tvJerarquia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(235)))));
            this.tvJerarquia.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvJerarquia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.tvJerarquia.Location = new System.Drawing.Point(6, 5);
            this.tvJerarquia.Name = "tvJerarquia";
            this.tvJerarquia.Size = new System.Drawing.Size(395, 542);
            this.tvJerarquia.TabIndex = 4;
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
            this.Rutas.Controls.Add(this.label2);
            this.Rutas.Location = new System.Drawing.Point(4, 25);
            this.Rutas.Name = "Rutas";
            this.Rutas.Padding = new System.Windows.Forms.Padding(3);
            this.Rutas.Size = new System.Drawing.Size(828, 553);
            this.Rutas.TabIndex = 1;
            this.Rutas.Text = "tabPage2";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "RUTAS";
            // 
            // tabContar
            // 
            this.tabContar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.tabContar.Location = new System.Drawing.Point(4, 25);
            this.tabContar.Name = "tabContar";
            this.tabContar.Size = new System.Drawing.Size(385, 403);
            this.tabContar.TabIndex = 2;
            this.tabContar.Text = "Contar";
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
            // btnTabInsertar
            // 
            this.btnTabInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(235)))));
            this.btnTabInsertar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabInsertar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.btnTabInsertar.Location = new System.Drawing.Point(416, 78);
            this.btnTabInsertar.Name = "btnTabInsertar";
            this.btnTabInsertar.Size = new System.Drawing.Size(122, 47);
            this.btnTabInsertar.TabIndex = 10;
            this.btnTabInsertar.Text = "Insertar";
            this.btnTabInsertar.UseVisualStyleBackColor = false;
            this.btnTabInsertar.Click += new System.EventHandler(this.btnTabInsertar_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(235)))));
            this.btnRecorrer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.btnRecorrer.Location = new System.Drawing.Point(553, 78);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(122, 47);
            this.btnRecorrer.TabIndex = 11;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = false;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // btnContar
            // 
            this.btnContar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(235)))));
            this.btnContar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.btnContar.Location = new System.Drawing.Point(687, 78);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(122, 47);
            this.btnContar.TabIndex = 12;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = false;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1031, 557);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TreeView tvJerarquia;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.TabControl tabControlJerarquia;
        private System.Windows.Forms.TabPage tabInsertar;
        private System.Windows.Forms.TabPage tabRecorrer;
        private System.Windows.Forms.TabPage tabContar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevoPuestoPrincipal;
        private System.Windows.Forms.TextBox tbNuevoPuesto;
        private System.Windows.Forms.Button btnNuevoPuestoSubordinado;
        private System.Windows.Forms.Button btnTabInsertar;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnRecorrer;
    }
}