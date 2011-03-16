namespace ProyectoSIETE
{
    partial class frmGestionMapas
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreMapa = new System.Windows.Forms.TextBox();
            this.pbMapa = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPosicion = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubirMapa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbLocalizaciones = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarLocalizacion = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            this.gbPosicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // tbNombreMapa
            // 
            this.tbNombreMapa.Location = new System.Drawing.Point(83, 72);
            this.tbNombreMapa.Name = "tbNombreMapa";
            this.tbNombreMapa.Size = new System.Drawing.Size(100, 20);
            this.tbNombreMapa.TabIndex = 1;
            // 
            // pbMapa
            // 
            this.pbMapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMapa.Location = new System.Drawing.Point(33, 132);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(313, 266);
            this.pbMapa.TabIndex = 2;
            this.pbMapa.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imagen:";
            // 
            // gbPosicion
            // 
            this.gbPosicion.Controls.Add(this.btnSeleccionar);
            this.gbPosicion.Controls.Add(this.numericUpDown2);
            this.gbPosicion.Controls.Add(this.numericUpDown1);
            this.gbPosicion.Controls.Add(this.label4);
            this.gbPosicion.Controls.Add(this.label3);
            this.gbPosicion.Location = new System.Drawing.Point(352, 240);
            this.gbPosicion.Name = "gbPosicion";
            this.gbPosicion.Size = new System.Drawing.Size(162, 129);
            this.gbPosicion.TabIndex = 4;
            this.gbPosicion.TabStop = false;
            this.gbPosicion.Text = "Posición:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(28, 56);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(28, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "X";
            // 
            // btnSubirMapa
            // 
            this.btnSubirMapa.Location = new System.Drawing.Point(83, 104);
            this.btnSubirMapa.Name = "btnSubirMapa";
            this.btnSubirMapa.Size = new System.Drawing.Size(100, 23);
            this.btnSubirMapa.TabIndex = 5;
            this.btnSubirMapa.Text = "Subir";
            this.btnSubirMapa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Posicion});
            this.dataGridView1.Location = new System.Drawing.Point(520, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(230, 266);
            this.dataGridView1.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Posicion";
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            this.Posicion.Width = 50;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(610, 425);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(698, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Localizaciones del Mapa:";
            // 
            // lbLocalizaciones
            // 
            this.lbLocalizaciones.FormattingEnabled = true;
            this.lbLocalizaciones.Location = new System.Drawing.Point(352, 132);
            this.lbLocalizaciones.Name = "lbLocalizaciones";
            this.lbLocalizaciones.Size = new System.Drawing.Size(162, 95);
            this.lbLocalizaciones.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Localizacion:";
            // 
            // btnAgregarLocalizacion
            // 
            this.btnAgregarLocalizacion.Location = new System.Drawing.Point(352, 375);
            this.btnAgregarLocalizacion.Name = "btnAgregarLocalizacion";
            this.btnAgregarLocalizacion.Size = new System.Drawing.Size(162, 23);
            this.btnAgregarLocalizacion.TabIndex = 12;
            this.btnAgregarLocalizacion.Text = "Agregar Localización";
            this.btnAgregarLocalizacion.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(28, 93);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(120, 23);
            this.btnSeleccionar.TabIndex = 13;
            this.btnSeleccionar.Text = "Seleccionar del Mapa";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // GestionMapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 465);
            this.Controls.Add(this.btnAgregarLocalizacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbLocalizaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubirMapa);
            this.Controls.Add(this.gbPosicion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbMapa);
            this.Controls.Add(this.tbNombreMapa);
            this.Controls.Add(this.label1);
            this.Name = "GestionMapas";
            this.Text = "Gestión de Mapas";
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).EndInit();
            this.gbPosicion.ResumeLayout(false);
            this.gbPosicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreMapa;
        private System.Windows.Forms.PictureBox pbMapa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPosicion;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubirMapa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbLocalizaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarLocalizacion;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}