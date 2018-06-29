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
    public partial class FrmSeleccionarRol : Form
    {
        private SqlDataReader resultado;
        private DataTable tabla;
        decimal codigoHotel;
        decimal codigoRol;
        string usuarioIngresado;
        int i = 0;
        public FrmSeleccionarRol(decimal codigoHotelRecibido, string usuarioIngresadoRecibido)
        {
            InitializeComponent();
            codigoHotel = codigoHotelRecibido;
            usuarioIngresado = usuarioIngresadoRecibido;
            tabla = Login.FrmTipoUsuario.BD.consulta("SELECT rol_nombre, FAGD.Rol.rol_codigo FROM FAGD.Rol JOIN FAGD.UsuarioXRolXHotel ON (FAGD.Rol.rol_codigo = FAGD.UsuarioXRolXHotel.rol_codigo) WHERE hotel_codigo = " + codigoHotel + " AND usuario_username = '" + usuarioIngresado + "'");
            while (i < tabla.Rows.Count)
                {
                  cmbRolesRegistrados.Items.Add(tabla.Rows[i][0].ToString());
                  i++;
                }
            }

        private void cmbRolesRegistrados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSeleccionarRol_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverATipoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTipoUsuario frmTipoUsuario = new FrmTipoUsuario();
            frmTipoUsuario.Show();
        }

        private void btnAceptarRol_Click(object sender, EventArgs e)
        {

            resultado = Login.FrmTipoUsuario.BD.comando("SELECT DISTINCT rol_codigo FROM FAGD.Rol where rol_nombre = '" + cmbRolesRegistrados.SelectedItem.ToString() + "'");
            if (resultado.Read() == true)
            {
                codigoRol = resultado.GetDecimal(0);
                resultado.Close();
            }
            if (codigoRol != 0)
            {

                AbmRol.frmMenuEmpleado frmMenuEmpleado = new AbmRol.frmMenuEmpleado(codigoRol);
                this.Close();
                frmMenuEmpleado.Show();
            }
            else
                MessageBox.Show("Seleccione un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
