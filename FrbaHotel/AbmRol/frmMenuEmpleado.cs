using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class frmMenuEmpleado : Form
    {
        public frmMenuEmpleado()
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

        private void btnAltaRol_Click(object sender, EventArgs e)
        {
            AbmRol.AltaRol frmAltaRol = new AbmRol.AltaRol();
            this.Hide();
            frmAltaRol.ShowDialog();
        }

        private void btnModificarRol_Click(object sender, EventArgs e)
        {
            AbmRol.ModificarRol frmModificarRol = new AbmRol.ModificarRol();
            this.Hide();
            frmModificarRol.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login.FrmTipoUsuario frmTipoUsuario = new Login.FrmTipoUsuario();
            this.Hide();
            frmTipoUsuario.ShowDialog();
        }

        private void butAltaCliente_Click(object sender, EventArgs e)
        {
            AbmCliente.FrmAltaCliente frmAltaCliente = new AbmCliente.FrmAltaCliente();
            this.Hide();
            frmAltaCliente.ShowDialog();
        }

        private void butCrearHabitacion_Click(object sender, EventArgs e)
        {
            AbmHabitacion.FrmCrearHabitacion frmCrearHabitacion = new AbmHabitacion.FrmCrearHabitacion();
            this.Hide();
            frmCrearHabitacion.ShowDialog();
        }

        private void butCrearRegimen_Click(object sender, EventArgs e)
        {
            AbmRegimen.FrmCrearRegimen frmCrearRegimen = new AbmRegimen.FrmCrearRegimen();
            this.Hide();
            frmCrearRegimen.ShowDialog();
        }

        private void btnListadoEst_Click(object sender, EventArgs e)
        {
            ListadoEstadistico.ListadoEstadistico frmListadoEst = new ListadoEstadistico.ListadoEstadistico();
            this.Hide();
            frmListadoEst.ShowDialog();
        }

        private void btnRegistrarEstadiabtnRegistrarEstadia_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarEstadia.FrmRegistrarEstadia frmRegistrarEst = new RegistrarEstadia.FrmRegistrarEstadia();
            frmRegistrarEst.ShowDialog();
        }

        private void btnRegistrarConsumible_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarConsumible.FrmSeleccionarEstadia frmSeleccionarEstadia = new RegistrarConsumible.FrmSeleccionarEstadia();
            frmSeleccionarEstadia.ShowDialog();
        }
    }
}
