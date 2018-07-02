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
        decimal resok;
        decimal resmodif;
        decimal estadia = 0;
        DateTime diaActual = DateTime.Today;

        public FrmCheckin()
        {
            InitializeComponent();
            txtReserv.Clear();
            txtReserv.Focus();
            
            resok = 0;
            resultadoQuery = Login.FrmTipoUsuario.BD.comando("SELECT estado_codigo FROM FAGD.Estado WHERE estado_descripcion = 'RESERVA CORRECTA'");
            resultadoQuery.Read();
            resok = resultadoQuery.GetDecimal(0);
            resultadoQuery.Close();
            resmodif = 0;
            resultadoQuery = Login.FrmTipoUsuario.BD.comando("SELECT estado_codigo FROM FAGD.Estado WHERE estado_descripcion = 'RESERVA MODIFICADA'");
            resultadoQuery.Read();
            resmodif = resultadoQuery.GetDecimal(0);
            resultadoQuery.Close();
        

        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            
             if (string.IsNullOrEmpty(txtReserv.Text))
            {
                MessageBox.Show("Debe ingresar un numero de reserva");
                return;
            }
            resultadoQuery = Login.FrmTipoUsuario.BD.comando("SELECT reserva_codigo, reserva_estado, reserva_fechaInicio, reserva_fechaFin FROM FAGD.Reserva WHERE reserva_codigo = " + txtReserv.Text);
            if (resultadoQuery.Read() == true)
            {
                decimal estadoDeReserva = resultadoQuery.GetDecimal(1);
                DateTime fechaIni = resultadoQuery.GetDateTime(2);

                if (fechaIni.Date < diaActual)
                {
                    MessageBox.Show("No se puede hacer el check-in, reserva vencida.");
                    return;
                }
                if (fechaIni.Date > diaActual)
                {
                    MessageBox.Show("No se puede hacer el check-in, fecha temprana.");
                    return;
                }
                if (estadoDeReserva != resmodif && estadoDeReserva != resok)
                {
                    MessageBox.Show("La reserva no tiene el estado Correcto. Posiblemente cancelada");
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
                    MessageBox.Show("La reserva no tiene asignadas habitaciones.");
                    return; }

                if (hotelDeLaQuery.ToString() != Login.FrmSeleccionarHotel.codigoHotel.ToString())
                {
                    MessageBox.Show("Solo pueden hacer check-in los empleados del hotel donde se hizo la reserva.");
                    return;
                }

                string confirmacion = "EXEC FAGD.CheckinParaEstadia ";
                confirmacion = confirmacion + txtReserv.Text + ",";
              //confirmacion = confirmacion + Login.FrmLoginUsuario.username + ",";        
                confirmacion = confirmacion + "'" + diaActual.ToString("yyyyMMdd HH:mm:ss") + "'";
                resultadoQuery = Login.FrmTipoUsuario.BD.comando(confirmacion);
                resultadoQuery.Read();
                estadia = resultadoQuery.GetDecimal(0);
                resultadoQuery.Close();
                  if (estadia != 0)
                {
                    MessageBox.Show("Se ha realizado el check-in correctamente.");
                    //generamos la factura para despues
                    string fact = "EXEC FAGD.generarFactura " + estadia.ToString() + ",1,'" + diaActual.ToString("yyyyMMdd HH:mm:ss") + "'";
                    resultadoQuery = Login.FrmTipoUsuario.BD.comando(fact);
                    resultadoQuery.Read();
                    decimal factura = resultadoQuery.GetDecimal(0);
                    if (factura == 0)
                    {
                        resultadoQuery.Close();
                        MessageBox.Show("Error al crear factura, ya esta generada");
                        return;
                    }
                    resultadoQuery.Close();
                    //aca seria lo de clientesXEstadia que la vamos a crear
                    FrmRegistrarHuesped regHue = new FrmRegistrarHuesped(txtReserv.Text,estadia.ToString());
                    regHue.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la operacion, la estadia ya esta registrada");
                    return;
                }
                
                
                
            }
            else
            {
                resultadoQuery.Close();
                MessageBox.Show("Numero de reserva incorrecto.");
                return;
            } 
  
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistrarHuesped regHue = new FrmRegistrarHuesped(this);
            regHue.Show();
        }

        private void FrmCheckin_Load(object sender, EventArgs e)
        {

        }
    }
}


            
        