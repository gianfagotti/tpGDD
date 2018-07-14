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

namespace FrbaHotel.AbmUsuario
{
    public partial class AltaUsuario : Form
    {
        Form ultimoFormulario;
        SqlDataReader reader;
        DataTable tablaH;
        Char separacion = '-'; /*Establezco una separación para utilizar en la función Split para luego reconocer el hotel ingresado*/

        public AltaUsuario(Form formAnterior)
        {
            InitializeComponent();
            dtpFechaNac.Value = FechaConfig.getDate(); /*Seteo la fecha del dtp a la asignada en FechaConfig*/
            ultimoFormulario = formAnterior;
            /*Cargo los combo boxes con los roles y hoteles existentes*/
            cargarComboRol();
            cargarComboHotel();
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ultimoFormulario.Show();
            this.Close();

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void btnVaciar_Click(object sender, EventArgs e)
        {
            /*Utilización de una lambda para borrar todos los text boxes*/
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

            /*Seteo los combo boxes en el item vacío*/
            cboRol.SelectedIndex = -1;
            cboHotel.SelectedIndex = -1;
            cboDocumento.SelectedIndex = -1;

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Boolean exito = chequearCampos();
            if (exito)
            {
                /*Convierto la fecha para el correcto funcionamiento en sqlserver*/
                DateTime fecha;
                fecha = Convert.ToDateTime(dtpFechaNac.Value);
                string fechaNacimiento = fecha.Date.ToString("yyyyMMdd HH:mm:ss");

                /*Separo el hotel ingresado en Calle y altura*/
                String direccionHotelR = cboHotel.Text;
                string[] direccionHotel = direccionHotelR.Split(separacion);
                String calle = direccionHotel[0];
                String nro = direccionHotel[1];


                /*Se agregan los datos insertados a la consulta*/
                string exe = "EXEC FAGD.guardarUsuario ";
                exe = exe + "'" + txtNombre.Text + "',";
                exe = exe + "'" + txtApellido.Text + "', ";
                exe = exe + "'" + txtUsername.Text + "', ";
                exe = exe + "'" + Login.FrmTipoUsuario.encriptar(txtContraseña.Text) + "', ";
                exe = exe + "'" + cboDocumento.Text + "', ";
                exe = exe + "'" + txtDocumento.Text + "', ";
                exe = exe + "'" + txtDireccion.Text + "', ";
                exe = exe + "'" + txtMail.Text + "',";
                exe = exe + "'" + calle + "',";
                exe = exe + "'" + nro + "',";
                exe = exe + "'" + cboRol.Text + "', ";
                exe = exe + "'" + txtTelefono.Text + "',";
                exe = exe + "'" + fechaNacimiento + "'";
               

                decimal resultado = 0;
                reader = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(exe); /*Ejecuto la consulta definida previamente*/
                if (reader.Read())
                {
                    resultado = reader.GetDecimal(0);
                }

                reader.Close();

                /*Verifico posibles errores*/
                if (resultado == 0)
                {
                    MessageBox.Show("Ya existe un usuario con ese nombre de usuario", "Error");
                    txtUsername.Focus();
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Error al crear al usuario", "Error");
                }
                else
                {
                    /*Aviso al usuario de que no hubo problemas en la transacción y vuelvo al formulario anterior*/
                    MessageBox.Show("Usuario guardado correctamente!", "Usuario Guardado");
                    ultimoFormulario.Show();
                    this.Close();
                }
                
            }

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private Boolean chequearCampos() /*Checkeo que los campos estén completos, que la fecha de nacimiento sea >16 años y que el mail tenga un formato válido */
        {
            if(string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtContraseña.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text) ||
                string.IsNullOrEmpty(txtDocumento.Text) ||
                string.IsNullOrEmpty(txtMail.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) ||
                string.IsNullOrEmpty(cboDocumento.Text) ||
                string.IsNullOrEmpty(cboHotel.Text) ||
                string.IsNullOrEmpty(cboRol.Text)
                )
            {
                MessageBox.Show("Todos los campos son obligatorios y deben ser completados.", "Error");
                return false;
            }
            else
            {

                DateTime fechaMinima = FechaConfig.getDate().AddYears(-16);
                DateTime fechaIngresada = Convert.ToDateTime(dtpFechaNac.Value);
                int resultado = DateTime.Compare(fechaMinima, fechaIngresada);

                /*Si la comparación entre las fechas devuelve -1, entonces no cumple con el requisito de que sea >16 */
                if (resultado < 0)
                {
                    MessageBox.Show("El usuario debe ser mayor de 16 años", "Error");
                    dtpFechaNac.Focus();
                    return false;
                }
                else
                {
                    if (validarEmail(txtMail.Text))
                    {
                        return true;
                    }
                    else return false;
                }
            }

        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void cargarComboRol() /*Cargo los roles a insertar en el combo box, exceptuando 'Administrador general' */
        {
            String select = "SELECT rol_nombre FROM FAGD.Rol WHERE rol_nombre <> 'Administrador general'";
            DataTable tabla = new DataTable();

            reader = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(select);
            
            tabla.Columns.Add("rol_nombre", typeof(string));
            tabla.Load(reader);

            cboRol.ValueMember = "rol_nombre";
            cboRol.DisplayMember = "rol_nombre";
            cboRol.DataSource = tabla;
        }


        private void cargarComboHotel()
        { /*Cargo los hoteles a insertar en el combo box*/

            int fila = 0;
            tablaH = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT DISTINCT hotel_calle, hotel_nroCalle FROM FAGD.Hotel");
            while (fila < tablaH.Rows.Count){
                cboHotel.Items.Add(tablaH.Rows[fila][0].ToString() + "-" + tablaH.Rows[fila][1].ToString());
                fila++;
            }
                
            tablaH.Clear();
        }

        /*Inhabilito la posibilidad de ingresar letras en el documento y en el telefono*/
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        /*Verifico el formato del mail ingresado*/
        private static bool validarEmail(string email)
        {
            try
            {
                new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un mail válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


    }

}

