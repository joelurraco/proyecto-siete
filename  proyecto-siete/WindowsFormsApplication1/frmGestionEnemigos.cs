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
    public partial class frmGestionEnemigos : Form
    {
        public frmGestionEnemigos()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void nuevoEnemigoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nomEnemigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void formEnemigos_Load(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = ofdImagenEnemigo.ShowDialog();
            if (resultado == DialogResult.OK)
            {

            }

        }

    }
}
