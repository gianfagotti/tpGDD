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

namespace FrbaHotel.AbmRol
{
    public partial class frmMenuEmpleado : Form
    {
        private SqlDataReader resultado;
        public frmMenuEmpleado(decimal rol)
        {
            InitializeComponent();
            habilitarGroupsBoxs(rol);
        }

        private void habilitarGroupsBoxs(decimal codigoRol)
        {
            resultado = Login.FrmTipoUsuario.BD.comando("SELECT DISTINCT F.funcionalidad_detalle FROM FAGD.RolXFuncionalidad R, FAGD.Funcionalidad F where R.funcionalidad_codigo = F.funcionalidad_codigo and  R.rol_codigo =" + codigoRol.ToString() + ";");
            while (resultado.Read() == true)
            {
                switch (resultado.GetSqlString(0).ToString())
                {
                    case "ABM_Clientes":
                        grbHuespedes.Enabled = true;
                        break;
                    case "ABM_Consumibles":
                        grbConsumibles.Enabled = true;
                        break;
                    case "ABM_Estadias":
                        grbEstadias.Enabled = true;
                        break;
                    case "ABM_Habitaciones":
                        grbHabitaciones.Enabled = true;
                        break;
                    case "ABM_Hoteles":
                        grbHoteles.Enabled = true;
                        break;
                    case "ABM_Regimenes":
                        grbRegimenes.Enabled = true;
                        break;
                    case "ABM_Reservas":
                        grbReservas.Enabled = true;
                        break;
                    case "ABM_Roles":
                        grbRoles.Enabled = true;
                        break;
                    case "ABM_Usuarios":
                        grbUsuarios.Enabled = true;
                        break;
                    case "Estadisticas":
                        grbListado.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
            resultado.Close();
        }


        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            GenerarModificacionReserva.GenerarReserva frmGenerarReserva = new GenerarModificacionReserva.GenerarReserva(this);
            this.Hide();
            frmGenerarReserva.Show();
        }

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {
            GenerarModificacionReserva.listadoModReserva frmModificarReserva = new GenerarModificacionReserva.listadoModReserva(this);
            this.Hide();
            frmModificarReserva.Show();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            CancelarReserva.CancelarReserva frmCancelarReserva = new CancelarReserva.CancelarReserva(this);
            this.Hide();
            frmCancelarReserva.Show();
        }

        private void btnAltaRol_Click(object sender, EventArgs e)
        {
            AbmRol.AltaRol frmAltaRol = new AbmRol.AltaRol(this);
            this.Hide();
            frmAltaRol.Show();
        }

        private void btnModificarRol_Click(object sender, EventArgs e)
        {
            AbmRol.frmSeleccionarRol frmSeleccionarRol = new AbmRol.frmSeleccionarRol(this);
            this.Hide();
            frmSeleccionarRol.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login.FrmTipoUsuario frmTipoUsuario = new Login.FrmTipoUsuario();
            this.Close();
            frmTipoUsuario.Show();
        }

        private void butAltaCliente_Click(object sender, EventArgs e)
        {
            AbmCliente.FrmAltaCliente frmAltaCliente = new AbmCliente.FrmAltaCliente(this);
            this.Hide();
            frmAltaCliente.Show();
        }

        private void butCrearHabitacion_Click(object sender, EventArgs e)
        {
            AbmHabitacion.FrmCrearHabitacion frmCrearHabitacion = new AbmHabitacion.FrmCrearHabitacion(this);
            this.Hide();
            frmCrearHabitacion.Show();
        }

        private void butCrearRegimen_Click(object sender, EventArgs e)
        {
            AbmRegimen.FrmRegimen frmCrearRegimen = new AbmRegimen.FrmRegimen(this, "Crear");
            this.Hide();
            frmCrearRegimen.Show();
        }

        private void btnListadoEst_Click(object sender, EventArgs e)
        {
            ListadoEstadistico.ListadoEstadistico frmListadoEst = new ListadoEstadistico.ListadoEstadistico(this);
            this.Hide();
            frmListadoEst.Show();
        }

        private void btnRegistrarEstadiabtnRegistrarEstadia_Click(object sender, EventArgs e)
        {
            RegistrarEstadia.FrmMenuRegEst2 menuRegEst = new RegistrarEstadia.FrmMenuRegEst2(this);
            this.Hide();
            menuRegEst.Show();
        }

        private void btnRegistrarConsumible_Click(object sender, EventArgs e)
        {
            RegistrarConsumible.FrmSeleccionEstadia frmAgregarConsu = new RegistrarConsumible.FrmSeleccionEstadia(this);
            this.Hide();            
            frmAgregarConsu.Show();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            AbmCliente.FrmListadoMod filtro = new AbmCliente.FrmListadoMod(this);
            this.Hide();
            filtro.Show();

        }

        private void butBajaCliente_Click(object sender, EventArgs e)
        {
            AbmCliente.FrmBajaCliente frm = new AbmCliente.FrmBajaCliente(this);
            this.Hide();
            frm.Show();
        }

        private void butModHab_Click(object sender, EventArgs e)
        {
            AbmHabitacion.FrmListadoMod frm = new AbmHabitacion.FrmListadoMod(this);
            this.Hide();
            frm.Show();
        }

        private void butBajaHab_Click(object sender, EventArgs e)
        {
            AbmHabitacion.FrmBajaHabitacion frm = new AbmHabitacion.FrmBajaHabitacion(this);
            this.Hide();
            frm.Show();
        }
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            AbmUsuario.AltaUsuario frm = new AbmUsuario.AltaUsuario(this);
            this.Hide();
            frm.Show();
        }

        private void btnRetocarUsuario_Click(object sender, EventArgs e)
        {
            AbmUsuario.SeleccionarUsuario frm = new AbmUsuario.SeleccionarUsuario(this);
            this.Hide();
            frm.Show();
        }

        private void btnNuevoHotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmHotel.FrmAltaHotel frmAltaHotel = new AbmHotel.FrmAltaHotel(this);
            frmAltaHotel.Show();
        }

        private void btnModificarHotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmHotel.FrmModificarHotel frmModificarHotel = new AbmHotel.FrmModificarHotel(this);
            frmModificarHotel.Show();
        }

        private void btnBajaHotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmHotel.FrmBajaHotel frmBajaHotel = new AbmHotel.FrmBajaHotel(this);
            frmBajaHotel.Show();
        }

        private void btnCambiarRol_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.FrmSeleccionarRol frmSeleccionarRol = new Login.FrmSeleccionarRol(Login.FrmSeleccionarHotel.codigoHotel, Login.FrmLoginUsuario.username);
            frmSeleccionarRol.Show();
        }

        private void btnCambiarHotel_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.FrmSeleccionarHotel frmSeleccionarHotel = new Login.FrmSeleccionarHotel(Login.FrmLoginUsuario.username);
            frmSeleccionarHotel.Show();
        }
    }
}
