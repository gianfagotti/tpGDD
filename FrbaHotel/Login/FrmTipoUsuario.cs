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
            if (cmbTiposDeUsuario.SelectedItem.ToString() == "Cliente"){
            GenerarModificacionReserva.GenerarReserva frmGenerarReserva = new GenerarModificacionReserva.GenerarReserva();
            this.Hide();
            frmGenerarReserva.ShowDialog(); 
           }
           else{
               FrmLogin frmLogin = new FrmLogin();
               this.Hide();
               frmLogin.ShowDialog();
            }
        }

        private void cmbTiposDeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
