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

namespace FrbaHotel.Login
{
    public partial class FrmSeleccionarHotel : Form
    {
        private DataTable tabla;
        int Fila = 0;
        public decimal codigoHotel;
        private String hotelSeleccionado;
        char guion = '-';
        public FrmSeleccionarHotel(String usuario)
        {
            string usuarioIngresado = usuario;
            InitializeComponent();
            tabla = Login.FrmTipoUsuario.BD.consulta("SELECT [GD1C2018].[FAGD].[Hotel].[hotel_codigo] ,[hotel_calle],[hotel_nroCalle],[hotel_nombre],usuario_username  FROM [GD1C2018].[FAGD].[Hotel] JOIN [GD1C2018].[FAGD].[UsuarioXHotel] ON([GD1C2018].[FAGD].[Hotel].hotel_codigo = [GD1C2018].[FAGD].[UsuarioXHotel].hotel_codigo) WHERE usuario_username = '" + usuarioIngresado + "'");
            while (Fila < tabla.Rows.Count)
            {
                if (string.IsNullOrEmpty(tabla.Rows[Fila][3].ToString()))
                {
                    cboSeleccionarHotel.Items.Add(tabla.Rows[Fila][0].ToString() + "-" + tabla.Rows[Fila][1].ToString() + " " + tabla.Rows[Fila][2]);
                }
                else
                {
                    cboSeleccionarHotel.Items.Add(tabla.Rows[Fila][0].ToString() + "-" + tabla.Rows[Fila][3].ToString());
                }
                Fila++;
            }
            tabla.Clear();
        }

        private void lblHotelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptarHotel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboSeleccionarHotel.Text))
            {
                MessageBox.Show("Por favor, seleccione un hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hotelSeleccionado = cboSeleccionarHotel.Text;
                codigoHotel = Convert.ToDecimal(hotelSeleccionado.Split(guion)[0]);
                this.Close();
                FrmSeleccionarRol frmSeleccionarRol = new FrmSeleccionarRol();
                frmSeleccionarRol.Show();
            }
        }

        private void BtnVolverHotel_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTipoUsuario frmTipoUsuario = new FrmTipoUsuario();
            frmTipoUsuario.Show();
        }
    }
}