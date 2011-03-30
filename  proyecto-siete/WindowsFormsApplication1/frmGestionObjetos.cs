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
using System.Configuration;

namespace ProyectoSIETE
{
	public partial class frmGestionObjetos: Form
	{
		public frmGestionObjetos()
		{
			InitializeComponent();
		}

        // conexion con la BD
        public SqlConnection conexion;

        // variable para saber si se esta en modo edicion o no
        private bool editarOn=true;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDProyecto7DataSet.Objeto' Puede moverla o quitarla según sea necesario.
            this.objetoTableAdapter.Fill(this.bDProyecto7DataSet.Objeto);
            this.StartPosition = FormStartPosition.CenterScreen;

            // conexion con la BD para los tipo de objetos
            string aux = Settings.Default.BDProyecto7ConnectionString;
            conexion = new SqlConnection(aux);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea borrar el objeto X", "Confirmar borrar", MessageBoxButtons.YesNo)==DialogResult.Yes) { 
                MessageBox.Show("Objeto borrado", "", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            // se comprueba si se edita o se inserta
            if (editarOn)
            {   // se edita


            }
            else { // se inserta
            
            
            }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // comprobar que no tenga caracteres extraños
            string regExp = @"^\w*$" ;
            if (!Regex.Match(tbBuscador.Text, regExp).Success)
            {
                MessageBox.Show("Error, caracteres no validos, solo se admiten letras, numeros y _", "Error", MessageBoxButtons.OK);
            }

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // cambia el modo del data grid a nuevo  
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            editarOn = false;
        }

        // cambia el modo del data grid a editar un elemento
        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarOn = true;
        }


 
	}
}
