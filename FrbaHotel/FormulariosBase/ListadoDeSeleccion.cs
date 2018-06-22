using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.FormulariosBase
{
    public partial class ListadoDeSeleccion : Form
    {
        Form abm;

        public ListadoDeSeleccion(Form abmPadre, string tabla)
        {
            InitializeComponent();
            this.abm = abmPadre;
            txtTabla.Text = tabla;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            abm.Show();
        }

        private void limpiarCampos() {
            txtFiltro1.Text = string.Empty;
            txtFiltro2.Text = string.Empty;
            txtFiltro1.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
