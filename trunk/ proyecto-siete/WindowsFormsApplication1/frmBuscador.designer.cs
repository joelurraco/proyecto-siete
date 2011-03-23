namespace ProyectoSIETE
{
    partial class frmBuscador
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Personajes");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Enemigos");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Armas");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Objetos", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Mapas");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Misiones");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Localizaciones");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Usuarios");
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonajes = new System.Windows.Forms.TabPage();
            this.tabEnemigos = new System.Windows.Forms.TabPage();
            this.tabObjetos = new System.Windows.Forms.TabPage();
            this.tabMapas = new System.Windows.Forms.TabPage();
            this.tabMisiones = new System.Windows.Forms.TabPage();
            this.tabLocalizaciones = new System.Windows.Forms.TabPage();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPersonajes.SuspendLayout();
            this.tabEnemigos.SuspendLayout();
            this.tabObjetos.SuspendLayout();
            this.tabMapas.SuspendLayout();
            this.tabMisiones.SuspendLayout();
            this.tabLocalizaciones.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Criterios:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(90, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Todos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Palabra de búsqueda:";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(40, 65);
            this.treeView1.Name = "treeView1";
            treeNode9.Checked = true;
            treeNode9.Name = "Nodo0";
            treeNode9.Text = "Personajes";
            treeNode10.Checked = true;
            treeNode10.Name = "Nodo1";
            treeNode10.Text = "Enemigos";
            treeNode11.Checked = true;
            treeNode11.Name = "Nodo7";
            treeNode11.Text = "Armas";
            treeNode12.Checked = true;
            treeNode12.Name = "Nodo2";
            treeNode12.Text = "Objetos";
            treeNode13.Checked = true;
            treeNode13.Name = "Nodo3";
            treeNode13.Text = "Mapas";
            treeNode14.Checked = true;
            treeNode14.Name = "Nodo4";
            treeNode14.Text = "Misiones";
            treeNode15.Checked = true;
            treeNode15.Name = "Nodo5";
            treeNode15.Text = "Localizaciones";
            treeNode16.Checked = true;
            treeNode16.Name = "Nodo6";
            treeNode16.Text = "Usuarios";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(146, 138);
            this.treeView1.TabIndex = 9;
            //this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 163);
            this.dataGridView1.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEnemigos);
            this.tabControl1.Controls.Add(this.tabPersonajes);
            this.tabControl1.Controls.Add(this.tabObjetos);
            this.tabControl1.Controls.Add(this.tabMapas);
            this.tabControl1.Controls.Add(this.tabMisiones);
            this.tabControl1.Controls.Add(this.tabLocalizaciones);
            this.tabControl1.Controls.Add(this.tabUsuarios);
            this.tabControl1.Location = new System.Drawing.Point(40, 255);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 193);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPersonajes
            // 
            this.tabPersonajes.Controls.Add(this.dataGridView2);
            this.tabPersonajes.Location = new System.Drawing.Point(4, 22);
            this.tabPersonajes.Name = "tabPersonajes";
            this.tabPersonajes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonajes.Size = new System.Drawing.Size(553, 163);
            this.tabPersonajes.TabIndex = 0;
            this.tabPersonajes.Text = "Personajes";
            this.tabPersonajes.UseVisualStyleBackColor = true;
            // 
            // tabEnemigos
            // 
            this.tabEnemigos.Controls.Add(this.dataGridView1);
            this.tabEnemigos.Location = new System.Drawing.Point(4, 22);
            this.tabEnemigos.Name = "tabEnemigos";
            this.tabEnemigos.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnemigos.Size = new System.Drawing.Size(553, 167);
            this.tabEnemigos.TabIndex = 1;
            this.tabEnemigos.Text = "Enemigos";
            this.tabEnemigos.UseVisualStyleBackColor = true;
            // 
            // tabObjetos
            // 
            this.tabObjetos.Controls.Add(this.dataGridView3);
            this.tabObjetos.Location = new System.Drawing.Point(4, 22);
            this.tabObjetos.Name = "tabObjetos";
            this.tabObjetos.Size = new System.Drawing.Size(553, 167);
            this.tabObjetos.TabIndex = 2;
            this.tabObjetos.Text = "Objetos";
            this.tabObjetos.UseVisualStyleBackColor = true;
            // 
            // tabMapas
            // 
            this.tabMapas.Controls.Add(this.dataGridView4);
            this.tabMapas.Location = new System.Drawing.Point(4, 22);
            this.tabMapas.Name = "tabMapas";
            this.tabMapas.Size = new System.Drawing.Size(553, 167);
            this.tabMapas.TabIndex = 3;
            this.tabMapas.Text = "Mapas";
            this.tabMapas.UseVisualStyleBackColor = true;
            // 
            // tabMisiones
            // 
            this.tabMisiones.Controls.Add(this.dataGridView5);
            this.tabMisiones.Location = new System.Drawing.Point(4, 22);
            this.tabMisiones.Name = "tabMisiones";
            this.tabMisiones.Size = new System.Drawing.Size(553, 167);
            this.tabMisiones.TabIndex = 4;
            this.tabMisiones.Text = "Misiones";
            this.tabMisiones.UseVisualStyleBackColor = true;
            // 
            // tabLocalizaciones
            // 
            this.tabLocalizaciones.Controls.Add(this.dataGridView6);
            this.tabLocalizaciones.Location = new System.Drawing.Point(4, 22);
            this.tabLocalizaciones.Name = "tabLocalizaciones";
            this.tabLocalizaciones.Size = new System.Drawing.Size(553, 163);
            this.tabLocalizaciones.TabIndex = 5;
            this.tabLocalizaciones.Text = "Localizaciones";
            this.tabLocalizaciones.UseVisualStyleBackColor = true;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.dataGridView7);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(553, 167);
            this.tabUsuarios.TabIndex = 6;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(553, 163);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(550, 164);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(553, 163);
            this.dataGridView4.TabIndex = 0;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(553, 163);
            this.dataGridView5.TabIndex = 0;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(0, 0);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(553, 163);
            this.dataGridView6.TabIndex = 0;
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(0, 0);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(553, 163);
            this.dataGridView7.TabIndex = 0;
            // 
            // frmBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 453);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmBuscador";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPersonajes.ResumeLayout(false);
            this.tabEnemigos.ResumeLayout(false);
            this.tabObjetos.ResumeLayout(false);
            this.tabMapas.ResumeLayout(false);
            this.tabMisiones.ResumeLayout(false);
            this.tabLocalizaciones.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEnemigos;
        private System.Windows.Forms.TabPage tabPersonajes;
        private System.Windows.Forms.TabPage tabObjetos;
        private System.Windows.Forms.TabPage tabMapas;
        private System.Windows.Forms.TabPage tabMisiones;
        private System.Windows.Forms.TabPage tabLocalizaciones;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView7;
    }
}

