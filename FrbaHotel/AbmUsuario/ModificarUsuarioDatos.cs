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
    public partial class ModificarUsuarioDatos : Form
    {
        Form ultimoForm;
        String usuario;
        SqlDataReader reader;
        DataTable tabla;

        public ModificarUsuarioDatos(Form formAnterior, String usuarioSeleccionado)
        {
            usuario = usuarioSeleccionado;
            ultimoForm = formAnterior;
            InitializeComponent();
            llenarCampos(); /*Relleno los campos con los datos provenientes de la BD del usuario seleccionado en el form anterior */
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            ultimoForm.Show();
        }

        private void btnVaciar_Click(object sender, EventArgs e) /*Vacío textos y cbo's*/
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
                /*Convierto la fecha para su uso en sql*/
                DateTime fecha = Convert.ToDateTime(dtpFechaNac.Value);
                string fechaNacimiento = fecha.Date.ToString("yyyyMMdd HH:mm:ss");

                /*Creo la query para la ejecución del procedure*/
                string exe = "EXEC FAGD.updatearDatosUsuario ";
                exe = exe + "'" + usuario + "', ";
                exe = exe + "'" + txtNombre.Text + "', ";
                exe = exe + "'" + txtApellido.Text + "', ";
                exe = exe + "'" + cboDocumento.Text + "', ";
                exe = exe + "'" + txtDocumento.Text + "', ";
                exe = exe + "'" + txtDireccion.Text + "', ";
                exe = exe + "'" + txtMail.Text + "', ";
                exe = exe + "'" + txtTelefono.Text + "', ";
                exe = exe + "'" + fechaNacimiento + "'";


                decimal resultado = 0;
                /*ejecuto la query*/
                reader = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(exe);
                if (reader.Read())
                {
                    resultado = reader.GetDecimal(0);
                }

                reader.Close();
                /*Verifico errores*/
                if (resultado == 0)
                {
                    MessageBox.Show("Ya existe un usuario con ese mail", "Error");
                    txtMail.Focus();
                }
                else
                    /*Confirmo al usuario la transacción*/
                {
                    MessageBox.Show("Usuario guardado correctamente!", "Usuario Guardado");
                    ultimoForm.Show();
                    this.Close();
                }

            }

        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private Boolean chequearCampos() /*Nuevamente, checkeo campos vacíos, si el usuario es >16 y si el mail tiene un formato correcto*/
        {

            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text) ||
                string.IsNullOrEmpty(txtDocumento.Text) ||
                string.IsNullOrEmpty(txtMail.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) ||
                string.IsNullOrEmpty(cboDocumento.Text)
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

                if (resultado < 0)
                {
                    MessageBox.Show("El usuario debe ser mayor de 16 años", "Error");
                    dtpFechaNac.Focus();
                    return false;
                }
                else
                {
                    if (funcionesGlobales.validarEmail(txtMail.Text))
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

        private void llenarCampos() {
            /*Realizo una query que me traiga los datos del usuario para llenar los campos con los mismos*/
            String select = "SELECT * FROM FAGD.Usuario WHERE usuario_username = '"+usuario+"'";
            tabla = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta(select);
            txtUsername.Text = usuario;
            txtNombre.Text = tabla.Rows[0][2].ToString();
            txtApellido.Text = tabla.Rows[0][3].ToString();
            txtDireccion.Text = tabla.Rows[0][4].ToString();
            txtMail.Text = tabla.Rows[0][5].ToString();
            txtTelefono.Text = tabla.Rows[0][6].ToString();
            dtpFechaNac.Value = Convert.ToDateTime(tabla.Rows[0][7].ToString());
            cboDocumento.Text = tabla.Rows[0][8].ToString();
            txtDocumento.Text = tabla.Rows[0][9].ToString();
           
        }

        /*Inhabilito uso de letras en documento y telefono*/
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

     }
}
