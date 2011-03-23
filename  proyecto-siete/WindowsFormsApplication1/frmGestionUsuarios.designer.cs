namespace ProyectoSIETE
{
    partial class frmGestionUsuarios
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
            this.btBuscar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonajeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExperienciaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscar.Location = new System.Drawing.Point(628, 45);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(46, 45);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 23);
            this.btNuevo.TabIndex = 2;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(289, 45);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 3;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(127, 45);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 4;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(208, 45);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(75, 23);
            this.btMostrar.TabIndex = 5;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalir.Location = new System.Drawing.Point(628, 396);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreUsuario,
            this.CorreoUsuario,
            this.PersonajeUsuario,
            this.ExperienciaUsuario});
            this.dataGridView1.Location = new System.Drawing.Point(46, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(657, 278);
            this.dataGridView1.TabIndex = 7;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "Nombre";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            // 
            // CorreoUsuario
            // 
            this.CorreoUsuario.HeaderText = "Correo";
            this.CorreoUsuario.Name = "CorreoUsuario";
            this.CorreoUsuario.ReadOnly = true;
            // 
            // PersonajeUsuario
            // 
            this.PersonajeUsuario.HeaderText = "Personaje";
            this.PersonajeUsuario.Name = "PersonajeUsuario";
            this.PersonajeUsuario.ReadOnly = true;
            // 
            // ExperienciaUsuario
            // 
            this.ExperienciaUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExperienciaUsuario.HeaderText = "Experiencia";
            this.ExperienciaUsuario.Name = "ExperienciaUsuario";
            this.ExperienciaUsuario.ReadOnly = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscar.Location = new System.Drawing.Point(448, 45);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(174, 20);
            this.tbBuscar.TabIndex = 8;
            this.tbBuscar.Text = "Buscar...";
            // 
            // frmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.btBuscar);
            this.Name = "frmGestionUsuarios";
            this.Text = "Gestion de Usuarios";
            this.Load += new System.EventHandler(this.frmGestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonajeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExperienciaUsuario;
        private System.Windows.Forms.TextBox tbBuscar;
    }
}

