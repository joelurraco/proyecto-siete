namespace ProyectoSIETE
{
    partial class frmGestionObjetos
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbBuscador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCoste = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAtributo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevoTipo = new System.Windows.Forms.Button();
            this.tbNuevoTipo = new System.Windows.Forms.TextBox();
            this.btnBorrarTipo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bDProyecto7DataSet = new ProyectoSIETE.BDProyecto7DataSet();
            this.bDProyecto7DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objetoTableAdapter = new ProyectoSIETE.BDProyecto7DataSetTableAdapters.ObjetoTableAdapter();
            this.idObjetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcionObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDProyecto7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProyecto7DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(633, 37);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(552, 108);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObjetoDataGridViewTextBoxColumn,
            this.dgvNombreObjeto,
            this.dgvDescripcionObjeto});
            this.dgvItems.DataSource = this.objetoBindingSource;
            this.dgvItems.Location = new System.Drawing.Point(12, 73);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(760, 223);
            this.dgvItems.TabIndex = 4;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(245, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbBuscador
            // 
            this.tbBuscador.Location = new System.Drawing.Point(14, 37);
            this.tbBuscador.Name = "tbBuscador";
            this.tbBuscador.Size = new System.Drawing.Size(225, 20);
            this.tbBuscador.TabIndex = 6;
            this.tbBuscador.Text = "Buscar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Precio";
            // 
            // tbCoste
            // 
            this.tbCoste.Location = new System.Drawing.Point(114, 206);
            this.tbCoste.Name = "tbCoste";
            this.tbCoste.Size = new System.Drawing.Size(176, 20);
            this.tbCoste.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Atributo";
            // 
            // tbAtributo
            // 
            this.tbAtributo.Location = new System.Drawing.Point(114, 159);
            this.tbAtributo.Name = "tbAtributo";
            this.tbAtributo.Size = new System.Drawing.Size(176, 20);
            this.tbAtributo.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arma",
            "Armadura",
            "Casco",
            "Botas",
            "Poción",
            "Otros"});
            this.comboBox1.Location = new System.Drawing.Point(114, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tipo de objeto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descripción";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(552, 33);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(192, 56);
            this.tbDescripcion.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(114, 34);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(176, 20);
            this.tbNombre.TabIndex = 13;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(451, 37);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(543, 37);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevoTipo
            // 
            this.btnNuevoTipo.Location = new System.Drawing.Point(309, 70);
            this.btnNuevoTipo.Name = "btnNuevoTipo";
            this.btnNuevoTipo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoTipo.TabIndex = 25;
            this.btnNuevoTipo.Text = "Nuevo";
            this.btnNuevoTipo.UseVisualStyleBackColor = true;
            // 
            // tbNuevoTipo
            // 
            this.tbNuevoTipo.Location = new System.Drawing.Point(114, 73);
            this.tbNuevoTipo.Name = "tbNuevoTipo";
            this.tbNuevoTipo.Size = new System.Drawing.Size(176, 20);
            this.tbNuevoTipo.TabIndex = 26;
            // 
            // btnBorrarTipo
            // 
            this.btnBorrarTipo.Location = new System.Drawing.Point(309, 110);
            this.btnBorrarTipo.Name = "btnBorrarTipo";
            this.btnBorrarTipo.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarTipo.TabIndex = 27;
            this.btnBorrarTipo.Text = "Borrar";
            this.btnBorrarTipo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nuevo tipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBorrarTipo);
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNuevoTipo);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevoTipo);
            this.groupBox1.Controls.Add(this.tbAtributo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCoste);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 240);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // bDProyecto7DataSet
            // 
            this.bDProyecto7DataSet.DataSetName = "BDProyecto7DataSet";
            this.bDProyecto7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDProyecto7DataSetBindingSource
            // 
            this.bDProyecto7DataSetBindingSource.DataSource = this.bDProyecto7DataSet;
            this.bDProyecto7DataSetBindingSource.Position = 0;
            // 
            // objetoBindingSource
            // 
            this.objetoBindingSource.DataMember = "Objeto";
            this.objetoBindingSource.DataSource = this.bDProyecto7DataSetBindingSource;
            // 
            // objetoTableAdapter
            // 
            this.objetoTableAdapter.ClearBeforeFill = true;
            // 
            // idObjetoDataGridViewTextBoxColumn
            // 
            this.idObjetoDataGridViewTextBoxColumn.DataPropertyName = "idObjeto";
            this.idObjetoDataGridViewTextBoxColumn.HeaderText = "idObjeto";
            this.idObjetoDataGridViewTextBoxColumn.Name = "idObjetoDataGridViewTextBoxColumn";
            this.idObjetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idObjetoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idObjetoDataGridViewTextBoxColumn.Visible = false;
            this.idObjetoDataGridViewTextBoxColumn.Width = 5;
            // 
            // dgvNombreObjeto
            // 
            this.dgvNombreObjeto.DataPropertyName = "nombreObjeto";
            this.dgvNombreObjeto.HeaderText = "Nombre";
            this.dgvNombreObjeto.Name = "dgvNombreObjeto";
            this.dgvNombreObjeto.ReadOnly = true;
            this.dgvNombreObjeto.Width = 250;
            // 
            // dgvDescripcionObjeto
            // 
            this.dgvDescripcionObjeto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDescripcionObjeto.DataPropertyName = "descripcionObjeto";
            this.dgvDescripcionObjeto.HeaderText = "Descripción";
            this.dgvDescripcionObjeto.Name = "dgvDescripcionObjeto";
            this.dgvDescripcionObjeto.ReadOnly = true;
            // 
            // frmGestionObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(882, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.tbBuscador);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnBorrar);
            this.Name = "frmGestionObjetos";
            this.Text = "Gestión de objetos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDProyecto7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProyecto7DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCoste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAtributo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevoTipo;
        private System.Windows.Forms.TextBox tbNuevoTipo;
        private System.Windows.Forms.Button btnBorrarTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bDProyecto7DataSetBindingSource;
        private BDProyecto7DataSet bDProyecto7DataSet;
        private System.Windows.Forms.BindingSource objetoBindingSource;
        private BDProyecto7DataSetTableAdapters.ObjetoTableAdapter objetoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreObjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcionObjeto;
    }
}

