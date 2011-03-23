using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoSIETE
{
    public partial class frmBuscador : Form
    {
        public frmBuscador()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TreeNode actual=treeView1.TopNode;
            RecorrerCheck(actual);
        }

        private void RecorrerCheck(TreeNode nodo){
            while (nodo != null)
            {
                nodo.Checked = checkBox1.Checked;
                /*if(nodo!=null){
                    RecorrerCheck(nodo);
                }*/
                nodo = nodo.NextNode;
            }
        }
    }
}
