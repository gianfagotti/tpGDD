using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.AbmRol;
using System.Data.SqlClient;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class GenerarReserva : Form
    {
        Form ultimoFormulario;
        private DataTable tabla;
        int Fila = 0;
        BindingSource bSource2;
        private SqlDataReader resultado;
        SqlDataAdapter sAdapter;
        string consulta;
        decimal codHotelSeleccionado;
        public static string clienteSeleccionado = "";

        public GenerarReserva(Form form)
        {
            InitializeComponent();
            ultimoFormulario = form;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            ultimoFormulario.Show();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            cboHotel.ResetText();
            cboRegimen.ResetText();
            cboTipoHabitacion.ResetText();
            txtCliente.ResetText();
            dtpDesde.ResetText();
            dtpHasta.ResetText();
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {
            //clienteSeleccionado = "";

            if (Login.FrmTipoUsuario.usuario == "guest")
            {
                cboHotel.Enabled = true;

                tabla = Login.FrmTipoUsuario.BD.consulta("SELECT DISTINCT [GD1C2018].[FAGD].[Hotel].[hotel_codigo] ,[hotel_calle],[hotel_nroCalle],[hotel_nombre],usuario_username  FROM [GD1C2018].[FAGD].[Hotel] JOIN [GD1C2018].[FAGD].[UsuarioXRolXHotel] ON([GD1C2018].[FAGD].[Hotel].hotel_codigo = [GD1C2018].[FAGD].[UsuarioXRolXHotel].hotel_codigo) where [GD1C2018].[FAGD].[Hotel].hotel_estado = 1");
                while (Fila < tabla.Rows.Count)
                {
                    if (string.IsNullOrEmpty(tabla.Rows[Fila][3].ToString()))
                    {
                        cboHotel.Items.Add(tabla.Rows[Fila][0].ToString() + "-" + tabla.Rows[Fila][1].ToString() + " " + tabla.Rows[Fila][2]);
                    }
                    else
                    {
                        cboHotel.Items.Add(tabla.Rows[Fila][0].ToString() + "-" + tabla.Rows[Fila][3].ToString());
                    }
                    Fila++;
                }
                tabla.Clear();
            }
            else
            {
                cboHotel.Text = Login.FrmSeleccionarHotel.hotelSeleccionado;

                consulta = "select distinct habitacionTipo_descripcion from FAGD.HabitacionTipo, FAGD.Habitacion, FAGD.Hotel where habitacionTipo_codigo = habitacion_tipoCodigo AND habitacion_codigoHotel = hotel_codigo AND hotel_codigo = " + Login.FrmSeleccionarHotel.codigoHotel;
                resultado = Login.FrmTipoUsuario.BD.comando(consulta);
                cboTipoHabitacion.Items.Clear();
                while (resultado.Read() == true)
                {
                    cboTipoHabitacion.Items.Add(resultado.GetString(0));
                }
                resultado.Close();
                consulta = "select distinct R.regimen_descripcion from FAGD.Regimen R, FAGD.HotelXRegimen H where R.regimen_codigo = H.regimen_codigo AND H.hotel_codigo = " + Login.FrmSeleccionarHotel.codigoHotel;
                resultado = Login.FrmTipoUsuario.BD.comando(consulta);
                cboRegimen.Items.Clear();
                while (resultado.Read() == true)
                {
                    cboRegimen.Items.Add(resultado.GetString(0));
                }
                resultado.Close();
            }
        }

        private void cboHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            codHotelSeleccionado = Convert.ToDecimal(cboHotel.Text.Split('-')[0]);

            consulta = "select distinct habitacionTipo_descripcion from FAGD.HabitacionTipo, FAGD.Habitacion, FAGD.Hotel where habitacionTipo_codigo = habitacion_tipoCodigo AND habitacion_codigoHotel = hotel_codigo AND hotel_codigo = " + codHotelSeleccionado;
            resultado = Login.FrmTipoUsuario.BD.comando(consulta);
            cboTipoHabitacion.Items.Clear();
            while (resultado.Read() == true)
            {
                cboTipoHabitacion.Items.Add(resultado.GetString(0));
            }
            resultado.Close();
            consulta = "select distinct R.regimen_descripcion from FAGD.Regimen R, FAGD.HotelXRegimen H where R.regimen_codigo = H.regimen_codigo AND H.hotel_codigo = " + codHotelSeleccionado;
            resultado = Login.FrmTipoUsuario.BD.comando(consulta);
            cboRegimen.Items.Clear();
            while (resultado.Read() == true)
            {
                cboRegimen.Items.Add(resultado.GetString(0));
            }
            resultado.Close();
        }

        private void butClienteExistente_Click(object sender, EventArgs e)
        {
            BuscarClientes cli = new BuscarClientes(this);
            cli.Show();
        }

        private void GenerarReserva_Activated(object sender, EventArgs e)
        {
            if (clienteSeleccionado != "")
            {
                txtCliente.Text = clienteSeleccionado;
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbmCliente.FrmAltaCliente frmAltaCliente = new AbmCliente.FrmAltaCliente(this);
            frmAltaCliente.Show();
        }

    }
}
