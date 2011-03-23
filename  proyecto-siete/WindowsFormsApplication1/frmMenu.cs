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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        public frmMenu(frmLogin login) {
            InitializeComponent();
            login.Hide();
            this.ShowDialog();
            login.Close();
        }
            // variables publicas para la creación de formularios
        frmGestionObjetos frmGestionObjetos = new frmGestionObjetos();
        frmGestionTaberna frmGestionTaberna = new frmGestionTaberna();
        frmGestionEnemigos frmGestionEnemigos = new frmGestionEnemigos();
        frmGestionMapas frmGestionMapas = new frmGestionMapas();
        frmGestionMisiones frmGestionMisiones = new frmGestionMisiones();
        frmBuscador frmBuscador = new frmBuscador();
        frmGestionPersonajes frmGestionPersonajes = new frmGestionPersonajes();
        frmGestionUsuarios frmGestionUsuarios = new frmGestionUsuarios();
        frmGestionLocalizaciones frmGestionLocalizaciones = new frmGestionLocalizaciones();

        private void frmMenu_Load(object sender, EventArgs e)
        {

        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (frmBuscador.Visible == false)
            {
                frmBuscador = new frmBuscador();
            }
            frmBuscador.MdiParent = this;
            frmBuscador.Show();
            frmBuscador.WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (frmGestionObjetos.Visible == false) { 
                frmGestionObjetos = new frmGestionObjetos();
            }
            frmGestionObjetos.MdiParent = this;
            frmGestionObjetos.Show();
            frmGestionObjetos.WindowState = FormWindowState.Maximized;
        }

        

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (frmGestionTaberna.Visible == false)
            {
                frmGestionTaberna = new frmGestionTaberna();
            }
            frmGestionTaberna.MdiParent = this;
            frmGestionTaberna.Show();
            frmGestionTaberna.WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (frmGestionEnemigos.Visible == false)
            {
                frmGestionEnemigos = new frmGestionEnemigos();
            }
            frmGestionEnemigos.MdiParent = this;
            frmGestionEnemigos.Show();
            frmGestionEnemigos.WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (frmGestionMisiones.Visible == false)
            {
                frmGestionMisiones = new frmGestionMisiones();
            }
            frmGestionMisiones.MdiParent = this;
            frmGestionMisiones.Show();
            frmGestionMisiones.WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (frmGestionMapas.Visible == false)
            {
                frmGestionMapas = new frmGestionMapas();
            }
            frmGestionMapas.MdiParent = this;
            frmGestionMapas.Show();
            frmGestionMapas.WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (frmGestionPersonajes.Visible == false)
            {
                frmGestionPersonajes = new frmGestionPersonajes();
            }
            frmGestionPersonajes.MdiParent = this;
            frmGestionPersonajes.Show();
            frmGestionPersonajes.WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (frmGestionUsuarios.Visible == false)
            {
                frmGestionUsuarios = new frmGestionUsuarios();
            }
            frmGestionUsuarios.MdiParent = this;
            frmGestionUsuarios.Show();
            frmGestionUsuarios.WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (frmGestionLocalizaciones.Visible == false)
            {
                frmGestionLocalizaciones = new frmGestionLocalizaciones();
            }
            frmGestionLocalizaciones.MdiParent = this;
            frmGestionLocalizaciones.Show();
            frmGestionLocalizaciones.WindowState = FormWindowState.Maximized;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
