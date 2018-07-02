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
    public partial class SeleccionarAdministrador : Form
    {
        private Form frmMenuEmpleado;
        private DataTable usuarios,hotel;
        private String nombreHotel;
        private Decimal codigoHotel;
        private SqlDataReader resultado;
        int i = 0;
        public SeleccionarAdministrador(Form frmMenuEmpleadoRecibido ,String nombreHotelIngresadoRecibido)
        {
            frmMenuEmpleado = frmMenuEmpleadoRecibido;
            nombreHotel = nombreHotelIngresadoRecibido;
            InitializeComponent();
            usuarios = Login.FrmTipoUsuario.BD.consulta("SELECT usuario_username FROM FAGD.Usuario");
            while (i < usuarios.Rows.Count)
            {
                cboSeleccionarAdministrador.Items.Add(usuarios.Rows[i][0].ToString());
                i++;
            }

        }

        private void btnAceptarAdministrador_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboSeleccionarAdministrador.Text))
            {
                MessageBox.Show("Por favor, seleccione un administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String usuarioSeleccionado = cboSeleccionarAdministrador.Text;
                hotel = Login.FrmTipoUsuario.BD.consulta("SELECT hotel_codigo FROM FAGD.Hotel WHERE hotel_nombre = '" + nombreHotel + "'");
                codigoHotel = Convert.ToDecimal(hotel.Rows[0][0]);
                resultado = Login.FrmTipoUsuario.BD.comando("EXEC FAGD.insertarAdministradorNuevoHotel '" + usuarioSeleccionado + "', " + codigoHotel);
                MessageBox.Show("Administrador asignado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMenuEmpleado.Show();
            }
        }
    }
}
