namespace ProyectoSIETE
{
    partial class frmGestionEnemigos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEnemigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proximamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomEnemigo = new System.Windows.Forms.TextBox();
            this.tbPVEnemigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbValorPuntos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAtaque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dudComportamiento = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvEnemigo = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDefensa = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.ofdImagenEnemigo = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnemigo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEnemigoToolStripMenuItem,
            this.volverAMenuToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoEnemigoToolStripMenuItem
            // 
            this.nuevoEnemigoToolStripMenuItem.Name = "nuevoEnemigoToolStripMenuItem";
            this.nuevoEnemigoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.nuevoEnemigoToolStripMenuItem.Text = "Nuevo enemigo";
            this.nuevoEnemigoToolStripMenuItem.Click += new System.EventHandler(this.nuevoEnemigoToolStripMenuItem_Click);
            // 
            // volverAMenuToolStripMenuItem
            // 
            this.volverAMenuToolStripMenuItem.Name = "volverAMenuToolStripMenuItem";
            this.volverAMenuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.volverAMenuToolStripMenuItem.Text = "Volver a menu";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salirToolStripMenuItem.Text = "Buscar";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proximamenteToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // proximamenteToolStripMenuItem
            // 
            this.proximamenteToolStripMenuItem.Name = "proximamenteToolStripMenuItem";
            this.proximamenteToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.proximamenteToolStripMenuItem.Text = "Proximamente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(252, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puntos de vida (PV):";
            // 
            // tbNomEnemigo
            // 
            this.tbNomEnemigo.Location = new System.Drawing.Point(149, 350);
            this.tbNomEnemigo.Name = "tbNomEnemigo";
            this.tbNomEnemigo.Size = new System.Drawing.Size(100, 20);
            this.tbNomEnemigo.TabIndex = 6;
            this.tbNomEnemigo.TextChanged += new System.EventHandler(this.nomEnemigo_TextChanged);
            // 
            // tbPVEnemigo
            // 
            this.tbPVEnemigo.Location = new System.Drawing.Point(149, 386);
            this.tbPVEnemigo.Name = "tbPVEnemigo";
            this.tbPVEnemigo.Size = new System.Drawing.Size(100, 20);
            this.tbPVEnemigo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor en puntos:";
            // 
            // tbValorPuntos
            // 
            this.tbValorPuntos.Location = new System.Drawing.Point(363, 350);
            this.tbValorPuntos.Name = "tbValorPuntos";
            this.tbValorPuntos.Size = new System.Drawing.Size(100, 20);
            this.tbValorPuntos.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ataque:";
            // 
            // tbAtaque
            // 
            this.tbAtaque.Location = new System.Drawing.Point(363, 386);
            this.tbAtaque.Name = "tbAtaque";
            this.tbAtaque.Size = new System.Drawing.Size(100, 20);
            this.tbAtaque.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Comportamiento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dudComportamiento
            // 
            this.dudComportamiento.Location = new System.Drawing.Point(149, 423);
            this.dudComportamiento.Name = "dudComportamiento";
            this.dudComportamiento.Size = new System.Drawing.Size(120, 20);
            this.dudComportamiento.TabIndex = 13;
            this.dudComportamiento.Text = "domainUpDown1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Imagen:";
            // 
            // dgvEnemigo
            // 
            this.dgvEnemigo.AllowUserToOrderColumns = true;
            this.dgvEnemigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnemigo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgvEnemigo.Location = new System.Drawing.Point(31, 108);
            this.dgvEnemigo.Name = "dgvEnemigo";
            this.dgvEnemigo.Size = new System.Drawing.Size(641, 204);
            this.dgvEnemigo.TabIndex = 15;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Buscar...";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(421, 67);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(501, 67);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(582, 67);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Defensa:";
            // 
            // tbDefensa
            // 
            this.tbDefensa.Location = new System.Drawing.Point(363, 423);
            this.tbDefensa.Name = "tbDefensa";
            this.tbDefensa.Size = new System.Drawing.Size(100, 20);
            this.tbDefensa.TabIndex = 21;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(521, 343);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(252, 452);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 23;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // ofdImagenEnemigo
            // 
            this.ofdImagenEnemigo.FileName = "imgEnemigo";
            // 
            // frmGestionEnemigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 547);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbDefensa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dgvEnemigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dudComportamiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAtaque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbValorPuntos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPVEnemigo);
            this.Controls.Add(this.tbNomEnemigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGestionEnemigos";
            this.Text = "Gestión de enemigos";
            this.Load += new System.EventHandler(this.formEnemigos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnemigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEnemigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomEnemigo;
        private System.Windows.Forms.TextBox tbPVEnemigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbValorPuntos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAtaque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown dudComportamiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proximamenteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEnemigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDefensa;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.OpenFileDialog ofdImagenEnemigo;
    }
}

