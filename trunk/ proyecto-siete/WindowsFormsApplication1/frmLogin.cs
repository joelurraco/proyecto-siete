using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using ProyectoSIETE.Properties;
using CADProyectoSIETE;
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
            /*SqlCommand com = new SqlCommand("select * from Administrador",conexion);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
            tbNombreAdministrador.Text=dr["nombreAdministrador"].ToString();*/


        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // comprobar que no tenga caracteres extraños
                string regExp = @"^\w*$";
                if (!Regex.Match(tbContraseña.Text, regExp).Success && !Regex.Match(tbNombreAdministrador.Text, regExp).Success)
                {
                    MessageBox.Show("Error, caracteres no validos, solo se admiten letras, numeros y _", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if (tbContraseña.Text != "" && tbNombreAdministrador.Text != "")
                    {
                        SqlCommand comando = new SqlCommand("select nombreAdministrador from Administrador where nombreAdministrador='" + tbNombreAdministrador.Text + "' and claveAdministrador='" + tbContraseña.Text + "'", conexion);
                        SqlDataReader dr = comando.ExecuteReader();
                        //dr.Read();
                        if (dr.HasRows)
                        {
                            frmMenu frmMenu = new frmMenu(this);
                        }
                        else
                        {
                            lbError.Text = "Error. Usuario o contraseña incorrectos";
                            lbError.Visible = true;
                        }
                        dr.Close();
                    }
                    else
                    {

                        lbError.Text = "Error. Introduce un usuario y contraseña.";
                        lbError.Visible = true;
                    }
                }
            }
            catch { 
            
            
            
            }
        }


    }
}
