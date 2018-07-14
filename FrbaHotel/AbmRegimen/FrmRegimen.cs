using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.AbmRegimen
{
    public partial class FrmRegimen : Form
    {
        Form abm;

        public FrmRegimen(Form abmPadre, string accion)
        {
            InitializeComponent();
            abm = abmPadre;
            this.Text = accion + " Regimen";
        }

        private void FrmRegimen_Load(object sender, EventArgs e)
        {

        }

        private void limpiarCampos()
        {
            txtPrecio.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            chkEstado.Checked = false;
            txtPrecio.Focus();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            abm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
