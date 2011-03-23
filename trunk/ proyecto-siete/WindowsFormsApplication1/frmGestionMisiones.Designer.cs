namespace ProyectoSIETE
{
    partial class frmGestionMisiones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionMisiones));
            this.lbListaMisiones = new System.Windows.Forms.ListBox();
            this.btMisionesSubir = new System.Windows.Forms.Button();
            this.btMisionesBajar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.pListaMisiones = new System.Windows.Forms.Panel();
            this.lbMisiones = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pDatos = new System.Windows.Forms.Panel();
            this.btGuardar = new System.Windows.Forms.Button();
            this.lbDatos = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbMapa = new System.Windows.Forms.Label();
            this.cbMapa = new System.Windows.Forms.ComboBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.gbDetalles = new System.Windows.Forms.GroupBox();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreRecompensa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoRecompensa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cantidadRecompensa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbRecompensasCantidad = new System.Windows.Forms.Label();
            this.lbRecompensasTipo = new System.Windows.Forms.Label();
            this.lbLocalizacion = new System.Windows.Forms.Label();
            this.lbRecompensasNombre = new System.Windows.Forms.Label();
            this.cbLocalizacion = new System.Windows.Forms.ComboBox();
            this.cbDificultad = new System.Windows.Forms.ComboBox();
            this.lbDificultad = new System.Windows.Forms.Label();
            this.lbPuntos = new System.Windows.Forms.Label();
            this.tbPuntos = new System.Windows.Forms.TextBox();
            this.tbRecompensasCantidad = new System.Windows.Forms.TextBox();
            this.cbRecompensasTipo = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btRecompensasAdd = new System.Windows.Forms.Button();
            this.btRecompensasBorrar = new System.Windows.Forms.Button();
            this.btRecompensasEditar = new System.Windows.Forms.Button();
            this.gbPasos = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btPasosBorrar = new System.Windows.Forms.Button();
            this.btPasosEditar = new System.Windows.Forms.Button();
            this.btPasosAdd = new System.Windows.Forms.Button();
            this.btPasosBajar = new System.Windows.Forms.Button();
            this.lbPasos = new System.Windows.Forms.ListBox();
            this.btPasosSubir = new System.Windows.Forms.Button();
            this.gbRecompensas = new System.Windows.Forms.GroupBox();
            this.gbOtros = new System.Windows.Forms.GroupBox();
            this.cbTaberna = new System.Windows.Forms.ComboBox();
            this.ckbTaberna = new System.Windows.Forms.CheckBox();
            this.pListaMisiones.SuspendLayout();
            this.pDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.gbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbPasos.SuspendLayout();
            this.gbOtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbListaMisiones
            // 
            this.lbListaMisiones.FormattingEnabled = true;
            this.lbListaMisiones.Items.AddRange(new object[] {
            "Tutorial"});
            this.lbListaMisiones.Location = new System.Drawing.Point(8, 48);
            this.lbListaMisiones.Name = "lbListaMisiones";
            this.lbListaMisiones.ScrollAlwaysVisible = true;
            this.lbListaMisiones.Size = new System.Drawing.Size(153, 511);
            this.lbListaMisiones.TabIndex = 0;
            // 
            // btMisionesSubir
            // 
            this.btMisionesSubir.Location = new System.Drawing.Point(167, 48);
            this.btMisionesSubir.Name = "btMisionesSubir";
            this.btMisionesSubir.Size = new System.Drawing.Size(42, 23);
            this.btMisionesSubir.TabIndex = 1;
            this.btMisionesSubir.Text = "Subir";
            this.btMisionesSubir.UseVisualStyleBackColor = true;
            // 
            // btMisionesBajar
            // 
            this.btMisionesBajar.Location = new System.Drawing.Point(167, 77);
            this.btMisionesBajar.Name = "btMisionesBajar";
            this.btMisionesBajar.Size = new System.Drawing.Size(42, 23);
            this.btMisionesBajar.TabIndex = 2;
            this.btMisionesBajar.Text = "Bajar";
            this.btMisionesBajar.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(66, 575);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(45, 23);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(117, 575);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(46, 23);
            this.btBorrar.TabIndex = 4;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(8, 575);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(52, 23);
            this.btMostrar.TabIndex = 5;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // pListaMisiones
            // 
            this.pListaMisiones.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pListaMisiones.Controls.Add(this.lbMisiones);
            this.pListaMisiones.Controls.Add(this.btMostrar);
            this.pListaMisiones.Controls.Add(this.btBorrar);
            this.pListaMisiones.Controls.Add(this.btEditar);
            this.pListaMisiones.Controls.Add(this.btMisionesBajar);
            this.pListaMisiones.Controls.Add(this.btMisionesSubir);
            this.pListaMisiones.Controls.Add(this.lbListaMisiones);
            this.pListaMisiones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pListaMisiones.Location = new System.Drawing.Point(0, 0);
            this.pListaMisiones.Margin = new System.Windows.Forms.Padding(0);
            this.pListaMisiones.Name = "pListaMisiones";
            this.pListaMisiones.Size = new System.Drawing.Size(211, 734);
            this.pListaMisiones.TabIndex = 6;
            // 
            // lbMisiones
            // 
            this.lbMisiones.AutoSize = true;
            this.lbMisiones.Location = new System.Drawing.Point(5, 21);
            this.lbMisiones.Name = "lbMisiones";
            this.lbMisiones.Size = new System.Drawing.Size(51, 13);
            this.lbMisiones.TabIndex = 6;
            this.lbMisiones.Text = "Misiones:";
            this.lbMisiones.Click += new System.EventHandler(this.label1_Click);
            // 
            // pDatos
            // 
            this.pDatos.BackColor = System.Drawing.Color.Gainsboro;
            this.pDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pDatos.Controls.Add(this.btGuardar);
            this.pDatos.Controls.Add(this.lbDatos);
            this.pDatos.Controls.Add(this.lbDescripcion);
            this.pDatos.Controls.Add(this.tbDescripcion);
            this.pDatos.Controls.Add(this.tbNombre);
            this.pDatos.Controls.Add(this.lbMapa);
            this.pDatos.Controls.Add(this.cbMapa);
            this.pDatos.Controls.Add(this.lbNombre);
            this.pDatos.Controls.Add(this.pbImagen);
            this.pDatos.Controls.Add(this.gbDetalles);
            this.pDatos.Controls.Add(this.gbOpciones);
            this.pDatos.Controls.Add(this.gbOtros);
            this.pDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDatos.Location = new System.Drawing.Point(211, 0);
            this.pDatos.Margin = new System.Windows.Forms.Padding(0);
            this.pDatos.Name = "pDatos";
            this.pDatos.Size = new System.Drawing.Size(981, 734);
            this.pDatos.TabIndex = 7;
            this.pDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.pDatos_Paint);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(850, 629);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(107, 23);
            this.btGuardar.TabIndex = 30;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbDatos
            // 
            this.lbDatos.AutoSize = true;
            this.lbDatos.Location = new System.Drawing.Point(4, 18);
            this.lbDatos.Name = "lbDatos";
            this.lbDatos.Size = new System.Drawing.Size(38, 13);
            this.lbDatos.TabIndex = 7;
            this.lbDatos.Text = "Datos:";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(26, 415);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbDescripcion.TabIndex = 7;
            this.lbDescripcion.Text = "Descripcion:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.AcceptsReturn = true;
            this.tbDescripcion.Location = new System.Drawing.Point(29, 434);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size(640, 156);
            this.tbDescripcion.TabIndex = 6;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(79, 47);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(268, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // lbMapa
            // 
            this.lbMapa.AutoSize = true;
            this.lbMapa.Location = new System.Drawing.Point(505, 51);
            this.lbMapa.Name = "lbMapa";
            this.lbMapa.Size = new System.Drawing.Size(37, 13);
            this.lbMapa.TabIndex = 4;
            this.lbMapa.Text = "Mapa:";
            // 
            // cbMapa
            // 
            this.cbMapa.FormattingEnabled = true;
            this.cbMapa.Items.AddRange(new object[] {
            "Pueblo"});
            this.cbMapa.Location = new System.Drawing.Point(548, 48);
            this.cbMapa.Name = "cbMapa";
            this.cbMapa.Size = new System.Drawing.Size(121, 21);
            this.cbMapa.TabIndex = 3;
            this.cbMapa.Text = "Selecciona un mapa";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(26, 51);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            this.lbNombre.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.SystemColors.Menu;
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen.Image")));
            this.pbImagen.Location = new System.Drawing.Point(29, 74);
            this.pbImagen.MaximumSize = new System.Drawing.Size(640, 320);
            this.pbImagen.MinimumSize = new System.Drawing.Size(640, 320);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(640, 320);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // gbDetalles
            // 
            this.gbDetalles.BackColor = System.Drawing.Color.Gainsboro;
            this.gbDetalles.Location = new System.Drawing.Point(7, 34);
            this.gbDetalles.Name = "gbDetalles";
            this.gbDetalles.Size = new System.Drawing.Size(678, 574);
            this.gbDetalles.TabIndex = 31;
            this.gbDetalles.TabStop = false;
            this.gbDetalles.Text = "Detalles";
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.dataGridView1);
            this.gbOpciones.Controls.Add(this.lbRecompensasCantidad);
            this.gbOpciones.Controls.Add(this.lbRecompensasTipo);
            this.gbOpciones.Controls.Add(this.lbLocalizacion);
            this.gbOpciones.Controls.Add(this.lbRecompensasNombre);
            this.gbOpciones.Controls.Add(this.cbLocalizacion);
            this.gbOpciones.Controls.Add(this.cbDificultad);
            this.gbOpciones.Controls.Add(this.lbDificultad);
            this.gbOpciones.Controls.Add(this.lbPuntos);
            this.gbOpciones.Controls.Add(this.tbPuntos);
            this.gbOpciones.Controls.Add(this.tbRecompensasCantidad);
            this.gbOpciones.Controls.Add(this.cbRecompensasTipo);
            this.gbOpciones.Controls.Add(this.textBox2);
            this.gbOpciones.Controls.Add(this.btRecompensasAdd);
            this.gbOpciones.Controls.Add(this.btRecompensasBorrar);
            this.gbOpciones.Controls.Add(this.btRecompensasEditar);
            this.gbOpciones.Controls.Add(this.gbPasos);
            this.gbOpciones.Controls.Add(this.gbRecompensas);
            this.gbOpciones.Location = new System.Drawing.Point(691, 34);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(284, 510);
            this.gbOpciones.TabIndex = 32;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreRecompensa,
            this.tipoRecompensa,
            this.cantidadRecompensa});
            this.dataGridView1.Location = new System.Drawing.Point(16, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(249, 105);
            this.dataGridView1.TabIndex = 14;
            // 
            // nombreRecompensa
            // 
            this.nombreRecompensa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreRecompensa.HeaderText = "Nombre";
            this.nombreRecompensa.Name = "nombreRecompensa";
            this.nombreRecompensa.ReadOnly = true;
            // 
            // tipoRecompensa
            // 
            this.tipoRecompensa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tipoRecompensa.HeaderText = "Tipo";
            this.tipoRecompensa.Name = "tipoRecompensa";
            this.tipoRecompensa.ReadOnly = true;
            this.tipoRecompensa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipoRecompensa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cantidadRecompensa
            // 
            this.cantidadRecompensa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadRecompensa.HeaderText = "Cantidad";
            this.cantidadRecompensa.Name = "cantidadRecompensa";
            this.cantidadRecompensa.ReadOnly = true;
            // 
            // lbRecompensasCantidad
            // 
            this.lbRecompensasCantidad.AutoSize = true;
            this.lbRecompensasCantidad.Location = new System.Drawing.Point(195, 365);
            this.lbRecompensasCantidad.Name = "lbRecompensasCantidad";
            this.lbRecompensasCantidad.Size = new System.Drawing.Size(52, 13);
            this.lbRecompensasCantidad.TabIndex = 23;
            this.lbRecompensasCantidad.Text = "Cantidad:";
            // 
            // lbRecompensasTipo
            // 
            this.lbRecompensasTipo.AutoSize = true;
            this.lbRecompensasTipo.Location = new System.Drawing.Point(114, 365);
            this.lbRecompensasTipo.Name = "lbRecompensasTipo";
            this.lbRecompensasTipo.Size = new System.Drawing.Size(31, 13);
            this.lbRecompensasTipo.TabIndex = 20;
            this.lbRecompensasTipo.Text = "Tipo:";
            // 
            // lbLocalizacion
            // 
            this.lbLocalizacion.AutoSize = true;
            this.lbLocalizacion.Location = new System.Drawing.Point(13, 19);
            this.lbLocalizacion.Name = "lbLocalizacion";
            this.lbLocalizacion.Size = new System.Drawing.Size(111, 13);
            this.lbLocalizacion.TabIndex = 8;
            this.lbLocalizacion.Text = "Localizacion de inicio:";
            // 
            // lbRecompensasNombre
            // 
            this.lbRecompensasNombre.AutoSize = true;
            this.lbRecompensasNombre.Location = new System.Drawing.Point(16, 365);
            this.lbRecompensasNombre.Name = "lbRecompensasNombre";
            this.lbRecompensasNombre.Size = new System.Drawing.Size(47, 13);
            this.lbRecompensasNombre.TabIndex = 19;
            this.lbRecompensasNombre.Text = "Nombre:";
            // 
            // cbLocalizacion
            // 
            this.cbLocalizacion.FormattingEnabled = true;
            this.cbLocalizacion.Items.AddRange(new object[] {
            "Molino"});
            this.cbLocalizacion.Location = new System.Drawing.Point(130, 16);
            this.cbLocalizacion.Name = "cbLocalizacion";
            this.cbLocalizacion.Size = new System.Drawing.Size(146, 21);
            this.cbLocalizacion.TabIndex = 9;
            this.cbLocalizacion.Text = "Selecciona un lugar";
            this.cbLocalizacion.SelectedIndexChanged += new System.EventHandler(this.cbLocalizacion_SelectedIndexChanged);
            // 
            // cbDificultad
            // 
            this.cbDificultad.FormattingEnabled = true;
            this.cbDificultad.Items.AddRange(new object[] {
            "Fácil",
            "Normal",
            "Dificil"});
            this.cbDificultad.Location = new System.Drawing.Point(118, 483);
            this.cbDificultad.Name = "cbDificultad";
            this.cbDificultad.Size = new System.Drawing.Size(148, 21);
            this.cbDificultad.TabIndex = 27;
            this.cbDificultad.Text = "Selecciona un nivel";
            // 
            // lbDificultad
            // 
            this.lbDificultad.AutoSize = true;
            this.lbDificultad.Location = new System.Drawing.Point(17, 486);
            this.lbDificultad.Name = "lbDificultad";
            this.lbDificultad.Size = new System.Drawing.Size(54, 13);
            this.lbDificultad.TabIndex = 26;
            this.lbDificultad.Text = "Dificultad:";
            // 
            // lbPuntos
            // 
            this.lbPuntos.AutoSize = true;
            this.lbPuntos.Location = new System.Drawing.Point(17, 451);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(89, 13);
            this.lbPuntos.TabIndex = 25;
            this.lbPuntos.Text = "Puntos Ganados:";
            // 
            // tbPuntos
            // 
            this.tbPuntos.Location = new System.Drawing.Point(118, 448);
            this.tbPuntos.Name = "tbPuntos";
            this.tbPuntos.Size = new System.Drawing.Size(148, 20);
            this.tbPuntos.TabIndex = 24;
            this.tbPuntos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbRecompensasCantidad
            // 
            this.tbRecompensasCantidad.Location = new System.Drawing.Point(198, 381);
            this.tbRecompensasCantidad.Name = "tbRecompensasCantidad";
            this.tbRecompensasCantidad.Size = new System.Drawing.Size(67, 20);
            this.tbRecompensasCantidad.TabIndex = 22;
            // 
            // cbRecompensasTipo
            // 
            this.cbRecompensasTipo.FormattingEnabled = true;
            this.cbRecompensasTipo.Location = new System.Drawing.Point(115, 380);
            this.cbRecompensasTipo.Name = "cbRecompensasTipo";
            this.cbRecompensasTipo.Size = new System.Drawing.Size(64, 21);
            this.cbRecompensasTipo.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 381);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 20);
            this.textBox2.TabIndex = 15;
            // 
            // btRecompensasAdd
            // 
            this.btRecompensasAdd.Location = new System.Drawing.Point(64, 407);
            this.btRecompensasAdd.Name = "btRecompensasAdd";
            this.btRecompensasAdd.Size = new System.Drawing.Size(63, 23);
            this.btRecompensasAdd.TabIndex = 16;
            this.btRecompensasAdd.Text = "Añadir";
            this.btRecompensasAdd.UseVisualStyleBackColor = true;
            // 
            // btRecompensasBorrar
            // 
            this.btRecompensasBorrar.Location = new System.Drawing.Point(202, 407);
            this.btRecompensasBorrar.Name = "btRecompensasBorrar";
            this.btRecompensasBorrar.Size = new System.Drawing.Size(63, 23);
            this.btRecompensasBorrar.TabIndex = 18;
            this.btRecompensasBorrar.Text = "Borrar";
            this.btRecompensasBorrar.UseVisualStyleBackColor = true;
            // 
            // btRecompensasEditar
            // 
            this.btRecompensasEditar.Location = new System.Drawing.Point(133, 407);
            this.btRecompensasEditar.Name = "btRecompensasEditar";
            this.btRecompensasEditar.Size = new System.Drawing.Size(63, 23);
            this.btRecompensasEditar.TabIndex = 17;
            this.btRecompensasEditar.Text = "Editar";
            this.btRecompensasEditar.UseVisualStyleBackColor = true;
            // 
            // gbPasos
            // 
            this.gbPasos.Controls.Add(this.textBox1);
            this.gbPasos.Controls.Add(this.btPasosBorrar);
            this.gbPasos.Controls.Add(this.btPasosEditar);
            this.gbPasos.Controls.Add(this.btPasosAdd);
            this.gbPasos.Controls.Add(this.btPasosBajar);
            this.gbPasos.Controls.Add(this.lbPasos);
            this.gbPasos.Controls.Add(this.btPasosSubir);
            this.gbPasos.Location = new System.Drawing.Point(6, 35);
            this.gbPasos.Name = "gbPasos";
            this.gbPasos.Size = new System.Drawing.Size(270, 185);
            this.gbPasos.TabIndex = 28;
            this.gbPasos.TabStop = false;
            this.gbPasos.Text = "Pasos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 10;
            // 
            // btPasosBorrar
            // 
            this.btPasosBorrar.Location = new System.Drawing.Point(216, 146);
            this.btPasosBorrar.Name = "btPasosBorrar";
            this.btPasosBorrar.Size = new System.Drawing.Size(43, 23);
            this.btPasosBorrar.TabIndex = 13;
            this.btPasosBorrar.Text = "Borrar";
            this.btPasosBorrar.UseVisualStyleBackColor = true;
            // 
            // btPasosEditar
            // 
            this.btPasosEditar.Location = new System.Drawing.Point(167, 146);
            this.btPasosEditar.Name = "btPasosEditar";
            this.btPasosEditar.Size = new System.Drawing.Size(43, 23);
            this.btPasosEditar.TabIndex = 12;
            this.btPasosEditar.Text = "Editar";
            this.btPasosEditar.UseVisualStyleBackColor = true;
            // 
            // btPasosAdd
            // 
            this.btPasosAdd.Location = new System.Drawing.Point(111, 146);
            this.btPasosAdd.Name = "btPasosAdd";
            this.btPasosAdd.Size = new System.Drawing.Size(50, 23);
            this.btPasosAdd.TabIndex = 11;
            this.btPasosAdd.Text = "Añadir";
            this.btPasosAdd.UseVisualStyleBackColor = true;
            // 
            // btPasosBajar
            // 
            this.btPasosBajar.Location = new System.Drawing.Point(110, 50);
            this.btPasosBajar.Name = "btPasosBajar";
            this.btPasosBajar.Size = new System.Drawing.Size(42, 23);
            this.btPasosBajar.TabIndex = 8;
            this.btPasosBajar.Text = "Bajar";
            this.btPasosBajar.UseVisualStyleBackColor = true;
            // 
            // lbPasos
            // 
            this.lbPasos.FormattingEnabled = true;
            this.lbPasos.Items.AddRange(new object[] {
            "Parte1",
            "Parte2"});
            this.lbPasos.Location = new System.Drawing.Point(9, 21);
            this.lbPasos.Name = "lbPasos";
            this.lbPasos.ScrollAlwaysVisible = true;
            this.lbPasos.Size = new System.Drawing.Size(95, 147);
            this.lbPasos.TabIndex = 7;
            // 
            // btPasosSubir
            // 
            this.btPasosSubir.Location = new System.Drawing.Point(110, 21);
            this.btPasosSubir.Name = "btPasosSubir";
            this.btPasosSubir.Size = new System.Drawing.Size(42, 23);
            this.btPasosSubir.TabIndex = 7;
            this.btPasosSubir.Text = "Subir";
            this.btPasosSubir.UseVisualStyleBackColor = true;
            // 
            // gbRecompensas
            // 
            this.gbRecompensas.Location = new System.Drawing.Point(6, 226);
            this.gbRecompensas.Name = "gbRecompensas";
            this.gbRecompensas.Size = new System.Drawing.Size(270, 216);
            this.gbRecompensas.TabIndex = 29;
            this.gbRecompensas.TabStop = false;
            this.gbRecompensas.Text = "Recompensas";
            // 
            // gbOtros
            // 
            this.gbOtros.Controls.Add(this.cbTaberna);
            this.gbOtros.Controls.Add(this.ckbTaberna);
            this.gbOtros.Location = new System.Drawing.Point(692, 550);
            this.gbOtros.Name = "gbOtros";
            this.gbOtros.Size = new System.Drawing.Size(283, 58);
            this.gbOtros.TabIndex = 33;
            this.gbOtros.TabStop = false;
            this.gbOtros.Text = "Otros";
            // 
            // cbTaberna
            // 
            this.cbTaberna.Enabled = false;
            this.cbTaberna.FormattingEnabled = true;
            this.cbTaberna.Location = new System.Drawing.Point(117, 21);
            this.cbTaberna.Name = "cbTaberna";
            this.cbTaberna.Size = new System.Drawing.Size(148, 21);
            this.cbTaberna.TabIndex = 29;
            this.cbTaberna.Text = "Selecciona un lugar";
            this.cbTaberna.SelectedIndexChanged += new System.EventHandler(this.cbTaberna_SelectedIndexChanged);
            // 
            // ckbTaberna
            // 
            this.ckbTaberna.AutoSize = true;
            this.ckbTaberna.Location = new System.Drawing.Point(19, 23);
            this.ckbTaberna.Name = "ckbTaberna";
            this.ckbTaberna.Size = new System.Drawing.Size(97, 17);
            this.ckbTaberna.TabIndex = 28;
            this.ckbTaberna.Text = "Incluir Taberna";
            this.ckbTaberna.UseVisualStyleBackColor = true;
            this.ckbTaberna.CheckedChanged += new System.EventHandler(this.ckbTaberna_CheckedChanged);
            // 
            // frmGestionMisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 734);
            this.Controls.Add(this.pDatos);
            this.Controls.Add(this.pListaMisiones);
            this.Name = "frmGestionMisiones";
            this.Text = "Gestion de Misiones";
            this.Load += new System.EventHandler(this.frmGestionMisiones_Load);
            this.pListaMisiones.ResumeLayout(false);
            this.pListaMisiones.PerformLayout();
            this.pDatos.ResumeLayout(false);
            this.pDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbPasos.ResumeLayout(false);
            this.gbPasos.PerformLayout();
            this.gbOtros.ResumeLayout(false);
            this.gbOtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListaMisiones;
        private System.Windows.Forms.Button btMisionesSubir;
        private System.Windows.Forms.Button btMisionesBajar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Panel pListaMisiones;
        private System.Windows.Forms.Label lbMisiones;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pDatos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btPasosBajar;
        private System.Windows.Forms.ListBox lbPasos;
        private System.Windows.Forms.Button btPasosSubir;
        private System.Windows.Forms.ComboBox cbLocalizacion;
        private System.Windows.Forms.Label lbLocalizacion;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbMapa;
        private System.Windows.Forms.ComboBox cbMapa;
        private System.Windows.Forms.Label lbPuntos;
        private System.Windows.Forms.TextBox tbPuntos;
        private System.Windows.Forms.Label lbRecompensasCantidad;
        private System.Windows.Forms.TextBox tbRecompensasCantidad;
        private System.Windows.Forms.ComboBox cbRecompensasTipo;
        private System.Windows.Forms.Label lbRecompensasTipo;
        private System.Windows.Forms.Label lbRecompensasNombre;
        private System.Windows.Forms.Button btRecompensasBorrar;
        private System.Windows.Forms.Button btRecompensasEditar;
        private System.Windows.Forms.Button btRecompensasAdd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRecompensa;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipoRecompensa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadRecompensa;
        private System.Windows.Forms.Label lbDatos;
        private System.Windows.Forms.Button btPasosBorrar;
        private System.Windows.Forms.Button btPasosEditar;
        private System.Windows.Forms.Button btPasosAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbTaberna;
        private System.Windows.Forms.CheckBox ckbTaberna;
        private System.Windows.Forms.ComboBox cbDificultad;
        private System.Windows.Forms.Label lbDificultad;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.GroupBox gbDetalles;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.GroupBox gbOtros;
        private System.Windows.Forms.GroupBox gbPasos;
        private System.Windows.Forms.GroupBox gbRecompensas;

    }
}