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
        private DataTable hoteles,datosHotel,callesYAlturas;
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
        private String fechaCreacionHotelIngresadoPosta;
        private Decimal codigoHotelIngreso = Login.FrmSeleccionarHotel.codigoHotel;

        public FrmModificarHotel(AbmRol.frmMenuEmpleado frmMenuEmpleadoRecibido)
        {
            frmMenuEmpleado = frmMenuEmpleadoRecibido;
            InitializeComponent();
            regimenes = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("SELECT regimen_descripcion FROM FAGD.Regimen");
            while (regimenes.Read() == true)
            {
                this.clbRegimenes.Items.Add(regimenes.GetSqlString(0), true);
            }
            regimenes.Close();

            datosHotel = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT * FROM FAGD.Hotel WHERE hotel_codigo = " + codigoHotelIngreso);

            this.cboCantidadDeEstrellas.SelectedIndex = Convert.ToInt32(datosHotel.Rows[0][1].ToString()) - 1;
            this.txtRecargaPorEstrellasHotel.Text = datosHotel.Rows[0][2].ToString();
            this.txtPaisHotel.Text = datosHotel.Rows[0][3].ToString();
            this.txtCiudadHotel.Text = datosHotel.Rows[0][4].ToString();
            this.txtCalleHotel.Text = datosHotel.Rows[0][5].ToString();
            this.txtAlturaHotel.Text = datosHotel.Rows[0][6].ToString();
            this.txtNombreHotel.Text = datosHotel.Rows[0][7].ToString();

            if(String.IsNullOrEmpty(datosHotel.Rows[0][8].ToString())){
                this.dtpFechaCreacionHotel.Value = Login.FrmTipoUsuario.fechaApp;
            }
            else{
                this.dtpFechaCreacionHotel.Value = Convert.ToDateTime(datosHotel.Rows[0][8]);
            }
            this.txtMailHotel.Text = datosHotel.Rows[0][9].ToString();
            this.txtTelefonoHotel.Text = datosHotel.Rows[0][10].ToString();
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

        private void btnModificarHotel_Click(object sender, EventArgs e)
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
            if (txtsVacios != 0 || this.cboCantidadDeEstrellas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (validarEmail(this.txtMailHotel.Text) != true)
            {
                MessageBox.Show("Ingrese un email válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombreHotelIngresado = this.txtNombreHotel.Text;
                hoteles = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT hotel_nombre FROM FAGD.Hotel WHERE hotel_nombre = '" + nombreHotelIngresado + "' AND hotel_nombre != (SELECT hotel_nombre FROM FAGD.Hotel WHERE hotel_codigo = " + codigoHotelIngreso + ")");
                if (hoteles.Rows.Count != 0)
                {
                    MessageBox.Show("Ya existe un hotel con ese nombre, ingrese un nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                calleHotelIngresado = this.txtCalleHotel.Text;
                alturaHotelIngresado = this.txtAlturaHotel.Text;
                callesYAlturas = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT hotel_calle, hotel_nroCalle FROM FAGD.Hotel WHERE hotel_calle = '" + calleHotelIngresado + "' AND hotel_nroCalle = " + alturaHotelIngresado + " AND hotel_calle != (SELECT hotel_calle FROM FAGD.Hotel WHERE hotel_codigo = " + codigoHotelIngreso + ") AND hotel_nroCalle != (SELECT hotel_nroCalle FROM FAGD.Hotel WHERE hotel_codigo = " + codigoHotelIngreso + ")");
                if (callesYAlturas.Rows.Count != 0) 
                {
                    MessageBox.Show("Ya existe un hotel con esa dirección, ingrese un dirección válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mailHotelIngresado = this.txtMailHotel.Text;
                    telefonoHotelIngresado = this.txtTelefonoHotel.Text;
                    estrellasHotelIngresado = this.cboCantidadDeEstrellas.SelectedItem.ToString();
                    recargaEstrellasHotelIngresado = this.txtRecargaPorEstrellasHotel.Text;
                    ciudadHotelIngresado = this.txtCiudadHotel.Text;
                    paisHotelIngresado = this.txtPaisHotel.Text;
                    fechaCreacionHotelIngresado = Convert.ToDateTime(this.dtpFechaCreacionHotel.Value);
                    fechaCreacionHotelIngresadoPosta = fechaCreacionHotelIngresado.Date.ToString("yyyyMMdd HH:mm:ss");
                    resultadosCreacionDeHotel = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("EXEC FAGD.actualizarHotel " + estrellasHotelIngresado + ", " + recargaEstrellasHotelIngresado + ", '" + paisHotelIngresado + "', '" + ciudadHotelIngresado + "', '" + calleHotelIngresado + "', " + alturaHotelIngresado + ", '" + nombreHotelIngresado + "', '" + fechaCreacionHotelIngresadoPosta + "', '" + mailHotelIngresado + "', " + telefonoHotelIngresado + ", " + codigoHotelIngreso);
                    resultadosCreacionDeHotel.Close();
                    foreach (object itemChecked in clbRegimenes.CheckedItems)
                    {
                        resultadosCreacionDeRegimen = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("EXEC FAGD.insertarRegimenDeHotelCreado '" + nombreHotelIngresado + "', '" + itemChecked.ToString() + "'");
                        resultadosCreacionDeRegimen.Close();
                    }
                    MessageBox.Show("Hotel actualizado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtsSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

        private void btnBorrarTextosHotel_Click_1(object sender, EventArgs e)
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

            if (String.IsNullOrEmpty(datosHotel.Rows[0][8].ToString()))
            {
                this.dtpFechaCreacionHotel.Value = Login.FrmTipoUsuario.fechaApp;
            }
            else
            {
                this.dtpFechaCreacionHotel.Value = Convert.ToDateTime(datosHotel.Rows[0][8]);
            }
            this.cboCantidadDeEstrellas.SelectedIndex = - 1;
        }

        private void btnVolverHotel_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.Show();
        }

        private static bool validarEmail(string email)
        {
            try
            {
                new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

    }
}
