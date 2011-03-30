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
            this.NombrePersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VidaPersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtaquePersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefensaPersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbDefensaPersonaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAtaquePesonaje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVidaPersonaje = new System.Windows.Forms.TextBox();
            this.tbTipoPersonaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(35, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(700, 136);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(259, 46);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 23);
            this.btNuevo.TabIndex = 1;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(340, 46);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 5;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(650, 336);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.button6_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(36, 48);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 20);
            this.tbBuscar.TabIndex = 12;
            this.tbBuscar.Text = "Buscar...";
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(508, 46);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 10;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(421, 46);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(75, 23);
            this.btMostrar.TabIndex = 9;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(142, 45);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 11;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // tbDefensaPersonaje
            // 
            this.tbDefensaPersonaje.Location = new System.Drawing.Point(283, 297);
            this.tbDefensaPersonaje.Name = "tbDefensaPersonaje";
            this.tbDefensaPersonaje.Size = new System.Drawing.Size(100, 20);
            this.tbDefensaPersonaje.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Defensa:";
            // 
            // tbAtaquePesonaje
            // 
            this.tbAtaquePesonaje.Location = new System.Drawing.Point(283, 261);
            this.tbAtaquePesonaje.Name = "tbAtaquePesonaje";
            this.tbAtaquePesonaje.Size = new System.Drawing.Size(100, 20);
            this.tbAtaquePesonaje.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Ataque:";
            // 
            // tbVidaPersonaje
            // 
            this.tbVidaPersonaje.Location = new System.Drawing.Point(69, 297);
            this.tbVidaPersonaje.Name = "tbVidaPersonaje";
            this.tbVidaPersonaje.Size = new System.Drawing.Size(100, 20);
            this.tbVidaPersonaje.TabIndex = 44;
            // 
            // tbTipoPersonaje
            // 
            this.tbTipoPersonaje.Location = new System.Drawing.Point(69, 261);
            this.tbTipoPersonaje.Name = "tbTipoPersonaje";
            this.tbTipoPersonaje.Size = new System.Drawing.Size(100, 20);
            this.tbTipoPersonaje.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Vida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tipo:";
            // 
            // frmGestionPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 380);
            this.Controls.Add(this.tbDefensaPersonaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAtaquePesonaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVidaPersonaje);
            this.Controls.Add(this.tbTipoPersonaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmGestionPersonajes";
            this.Text = "GestionPersonajes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox tbDefensaPersonaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAtaquePesonaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVidaPersonaje;
        private System.Windows.Forms.TextBox tbTipoPersonaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}