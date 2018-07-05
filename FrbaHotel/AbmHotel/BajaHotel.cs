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
        }

        private void btnVolverHotel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.Show();
        }

        private void btnDarDeBajaHotel_Click(object sender, EventArgs e)
        {
            fechaInicioBaja = Convert.ToDateTime(this.dtpFechaInicioBajaHotel.Value);
            fechaInicioBajaPosta = fechaInicioBaja.Date.ToString("yyyyMMdd HH:mm:ss");
            reservasQueContienenALaFechaBajaHotel = Login.FrmTipoUsuario.BD.consulta("SELECT * FROM FAGD.Reserva WHERE '" + fechaInicioBajaPosta + "' >= reserva_fechaInicio AND '" + fechaInicioBajaPosta + "' <= reserva_fechaFin AND reserva_codigoHotel = " + codigoHotelIngresado + " AND ((reserva_estado = 1) OR (reserva_estado = 2) OR (reserva_estado = 6))");
            if (reservasQueContienenALaFechaBajaHotel.Rows.Count >= 1)
            {
                MessageBox.Show("La fecha de inicio de baja no es válida. Elija una fecha donde no hayan reservas efectuadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            fechaFinBaja = Convert.ToDateTime(this.dtpFechaFinBajaHotel.Value);
            fechaFinBajaPosta = fechaInicioBaja.Date.ToString("yyyyMMdd HH:mm:ss");
            reservasQueContienenALaFechaAltaHotel = Login.FrmTipoUsuario.BD.consulta("SELECT * FROM FAGD.Reserva WHERE '" + fechaFinBajaPosta + "' >= reserva_fechaInicio AND '" + fechaFinBajaPosta + "' <= reserva_fechaFin AND reserva_codigoHotel = " + codigoHotelIngresado + " AND ((reserva_estado = 1) OR (reserva_estado = 2) OR (reserva_estado = 6))");
            if (reservasQueContienenALaFechaAltaHotel.Rows.Count >= 1)
            {
                MessageBox.Show("La fecha de finalización de baja no es válida. Elija una fecha donde no hayan reservas efectuadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                motivoBaja = this.txtMotivoBajaHotel.Text;
                resultado = Login.FrmTipoUsuario.BD.comando("EXEC FAGD.darDeBajaHotel '" + fechaInicioBajaPosta + "', '" + fechaFinBajaPosta + "', '" + motivoBaja + "' , " + codigoHotelIngresado);
                MessageBox.Show("Hotel creado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                frmMenuEmpleado.Show();
            }
        }
    }
}
