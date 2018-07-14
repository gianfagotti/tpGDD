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

namespace FrbaHotel.AbmHotel
{
    public partial class FrmBajaHotel : Form
    {
        AbmRol.frmMenuEmpleado frmMenuEmpleado;
        private DateTime fechaInicioBaja;
        private DateTime fechaFinBaja;
        private String motivoBaja, fechaInicioBajaPosta, fechaFinBajaPosta;
        private Decimal codigoHotelIngresado = Login.FrmSeleccionarHotel.codigoHotel;
        private DataTable reservasQueContienenALaFechaBajaHotel, reservasQueContienenALaFechaAltaHotel;
        private SqlDataReader resultado;

        public FrmBajaHotel(AbmRol.frmMenuEmpleado frmMenuEmpleadoRecibido)
        {
            frmMenuEmpleado = frmMenuEmpleadoRecibido;
            InitializeComponent();
            dtpFechaFinBajaHotel.CustomFormat = "yyyy-MM-dd";
            dtpFechaInicioBajaHotel.CustomFormat = "yyyy-MM-dd";
            dtpFechaInicioBajaHotel.Value = Login.FrmTipoUsuario.fechaApp;                      //Se cargan los date time picker con la fecha del sistema cargada en la app config.
            dtpFechaFinBajaHotel.Value = Login.FrmTipoUsuario.fechaApp;
        }

        private void btnVolverHotel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.Show();
        }

        private void btnDarDeBajaHotel_Click(object sender, EventArgs e)
        {
            if (dtpFechaInicioBajaHotel.Value > dtpFechaFinBajaHotel.Value)
            {
                MessageBox.Show("No es posible elegir una fecha de comienzo de baja posterior a la de finalización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);             //Se valida que no se elija una fecha de inicio baja posterior a la de fin baja.
                return;
            }
            fechaInicioBaja = this.dtpFechaInicioBajaHotel.Value;
            fechaInicioBajaPosta = fechaInicioBaja.ToString("yyyy-MM-dd");
            reservasQueContienenALaFechaBajaHotel = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT * FROM FAGD.Reserva WHERE '" + fechaInicioBajaPosta + "' >= reserva_fechaInicio AND '" + fechaInicioBajaPosta + "' <= reserva_fechaFin AND reserva_codigoHotel = " + codigoHotelIngresado + " AND ((reserva_estado = 1) OR (reserva_estado = 2) OR (reserva_estado = 6))");
            if (reservasQueContienenALaFechaBajaHotel.Rows.Count >= 1)
            {
                MessageBox.Show("La fecha de inicio de baja no es válida. Elija una fecha donde no hayan reservas efectuadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);       //Se valida que la fecha elegida para iniciar la baja de un hotel no coincida con el intervalo de fechas de una reserva.
                return;
            }
            fechaFinBaja = this.dtpFechaFinBajaHotel.Value;
            fechaFinBajaPosta = fechaFinBaja.ToString("yyyy-MM-dd");
            reservasQueContienenALaFechaAltaHotel = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT * FROM FAGD.Reserva WHERE '" + fechaFinBajaPosta + "' >= reserva_fechaInicio AND '" + fechaFinBajaPosta + "' <= reserva_fechaFin AND reserva_codigoHotel = " + codigoHotelIngresado + " AND ((reserva_estado = 1) OR (reserva_estado = 2) OR (reserva_estado = 6))");
            if (reservasQueContienenALaFechaAltaHotel.Rows.Count >= 1)                                                                                                                      //Se valida que la fecha elegida para finalizar la baja de un hotel no coincida con el intervalo de fechas de una reserva.
            {
                MessageBox.Show("La fecha de finalización de baja no es válida. Elija una fecha donde no hayan reservas efectuadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            motivoBaja = this.txtMotivoBajaHotel.Text;
            resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("EXEC FAGD.darDeBajaHotel '" + fechaInicioBajaPosta + "', '" + fechaFinBajaPosta + "', '" + motivoBaja + "' , " + codigoHotelIngresado);       //Se da de baja el hotel, y se le notifica al usuario que se pudo hacer.
            resultado.Close();
            MessageBox.Show("Hotel dado de baja satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            frmMenuEmpleado.Show();          
        }
    }
}
