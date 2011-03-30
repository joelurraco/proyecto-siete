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
            this.components = new System.ComponentModel.Container();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomEnemigo = new System.Windows.Forms.TextBox();
            this.tbPVEnemigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbValorPuntos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAtaque = new System.Windows.Forms.TextBox();
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
            this.bDProyecto7DataSet = new ProyectoSIETE.BDProyecto7DataSet();
            this.enemigoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enemigoTableAdapter = new ProyectoSIETE.BDProyecto7DataSetTableAdapters.EnemigoTableAdapter();
            this.idEnemigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEnemigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ataqueEnemigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidaEnemigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defensaEnemigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntosEnemigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenEnemigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnemigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProyecto7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemigoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.label3.Location = new System.Drawing.Point(307, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor en puntos:";
            // 
            // tbValorPuntos
            // 
            this.tbValorPuntos.Location = new System.Drawing.Point(398, 350);
            this.tbValorPuntos.Name = "tbValorPuntos";
            this.tbValorPuntos.Size = new System.Drawing.Size(100, 20);
            this.tbValorPuntos.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ataque:";
            // 
            // tbAtaque
            // 
            this.tbAtaque.Location = new System.Drawing.Point(398, 386);
            this.tbAtaque.Name = "tbAtaque";
            this.tbAtaque.Size = new System.Drawing.Size(100, 20);
            this.tbAtaque.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Imagen:";
            // 
            // dgvEnemigo
            // 
            this.dgvEnemigo.AllowUserToAddRows = false;
            this.dgvEnemigo.AllowUserToDeleteRows = false;
            this.dgvEnemigo.AllowUserToOrderColumns = true;
            this.dgvEnemigo.AutoGenerateColumns = false;
            this.dgvEnemigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnemigo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.idEnemigoDataGridViewTextBoxColumn,
            this.nombreEnemigoDataGridViewTextBoxColumn,
            this.ataqueEnemigoDataGridViewTextBoxColumn,
            this.vidaEnemigoDataGridViewTextBoxColumn,
            this.defensaEnemigoDataGridViewTextBoxColumn,
            this.puntosEnemigoDataGridViewTextBoxColumn,
            this.imagenEnemigoDataGridViewTextBoxColumn});
            this.dgvEnemigo.DataSource = this.enemigoBindingSource;
            this.dgvEnemigo.Location = new System.Drawing.Point(31, 108);
            this.dgvEnemigo.Name = "dgvEnemigo";
            this.dgvEnemigo.ReadOnly = true;
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
            this.label7.Location = new System.Drawing.Point(341, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Defensa:";
            // 
            // tbDefensa
            // 
            this.tbDefensa.Location = new System.Drawing.Point(398, 423);
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
            this.btnExaminar.Location = new System.Drawing.Point(260, 425);
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
            // bDProyecto7DataSet
            // 
            this.bDProyecto7DataSet.DataSetName = "BDProyecto7DataSet";
            this.bDProyecto7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enemigoBindingSource
            // 
            this.enemigoBindingSource.DataMember = "Enemigo";
            this.enemigoBindingSource.DataSource = this.bDProyecto7DataSet;
            // 
            // enemigoTableAdapter
            // 
            this.enemigoTableAdapter.ClearBeforeFill = true;
            // 
            // idEnemigoDataGridViewTextBoxColumn
            // 
            this.idEnemigoDataGridViewTextBoxColumn.DataPropertyName = "idEnemigo";
            this.idEnemigoDataGridViewTextBoxColumn.HeaderText = "idEnemigo";
            this.idEnemigoDataGridViewTextBoxColumn.Name = "idEnemigoDataGridViewTextBoxColumn";
            this.idEnemigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreEnemigoDataGridViewTextBoxColumn
            // 
            this.nombreEnemigoDataGridViewTextBoxColumn.DataPropertyName = "nombreEnemigo";
            this.nombreEnemigoDataGridViewTextBoxColumn.HeaderText = "nombreEnemigo";
            this.nombreEnemigoDataGridViewTextBoxColumn.Name = "nombreEnemigoDataGridViewTextBoxColumn";
            // 
            // ataqueEnemigoDataGridViewTextBoxColumn
            // 
            this.ataqueEnemigoDataGridViewTextBoxColumn.DataPropertyName = "ataqueEnemigo";
            this.ataqueEnemigoDataGridViewTextBoxColumn.HeaderText = "ataqueEnemigo";
            this.ataqueEnemigoDataGridViewTextBoxColumn.Name = "ataqueEnemigoDataGridViewTextBoxColumn";
            // 
            // vidaEnemigoDataGridViewTextBoxColumn
            // 
            this.vidaEnemigoDataGridViewTextBoxColumn.DataPropertyName = "vidaEnemigo";
            this.vidaEnemigoDataGridViewTextBoxColumn.HeaderText = "vidaEnemigo";
            this.vidaEnemigoDataGridViewTextBoxColumn.Name = "vidaEnemigoDataGridViewTextBoxColumn";
            // 
            // defensaEnemigoDataGridViewTextBoxColumn
            // 
            this.defensaEnemigoDataGridViewTextBoxColumn.DataPropertyName = "defensaEnemigo";
            this.defensaEnemigoDataGridViewTextBoxColumn.HeaderText = "defensaEnemigo";
            this.defensaEnemigoDataGridViewTextBoxColumn.Name = "defensaEnemigoDataGridViewTextBoxColumn";
            // 
            // puntosEnemigoDataGridViewTextBoxColumn
            // 
            this.puntosEnemigoDataGridViewTextBoxColumn.DataPropertyName = "puntosEnemigo";
            this.puntosEnemigoDataGridViewTextBoxColumn.HeaderText = "puntosEnemigo";
            this.puntosEnemigoDataGridViewTextBoxColumn.Name = "puntosEnemigoDataGridViewTextBoxColumn";
            // 
            // imagenEnemigoDataGridViewTextBoxColumn
            // 
            this.imagenEnemigoDataGridViewTextBoxColumn.DataPropertyName = "imagenEnemigo";
            this.imagenEnemigoDataGridViewTextBoxColumn.HeaderText = "imagenEnemigo";
            this.imagenEnemigoDataGridViewTextBoxColumn.Name = "imagenEnemigoDataGridViewTextBoxColumn";
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
            this.Controls.Add(this.tbAtaque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbValorPuntos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPVEnemigo);
            this.Controls.Add(this.tbNomEnemigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmGestionEnemigos";
            this.Text = "Gestión de enemigos";
            this.Load += new System.EventHandler(this.formEnemigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnemigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProyecto7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemigoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomEnemigo;
        private System.Windows.Forms.TextBox tbPVEnemigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbValorPuntos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAtaque;
        private System.Windows.Forms.Label label6;
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
        private BDProyecto7DataSet bDProyecto7DataSet;
        private System.Windows.Forms.BindingSource enemigoBindingSource;
        private BDProyecto7DataSetTableAdapters.EnemigoTableAdapter enemigoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEnemigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEnemigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ataqueEnemigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidaEnemigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defensaEnemigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntosEnemigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenEnemigoDataGridViewTextBoxColumn;
    }
}

