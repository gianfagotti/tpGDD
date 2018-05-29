using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmCliente
{
    public partial class FrmAltaCliente : Form
    {
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void txtMail_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AbmRol.frmMenuEmpleado frmMenuEmpleado = new AbmRol.frmMenuEmpleado();
            this.Hide();
            frmMenuEmpleado.ShowDialog();
        }

        private void txtPaisOrigen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPaisOrigen_Click(object sender, EventArgs e)
        {

        }
    }
}
