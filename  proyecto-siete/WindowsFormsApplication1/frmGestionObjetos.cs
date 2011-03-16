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
	public partial class frmGestionObjetos: Form
	{
		public frmGestionObjetos()
		{
			InitializeComponent();
		}


        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea borrar el objeto X", "Confirmar borrar", MessageBoxButtons.YesNo)==DialogResult.Yes) { 
                MessageBox.Show("Objeto borrado", "", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void button6_Click(object sender, EventArgs e)
        {

        }
 
	}
}
