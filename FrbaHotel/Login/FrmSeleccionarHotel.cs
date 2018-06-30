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
        private DataTable tabla, tabla2, tabla3;
        int Fila = 0;
        public static decimal codigoHotel;
        private decimal codigoRol;
        public string usuarioIngresado;
        public static String hotelSeleccionado;
        char guion = '-';
        public FrmSeleccionarHotel(String usuario)
        {
            usuarioIngresado = usuario;
            InitializeComponent();
            tabla = Login.FrmTipoUsuario.BD.consulta("SELECT DISTINCT [GD1C2018].[FAGD].[Hotel].[hotel_codigo] ,[hotel_calle],[hotel_nroCalle],[hotel_nombre],usuario_username  FROM [GD1C2018].[FAGD].[Hotel] JOIN [GD1C2018].[FAGD].[UsuarioXRolXHotel] ON([GD1C2018].[FAGD].[Hotel].hotel_codigo = [GD1C2018].[FAGD].[UsuarioXRolXHotel].hotel_codigo) WHERE usuario_username = '" + usuarioIngresado + "'");
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
                tabla2 = Login.FrmTipoUsuario.BD.consulta("SELECT * FROM [GD1C2018].[FAGD].[Hotel] WHERE hotel_estado = " + 0 + "AND hotel_codigo = " + codigoHotel);
                if (tabla2.Rows.Count == 1)
                {
                    MessageBox.Show("El hotel está inhabilitado, no puede acceder a administrarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tabla3 = Login.FrmTipoUsuario.BD.consulta("SELECT rol_nombre, FAGD.Rol.rol_codigo FROM FAGD.Rol JOIN FAGD.UsuarioXRolXHotel ON (FAGD.Rol.rol_codigo = FAGD.UsuarioXRolXHotel.rol_codigo) WHERE hotel_codigo = " + codigoHotel + " AND usuario_username = '" + usuarioIngresado + "'");
                    if (tabla3.Rows.Count == 1)
                    {
                        codigoRol = Convert.ToDecimal(tabla3.Rows[0][1]);
                        AbmRol.frmMenuEmpleado frmMenuEmpleado = new AbmRol.frmMenuEmpleado(codigoRol);
                        this.Close();
                        frmMenuEmpleado.Show();
                    }
                    else
                    {
                        FrmSeleccionarRol frmSeleccionarRol = new FrmSeleccionarRol(codigoHotel, usuarioIngresado);
                        frmSeleccionarRol.Show();
                        this.Close();
                    }
                }
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