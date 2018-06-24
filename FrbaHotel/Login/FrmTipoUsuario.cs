using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class FrmTipoUsuario : Form
    {
        public static Conector2 BD = new Conector2();
        public FrmTipoUsuario()
        {
            InitializeComponent();
            BD.conectar();
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
                    FrmLogin frmLogin = new FrmLogin(this);
                    this.Hide();
                    frmLogin.Show();
                }
            }
            else 
            MessageBox.Show("Debe Seleccionar algún tipo de usuario","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void FrmTipoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
