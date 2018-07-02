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
    public partial class FrmModificarHotel : Form
    {
        AbmRol.frmMenuEmpleado frmMenuEmpleado;
        private SqlDataReader regimenes;
        private SqlDataReader resultadosCreacionDeHotel;
        private SqlDataReader resultadosCreacionDeRegimen;
        private DataTable hoteles;
        private String nombreHotelIngresado;
        private String mailHotelIngresado;
        private String telefonoHotelIngresado;
        private String calleHotelIngresado;
        private String alturaHotelIngresado;
        private String estrellasHotelIngresado;
        private String recargaEstrellasHotelIngresado;
        private String ciudadHotelIngresado;
        private String paisHotelIngresado;
        private DateTime fechaCreacionHotelIngresado;
        private Decimal codigoHotelIngreso = Login.FrmSeleccionarHotel.codigoHotel;
        public FrmModificarHotel(AbmRol.frmMenuEmpleado frmMenuEmpleadoRecibido)
        {
            frmMenuEmpleado = frmMenuEmpleadoRecibido;
            InitializeComponent();
            regimenes = Login.FrmTipoUsuario.BD.comando("SELECT regimen_descripcion FROM FAGD.Regimen");
            while (regimenes.Read() == true)
            {
                this.clbRegimenes.Items.Add(regimenes.GetSqlString(0), true);
            }
            regimenes.Close();
        }

        private void btnBorrarTextosHotel_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnVolverHotel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.Show();
        }

        private void btnCrearHotel_Click(object sender, EventArgs e)
        {
            int txtsVacios = 0;
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox && string.IsNullOrEmpty(control.Text))
                        txtsVacios++;
                    else
                        func(control.Controls);
            };
            func(Controls);
            if (txtsVacios != 0)
            {
                MessageBox.Show("Debe completar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombreHotelIngresado = this.txtNombreHotel.Text;
                hoteles = Login.FrmTipoUsuario.BD.consulta("SELECT hotel_nombre FROM FAGD.Hotel WHERE hotel_nombre = '" + nombreHotelIngresado + "' AND hotel_nombre != (SELECT hotel_nombre FROM FAGD.Hotel WHERE hotel_codigo = " + codigoHotelIngreso + ")");
                if (hoteles.Rows.Count == 1)
                {
                    MessageBox.Show("Ya existe un hotel con ese nombre, ingrese un nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mailHotelIngresado = this.txtMailHotel.Text;
                    telefonoHotelIngresado = this.txtTelefonoHotel.Text;
                    calleHotelIngresado = this.txtCalleHotel.Text;
                    alturaHotelIngresado = this.txtAlturaHotel.Text;
                    estrellasHotelIngresado = this.txtCantidadDeEstrellasHotel.Text;
                    recargaEstrellasHotelIngresado = this.txtRecargaPorEstrellasHotel.Text;
                    ciudadHotelIngresado = this.txtCiudadHotel.Text;
                    paisHotelIngresado = this.txtPaisHotel.Text;
                    fechaCreacionHotelIngresado = Convert.ToDateTime(this.dtpFechaCreacionHotel.Value);
                    resultadosCreacionDeHotel = Login.FrmTipoUsuario.BD.comando("EXEC FAGD.actualizarHotel " + estrellasHotelIngresado + ", " + recargaEstrellasHotelIngresado + ", '" + paisHotelIngresado + "', '" + ciudadHotelIngresado + "', '" + calleHotelIngresado + "', " + alturaHotelIngresado + ", '" + nombreHotelIngresado + "', '" + fechaCreacionHotelIngresado + "', '" + mailHotelIngresado + "', " + telefonoHotelIngresado + ", " + codigoHotelIngreso);
                    resultadosCreacionDeHotel.Close();
                    foreach (object itemChecked in clbRegimenes.CheckedItems)
                    {
                        resultadosCreacionDeRegimen = Login.FrmTipoUsuario.BD.comando("EXEC FAGD.insertarRegimenDeHotelCreado '" + nombreHotelIngresado + "', '" + itemChecked.ToString() + "'");
                        resultadosCreacionDeRegimen.Close();
                    }
                    MessageBox.Show("Hotel creado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    SeleccionarAdministrador frmSeleccionarAdministrador = new SeleccionarAdministrador(frmMenuEmpleado, nombreHotelIngresado);
                    frmSeleccionarAdministrador.Show();
                }
            }
        }

        private void txtTelefonoHotel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCantidadDeEstrellasHotel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRecargaPorEstrellasHotel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAlturaHotel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lblDatosHotel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
