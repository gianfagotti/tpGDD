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
    public partial class FrmAltaHotel : Form
    {
        AbmRol.frmMenuEmpleado frmMenuEmpleado;
        private SqlDataReader regimenes;
        private SqlDataReader resultadosCreacionDeHotel;
        private SqlDataReader resultadosCreacionDeRegimen;
        private DataTable hoteles,callesYAlturas;
        private String nombreHotelIngresado;
        private String mailHotelIngresado;
        private String telefonoHotelIngresado;
        private String calleHotelIngresado;
        private String alturaHotelIngresado;
        private String estrellasHotelIngresado;
        private String recargaEstrellasHotelIngresado;
        private String ciudadHotelIngresado;
        private String paisHotelIngresado;
        private String fechaCreacionHotelIngresadoPosta;
        private DateTime fechaCreacionHotelIngresado;
        public FrmAltaHotel(AbmRol.frmMenuEmpleado frmMenuEmpleadoRecibido)
        {
            InitializeComponent();
            frmMenuEmpleado = frmMenuEmpleadoRecibido;
            regimenes = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("SELECT regimen_descripcion FROM FAGD.Regimen");
            while (regimenes.Read() == true)
            {
                this.clbRegimenes.Items.Add(regimenes.GetSqlString(0), true);
            }                                                                                                                                       //Se carga la fecha del sistema segun el app config. en el date time picker, como sugerencia inicial.
            regimenes.Close();
            dtpFechaCreacionHotel.Value = Login.FrmTipoUsuario.fechaApp;                                                                           //Se cargan como opción de un checked list box, todos los regimenes registrados, para que el usuario elija cuales tendrá el hotel.
        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadDeEstrellas_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaHotel_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrarTextosHotel_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)                                                                                               //Se borran todos los textbox y se vuelve los comobo box a su estado original.
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
            this.cboCantidadDeEstrellas.SelectedIndex = -1;
            dtpFechaCreacionHotel.Value = Login.FrmTipoUsuario.fechaApp;
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
                    if (control is TextBox && string.IsNullOrEmpty(control.Text))                                                                       //Se validan que todos los textbox asi como los combo box esten completos.
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
            if (funcionesGlobales.validarEmail(this.txtMailHotel.Text) != true)
            {
                MessageBox.Show("Ingrese un email válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombreHotelIngresado = this.txtNombreHotel.Text;
                hoteles = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT hotel_nombre FROM FAGD.Hotel WHERE hotel_nombre = '" + nombreHotelIngresado + "'");
                if (hoteles.Rows.Count == 1)
                {
                    MessageBox.Show("Ya existe un hotel con ese nombre, ingrese un nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                    //Se valida que en la base de datos no haya hoteles con el nombre ingresado en el textbox nombreHotel.
                    return;
                }
                calleHotelIngresado = this.txtCalleHotel.Text;
                alturaHotelIngresado = this.txtAlturaHotel.Text;
                callesYAlturas = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT hotel_calle, hotel_nroCalle FROM FAGD.Hotel WHERE hotel_calle = '" + calleHotelIngresado + "' AND hotel_nroCalle = " + alturaHotelIngresado);
                if (callesYAlturas.Rows.Count != 0)
                {
                    MessageBox.Show("Ya existe un hotel con esa dirección, ingrese un dirección válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                              //Se valida que no haya un hotel en la base de datos que tenga la misma dirección que la ingresada en el formulario.
                }
                else
                {
                    mailHotelIngresado = this.txtMailHotel.Text;
                    telefonoHotelIngresado = this.txtTelefonoHotel.Text;
                    estrellasHotelIngresado = this.cboCantidadDeEstrellas.SelectedItem.ToString();
                    recargaEstrellasHotelIngresado = this.txtRecargaPorEstrellasHotel.Text;
                    ciudadHotelIngresado =  this.txtCiudadHotel.Text;
                    paisHotelIngresado = this.txtPaisHotel.Text;
                    fechaCreacionHotelIngresado = Convert.ToDateTime(this.dtpFechaCreacionHotel.Value);                                                                                       //De no haber ningun tipo de repetidos o inconvenientes, se carga el hotel en la base de datos.
                    fechaCreacionHotelIngresadoPosta = fechaCreacionHotelIngresado.Date.ToString("yyyyMMdd HH:mm:ss");
                    resultadosCreacionDeHotel = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("EXEC FAGD.insertarHotel " + estrellasHotelIngresado + ", " + recargaEstrellasHotelIngresado + ", '" + paisHotelIngresado + "', '" + ciudadHotelIngresado + "', '" + calleHotelIngresado + "', " + alturaHotelIngresado + ", '" + nombreHotelIngresado + "', '" + fechaCreacionHotelIngresadoPosta + "', '" + mailHotelIngresado + "', " + telefonoHotelIngresado);
                    resultadosCreacionDeHotel.Close();
                    foreach(object itemChecked in clbRegimenes.CheckedItems)
                    {
                        resultadosCreacionDeRegimen = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("EXEC FAGD.insertarRegimenDeHotelCreado '"+nombreHotelIngresado+"', '"+itemChecked.ToString()+"'"); //Se carga uno por uno los regimenes seleccionados, para el hotel creado.
                        resultadosCreacionDeRegimen.Close();
                    }
                    MessageBox.Show("Hotel creado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    SeleccionarAdministrador frmSeleccionarAdministrador = new SeleccionarAdministrador(frmMenuEmpleado, nombreHotelIngresado);                                                 //Se le avisa al usuario que el hotel fue correctamente creado, y se procede al formulario para la eleccion del administrador del mismo.
                    frmSeleccionarAdministrador.Show();
                }
            }
        }

        private void lblDatosHotel_Click(object sender, EventArgs e)
        {

        }

        private void lblPais_Click(object sender, EventArgs e)
        {
        
        }

        private void txtTelefonoHotel_TextChanged(object sender, EventArgs e)
        {

        }

         private void txtsSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))                                                                             //Funcion que solo permite que se ingresen numeros en los txts, de no apretar un numero en el teclado, no se carga
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
             else if (Char.IsSeparator(e.KeyChar))                                                                              //Funcion que solo permite que se carguen letras en los txts, de no apretar una letra en el teclado, no se carga.
             {
                 e.Handled = false;
             }
             else
             {
                 e.Handled = true;
             }
         }
    }
}