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
            dtpFechaFinBajaHotel.MinDate = new DateTime(2000,1,22);
            dtpFechaInicioBajaHotel.MinDate = new DateTime(2000,1,22);

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
                MessageBox.Show("No es posible elegir una fecha de comienzo de baja posterior a la de finalización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (reservasQueContienenALaFechaBajaHotel.Rows.Count >= 1)
            {
                MessageBox.Show("La fecha de inicio de baja no es válida. Elija una fecha donde no hayan reservas efectuadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fechaInicioBaja = this.dtpFechaInicioBajaHotel.Value;
            fechaInicioBajaPosta = fechaInicioBaja.ToString("yyyy-MM-dd");
            reservasQueContienenALaFechaBajaHotel = Login.FrmTipoUsuario.BD.consulta("SELECT * FROM FAGD.Reserva WHERE '" + fechaInicioBajaPosta + "' >= reserva_fechaInicio AND '" + fechaInicioBajaPosta + "' <= reserva_fechaFin AND reserva_codigoHotel = " + codigoHotelIngresado + " AND ((reserva_estado = 1) OR (reserva_estado = 2) OR (reserva_estado = 6))");
            Console.WriteLine(reservasQueContienenALaFechaBajaHotel.Rows.Count);
            if (reservasQueContienenALaFechaBajaHotel.Rows.Count >= 1)
            {
                MessageBox.Show("La fecha de inicio de baja no es válida. Elija una fecha donde no hayan reservas efectuadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fechaFinBaja = this.dtpFechaFinBajaHotel.Value;
            fechaFinBajaPosta = fechaFinBaja.ToString("yyyy-MM-dd");
            reservasQueContienenALaFechaAltaHotel = Login.FrmTipoUsuario.BD.consulta("SELECT * FROM FAGD.Reserva WHERE '" + fechaFinBajaPosta + "' >= reserva_fechaInicio AND '" + fechaFinBajaPosta + "' <= reserva_fechaFin AND reserva_codigoHotel = " + codigoHotelIngresado + " AND ((reserva_estado = 1) OR (reserva_estado = 2) OR (reserva_estado = 6))");
            Console.WriteLine(reservasQueContienenALaFechaAltaHotel.Rows.Count);
            if (reservasQueContienenALaFechaAltaHotel.Rows.Count >= 1)
            {
                MessageBox.Show("La fecha de finalización de baja no es válida. Elija una fecha donde no hayan reservas efectuadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                MessageBox.Show("nice job");
                /*
                motivoBaja = this.txtMotivoBajaHotel.Text;
                resultado = Login.FrmTipoUsuario.BD.comando("EXEC FAGD.darDeBajaHotel '" + fechaInicioBajaPosta + "', '" + fechaFinBajaPosta + "', '" + motivoBaja + "' , " + codigoHotelIngresado);
                MessageBox.Show("Hotel creado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                frmMenuEmpleado.Show();*/
            
        }
    }
}
