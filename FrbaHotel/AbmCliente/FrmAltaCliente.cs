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
        AbmRol.frmMenuEmpleado frmMenuEmpleado;

        public FrmAltaCliente(AbmRol.frmMenuEmpleado form)
        {
            InitializeComponent();
            frmMenuEmpleado = form;
        }

        private void txtMail_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.Show();
        }

        private void txtPaisOrigen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPaisOrigen_Click(object sender, EventArgs e)
        {

        }
    }
}
