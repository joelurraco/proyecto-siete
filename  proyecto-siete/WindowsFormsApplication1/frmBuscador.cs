﻿using System;
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
    public partial class frmBuscador : Form
    {
        public frmBuscador()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public SqlConnection conexion;
        private void frmBuscador_Load(object sender, EventArgs e)
        {
            cbCriterio.SelectedIndex=0;
            string aux = Settings.Default.BDProyecto7ConnectionString;
            conexion = new SqlConnection(aux);
            conexion.Open();
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
                if(nodo.Nodes.Count>0){
                    for (int i = 0; i<nodo.Nodes.Count; i++ ){
                        RecorrerCheck(nodo.Nodes[i]);
                    }
                }
                nodo = nodo.NextNode;
            }
        }
    }
}
