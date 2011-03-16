using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmModificarObjetos : Form
    {
        public frmModificarObjetos()
        {
            InitializeComponent();
        }

        private void frmModificarObjetos_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
