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
    public partial class FrmTipoUsuario : Form
    {
        public FrmTipoUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptarTipoUsuario_Click(object sender, EventArgs e)
        {
            if (cmbTiposDeUsuario.SelectedItem != null)
            {
                if (cmbTiposDeUsuario.SelectedItem.ToString() == "Cliente")
                {
                    AbmRol.frmMenuCliente frmMenuCliente = new AbmRol.frmMenuCliente();
                    this.Hide();
                    frmMenuCliente.Show();
                }
                else
                {
                    FrmLogin frmLogin = new FrmLogin();
                    this.Hide();
                    frmLogin.Show();
                }
            }
            else 
            MessageBox.Show("Debe Seleccionar algún tipo de usuario","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbTiposDeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
