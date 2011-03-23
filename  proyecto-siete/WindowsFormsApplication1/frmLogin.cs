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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // realizar la conexion de con la base de datos
            if (tbNombreAdministrador.Text == "admin" && tbContraseña.Text == "admin")
            {
                frmMenu frmMenu = new frmMenu(this);
                //this.Hide();
                //frmMenu.ShowDialog();
                //frmMenu.WindowState = FormWindowState.Maximized;
            }
            else {
                lbError.Visible = true;
            }
        }
    }
}
