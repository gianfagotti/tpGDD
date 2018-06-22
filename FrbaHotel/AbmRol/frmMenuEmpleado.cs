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
        string tipoEmpleado;
        public frmMenuEmpleado(string tipo)
        {
            InitializeComponent();
            tipoEmpleado = tipo;
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            if (tipoEmpleado.Equals("Recepcionista"))
            {
                GenerarModificacionReserva.GenerarReserva frmGenerarReserva = new GenerarModificacionReserva.GenerarReserva(this);
                this.Hide();
                frmGenerarReserva.Show();
            }else
                MessageBox.Show("La reserva solo puede ser generada por un recepcionista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {
            if (tipoEmpleado.Equals("Recepcionista"))
            {
                GenerarModificacionReserva.ModificarReserva frmModificarReserva = new GenerarModificacionReserva.ModificarReserva(this);
                this.Hide();
                frmModificarReserva.Show();
            }else
                MessageBox.Show("La reserva solo puede ser generada por un recepcionista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (tipoEmpleado.Equals("Recepcionista"))
            {
                CancelarReserva.CancelarReserva frmCancelarReserva = new CancelarReserva.CancelarReserva(this);
                this.Hide();
                frmCancelarReserva.Show();
            }else
                MessageBox.Show("La reserva solo puede ser generada por un recepcionista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAltaRol_Click(object sender, EventArgs e)
        {
            AbmRol.AltaRol frmAltaRol = new AbmRol.AltaRol(this);
            this.Hide();
            frmAltaRol.Show();
        }

        private void btnModificarRol_Click(object sender, EventArgs e)
        {
            AbmRol.ModificarRol frmModificarRol = new AbmRol.ModificarRol(this);
            this.Hide();
            frmModificarRol.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login.FrmTipoUsuario frmTipoUsuario = new Login.FrmTipoUsuario();
            this.Close();
            frmTipoUsuario.Show();
        }

        private void butAltaCliente_Click(object sender, EventArgs e)
        {
            if (tipoEmpleado.Equals("Recepcionista"))
            {
                AbmCliente.FrmAltaCliente frmAltaCliente = new AbmCliente.FrmAltaCliente(this);
                this.Hide();
                frmAltaCliente.Show();
            }else
                MessageBox.Show("La reserva solo puede ser generada por un recepcionista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void butCrearHabitacion_Click(object sender, EventArgs e)
        {
            if (tipoEmpleado.Equals("Administrador"))
            {
                AbmHabitacion.FrmCrearHabitacion frmCrearHabitacion = new AbmHabitacion.FrmCrearHabitacion(this);
                this.Hide();
                frmCrearHabitacion.Show();
            }else
                MessageBox.Show("La reserva solo puede ser generada por un administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void butCrearRegimen_Click(object sender, EventArgs e)
        {
            if (tipoEmpleado.Equals("Administrador"))
            {
                AbmRegimen.FrmCrearRegimen frmCrearRegimen = new AbmRegimen.FrmCrearRegimen(this);
                this.Hide();
                frmCrearRegimen.Show();
            }else
                MessageBox.Show("La reserva solo puede ser generada por un administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnListadoEst_Click(object sender, EventArgs e)
        {
            ListadoEstadistico.ListadoEstadistico frmListadoEst = new ListadoEstadistico.ListadoEstadistico(this);
            this.Hide();
            frmListadoEst.Show();
        }

        private void btnRegistrarEstadiabtnRegistrarEstadia_Click(object sender, EventArgs e)
        {
            if (tipoEmpleado.Equals("Recepcionista"))
            {
                RegistrarEstadia.FrmRegistrarEstadia frmRegistrarEst = new RegistrarEstadia.FrmRegistrarEstadia(this);
                this.Hide();
                frmRegistrarEst.Show();
            }else
                MessageBox.Show("La reserva solo puede ser generada por un recepcionista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegistrarConsumible_Click(object sender, EventArgs e)
        {
            RegistrarConsumible.FrmSeleccionarEstadia frmSeleccionarEstadia = new RegistrarConsumible.FrmSeleccionarEstadia(this);
            this.Hide();            
            frmSeleccionarEstadia.Show();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            AbmCliente.FrmListadoMod filtro = new AbmCliente.FrmListadoMod(this);
            this.Hide();
            filtro.Show();

        }
    }
}
