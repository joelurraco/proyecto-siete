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
            this.tbExperienciaUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCorreoUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbClaveUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPersonajeUsuario = new System.Windows.Forms.TextBox();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNivelUsuario = new System.Windows.Forms.TextBox();
            this.tbDineroUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(172, 41);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(274, 42);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 23);
            this.btNuevo.TabIndex = 2;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(517, 42);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 3;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(355, 42);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 4;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(436, 42);
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
            this.dataGridView1.Size = new System.Drawing.Size(657, 129);
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
            this.tbBuscar.Location = new System.Drawing.Point(46, 44);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(107, 20);
            this.tbBuscar.TabIndex = 8;
            this.tbBuscar.Text = "Buscar...";
            // 
            // tbExperienciaUsuario
            // 
            this.tbExperienciaUsuario.Location = new System.Drawing.Point(436, 332);
            this.tbExperienciaUsuario.Name = "tbExperienciaUsuario";
            this.tbExperienciaUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbExperienciaUsuario.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Experiencia:";
            // 
            // tbCorreoUsuario
            // 
            this.tbCorreoUsuario.Location = new System.Drawing.Point(436, 295);
            this.tbCorreoUsuario.Name = "tbCorreoUsuario";
            this.tbCorreoUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbCorreoUsuario.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Correo:";
            // 
            // tbClaveUsuario
            // 
            this.tbClaveUsuario.Location = new System.Drawing.Point(436, 259);
            this.tbClaveUsuario.Name = "tbClaveUsuario";
            this.tbClaveUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbClaveUsuario.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Contraseña:";
            // 
            // tbPersonajeUsuario
            // 
            this.tbPersonajeUsuario.Location = new System.Drawing.Point(222, 295);
            this.tbPersonajeUsuario.Name = "tbPersonajeUsuario";
            this.tbPersonajeUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbPersonajeUsuario.TabIndex = 27;
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(222, 259);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbNombreUsuario.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tipo de Personaje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre:";
            // 
            // tbNivelUsuario
            // 
            this.tbNivelUsuario.Location = new System.Drawing.Point(222, 366);
            this.tbNivelUsuario.Name = "tbNivelUsuario";
            this.tbNivelUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbNivelUsuario.TabIndex = 40;
            // 
            // tbDineroUsuario
            // 
            this.tbDineroUsuario.Location = new System.Drawing.Point(222, 332);
            this.tbDineroUsuario.Name = "tbDineroUsuario";
            this.tbDineroUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbDineroUsuario.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Nivel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Dinero:";
            // 
            // frmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.tbNivelUsuario);
            this.Controls.Add(this.tbDineroUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbExperienciaUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCorreoUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbClaveUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPersonajeUsuario);
            this.Controls.Add(this.tbNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox tbExperienciaUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCorreoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbClaveUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPersonajeUsuario;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNivelUsuario;
        private System.Windows.Forms.TextBox tbDineroUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

