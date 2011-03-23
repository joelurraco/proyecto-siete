using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using ProyectoSIETE.Properties;
using System.Configuration;

namespace ProyectoSIETE
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        public SqlConnection conexion;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //string aux = @"Data Source=.\SQLEXPRESS;Integrated Security=True;User Instance=True";
            string aux= Settings.Default.BDProyecto7ConnectionString;
            conexion=new SqlConnection(aux);
            conexion.Open();
            SqlCommand com = new SqlCommand("select * from Administrador",conexion);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
            tbNombreAdministrador.Text=dr["nombreAdministrador"].ToString();

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
