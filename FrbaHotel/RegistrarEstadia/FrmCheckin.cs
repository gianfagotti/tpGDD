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

namespace FrbaHotel.RegistrarEstadia
{
    public partial class FrmCheckin : Form
    {

        SqlDataReader resultadoQuery;
        decimal estadoReservaCorrecto;
        decimal estadoReservaModificado;
        decimal codigoEstadiaQueSeAcabaDeCrear = 0;
        AbmRol.frmMenuEmpleado menuAVolver;
        FrmMenuRegEst menuAnterior;

        public FrmCheckin(FrmMenuRegEst menuReg, AbmRol.frmMenuEmpleado menuppal)
        {
            InitializeComponent();
            txtReserv.Clear();
            txtReserv.Focus();
            menuAVolver = menuppal;
            menuAnterior = menuReg;

            estadoReservaCorrecto = 0;
            resultadoQuery = Login.FrmTipoUsuario.BD.comando("SELECT estado_codigo FROM FAGD.Estado WHERE estado_descripcion = 'RESERVA CORRECTA'");
            resultadoQuery.Read();
            estadoReservaCorrecto = resultadoQuery.GetDecimal(0);
            resultadoQuery.Close();
            estadoReservaModificado = 0;
            resultadoQuery = Login.FrmTipoUsuario.BD.comando("SELECT estado_codigo FROM FAGD.Estado WHERE estado_descripcion = 'RESERVA MODIFICADA'");
            resultadoQuery.Read();
            estadoReservaModificado = resultadoQuery.GetDecimal(0);
            resultadoQuery.Close();
        

        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            
             if (string.IsNullOrEmpty(txtReserv.Text))
            {
                MessageBox.Show("Debe ingresar un numero de reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            resultadoQuery = Login.FrmTipoUsuario.BD.comando("SELECT reserva_codigo, reserva_estado, reserva_fechaInicio, reserva_fechaFin FROM FAGD.Reserva WHERE reserva_codigo = " + txtReserv.Text);
            if (resultadoQuery.Read() == true)
            {
                decimal estadoDeReserva = resultadoQuery.GetDecimal(1);
                DateTime fechaIni = resultadoQuery.GetDateTime(2);
                resultadoQuery.Close();
                if (fechaIni.Date < Login.FrmTipoUsuario.fechaApp)
                {
                    MessageBox.Show("No se puede hacer el check-in, reserva vencida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (fechaIni.Date > Login.FrmTipoUsuario.fechaApp)
                {
                    MessageBox.Show("No se puede hacer el check-in, fecha temprana.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (estadoDeReserva != estadoReservaCorrecto && estadoDeReserva != estadoReservaModificado)
                {
                    MessageBox.Show("La reserva ingresada no tiene un estado correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } 

                resultadoQuery = Login.FrmTipoUsuario.BD.comando("SELECT hotel.hotel_codigo FROM FAGD.Habitacion ha, FAGD.Hotel hotel, FAGD.ReservaXHabitacion resxh  WHERE resxh.habitacion_codigo = ha.habitacion_codigo AND ha.habitacion_codigoHotel = hotel.hotel_codigo AND resxh.reserva_codigo = " + txtReserv.Text);
                decimal hotelDeLaQuery = 0;
                if (resultadoQuery.Read())
                {
                    hotelDeLaQuery = resultadoQuery.GetDecimal(0);
                    resultadoQuery.Close();
                }
                else{
                    resultadoQuery.Close();
                    MessageBox.Show("La reserva no tiene asignadas habitaciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; }

                if (hotelDeLaQuery.ToString() != Login.FrmSeleccionarHotel.codigoHotel.ToString())
                {
                    MessageBox.Show("Solo pueden hacer check-in los empleados del hotel donde se hizo la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string confirmacion2 = "EXEC FAGD.CheckinParaEstadia " + txtReserv.Text + ",'" + Login.FrmLoginUsuario.username + "','" + Login.FrmTipoUsuario.fechaAppConvertida + "'";
                resultadoQuery = Login.FrmTipoUsuario.BD.comando(confirmacion2);
                resultadoQuery.Read();
                codigoEstadiaQueSeAcabaDeCrear = resultadoQuery.GetDecimal(0);
                resultadoQuery.Close();
                if (codigoEstadiaQueSeAcabaDeCrear != 0)
                {
                    MessageBox.Show("El check-in ha concluido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     string fact = "EXEC FAGD.RegistrarDatosInicialesFactura " + codigoEstadiaQueSeAcabaDeCrear.ToString() + ",'" + Login.FrmTipoUsuario.fechaAppConvertida + "'";
                    resultadoQuery = Login.FrmTipoUsuario.BD.comando(fact);
                    resultadoQuery.Read();
                    decimal factura = resultadoQuery.GetDecimal(0);
                    if (factura == 0)
                    {
                        resultadoQuery.Close();
                        MessageBox.Show("Error al crear factura, ya esta generada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                   
                    }
                    resultadoQuery.Close();
                    FrmRegistrarHuesped regHue = new FrmRegistrarHuesped(txtReserv.Text, codigoEstadiaQueSeAcabaDeCrear.ToString(),menuAVolver);
                    regHue.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la operación, la estadia ya esta registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }     
            }
            else
            {
                resultadoQuery.Close();
                MessageBox.Show("Número de reserva incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
  
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void FrmCheckin_Load(object sender, EventArgs e)
        {

        }
    }
}


            
        