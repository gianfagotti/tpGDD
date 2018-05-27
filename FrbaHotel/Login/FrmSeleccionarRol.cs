using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class FrmSeleccionarRol : Form
    {
        public FrmSeleccionarRol()
        {
            InitializeComponent();
        }

        private void cmbRolesRegistrados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSeleccionarRol_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverATipoUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTipoUsuario frmTipoUsuario = new FrmTipoUsuario();
            frmTipoUsuario.ShowDialog();
        }

        private void btnAceptarRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmRol.frmMenuEmpleado frmMenuEmpleado = new AbmRol.frmMenuEmpleado();
            frmMenuEmpleado.ShowDialog();
        }
    }
}
