using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.MenuesUsuarios
{
    public partial class frmMenuCliente : Form
    {
        public frmMenuCliente()
        {
            InitializeComponent();
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {

            GenerarModificacionReserva.GenerarReserva frmGenerarReserva = new GenerarModificacionReserva.GenerarReserva();
            this.Hide();
            frmGenerarReserva.ShowDialog();

        }

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {
            GenerarModificacionReserva.ModificarReserva frmModificarReserva = new GenerarModificacionReserva.ModificarReserva();
            this.Hide();
            frmModificarReserva.ShowDialog();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            CancelarReserva.CancelarReserva frmCancelarReserva = new CancelarReserva.CancelarReserva();
            this.Hide();
            frmCancelarReserva.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login.FrmTipoUsuario frmTipoUsuario = new Login.FrmTipoUsuario();
            this.Hide();
            frmTipoUsuario.ShowDialog();
        }
    }
}
