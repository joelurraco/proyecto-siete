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
    public partial class frmGestionTaberna : Form
    {
        public frmGestionTaberna()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //int idObjeto = 0;
            //idObjeto = dgvItems.CurrentRow.Cells(0).value; consultar la fila seleccionada
            frmNuevoObjetoTaberna frmNuevo = new frmNuevoObjetoTaberna();
            frmNuevo.Show();
            //Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea borrar el objeto X", "Confirmar borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Objeto borrado", "", MessageBoxButtons.OK);
            }
        }
    }
}
