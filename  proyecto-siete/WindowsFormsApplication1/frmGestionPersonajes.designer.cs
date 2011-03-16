namespace ProyectoSIETE
{
    partial class frmGestionPersonajes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.NombrePersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VidaPersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtaquePersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefensaPersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePersonaje,
            this.VidaPersonaje,
            this.AtaquePersonaje,
            this.DefensaPersonaje});
            this.dataGridView1.Location = new System.Drawing.Point(25, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(700, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(25, 36);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 23);
            this.btNuevo.TabIndex = 1;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(106, 36);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 5;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(650, 348);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.button6_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscar.Location = new System.Drawing.Point(490, 39);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(163, 20);
            this.tbBuscar.TabIndex = 12;
            this.tbBuscar.Text = "Buscar...";
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(274, 36);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 10;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(187, 36);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(75, 23);
            this.btMostrar.TabIndex = 9;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscar.Location = new System.Drawing.Point(659, 36);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 11;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // NombrePersonaje
            // 
            this.NombrePersonaje.HeaderText = "Nombre";
            this.NombrePersonaje.Name = "NombrePersonaje";
            this.NombrePersonaje.ReadOnly = true;
            // 
            // VidaPersonaje
            // 
            this.VidaPersonaje.HeaderText = "Vida Inicial";
            this.VidaPersonaje.Name = "VidaPersonaje";
            this.VidaPersonaje.ReadOnly = true;
            // 
            // AtaquePersonaje
            // 
            this.AtaquePersonaje.HeaderText = "Ataque";
            this.AtaquePersonaje.Name = "AtaquePersonaje";
            this.AtaquePersonaje.ReadOnly = true;
            // 
            // DefensaPersonaje
            // 
            this.DefensaPersonaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DefensaPersonaje.HeaderText = "Defensa";
            this.DefensaPersonaje.Name = "DefensaPersonaje";
            this.DefensaPersonaje.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // GestionPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 380);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionPersonajes";
            this.Text = "GestionPersonajes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePersonaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn VidaPersonaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtaquePersonaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefensaPersonaje;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}