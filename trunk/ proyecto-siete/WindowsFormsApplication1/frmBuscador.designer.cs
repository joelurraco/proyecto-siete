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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Personajes");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Enemigos");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Armas");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Objetos", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Mapas");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Misiones");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Localizaciones");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Usuarios");
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbObjetos = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Criterios:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(90, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Todos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(460, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Busqueda avanzada";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cbObjetos
            // 
            this.cbObjetos.FormattingEnabled = true;
            this.cbObjetos.Items.AddRange(new object[] {
            "Armas",
            "Armaduras",
            "Comida"});
            this.cbObjetos.Location = new System.Drawing.Point(460, 124);
            this.cbObjetos.Name = "cbObjetos";
            this.cbObjetos.Size = new System.Drawing.Size(121, 21);
            this.cbObjetos.TabIndex = 6;
            this.cbObjetos.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Palabra clave:";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(25, 124);
            this.treeView1.Name = "treeView1";
            treeNode1.Checked = true;
            treeNode1.Name = "Nodo0";
            treeNode1.Text = "Personajes";
            treeNode2.Name = "Nodo1";
            treeNode2.Text = "Enemigos";
            treeNode3.Name = "Nodo7";
            treeNode3.Text = "Armas";
            treeNode4.Checked = true;
            treeNode4.Name = "Nodo2";
            treeNode4.Text = "Objetos";
            treeNode5.Name = "Nodo3";
            treeNode5.Text = "Mapas";
            treeNode6.Name = "Nodo4";
            treeNode6.Text = "Misiones";
            treeNode7.Name = "Nodo5";
            treeNode7.Text = "Localizaciones";
            treeNode8.Name = "Nodo6";
            treeNode8.Text = "Usuarios";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(121, 126);
            this.treeView1.TabIndex = 9;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // frmBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 453);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbObjetos);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmBuscador";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox cbObjetos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
    }
}

