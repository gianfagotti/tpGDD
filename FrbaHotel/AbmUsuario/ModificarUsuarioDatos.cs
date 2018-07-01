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

        public ModificarUsuarioDatos(Form formAnterior, String usuarioSeleccionado)
        {
            usuario = usuarioSeleccionado;
            ultimoForm = formAnterior;
            InitializeComponent();
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            ultimoForm.Show();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
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


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Boolean exito = chequearCampos();
            if (exito)
            {
                DateTime fecha;

                fecha = Convert.ToDateTime(dtpFechaNac.Value);
                string fechaNacimiento = fecha.Date.ToString("yyyyMMdd HH:mm:ss");

                string exe = "EXEC FAGD.updatearDatosUsuario ";
                exe = exe + "'" + usuario + "', ";
                exe = exe + "'" + txtNombre.Text + "', ";
                exe = exe + "'" + txtApellido.Text + "', ";
                exe = exe + "'" + txtContraseña.Text + "', ";
                exe = exe + "'" + cboDocumento.Text + "', ";
                exe = exe + "'" + txtDocumento.Text + "', ";
                exe = exe + "'" + txtDireccion.Text + "', ";
                exe = exe + "'" + txtMail.Text + "', ";
                exe = exe + "'" + txtTelefono.Text + "', ";
                exe = exe + "'" + fechaNacimiento + "'";


                decimal resultado = 0;
                reader = Login.FrmTipoUsuario.BD.comando(exe);
                if (reader.Read())
                {
                    resultado = reader.GetDecimal(0);
                }

                reader.Close();
                if (resultado == 0)
                {
                    MessageBox.Show("Ya existe un usuario con ese mail", "Error");
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Error al crear al usuario", "Error");
                }
                else
                {
                    MessageBox.Show("Usuario guardado correctamente!", "Usuario Guardado");
                }

            }

            ultimoForm.Show();
            this.Close();
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private Boolean chequearCampos()
        {

            DateTime hoy = DateTime.Now;
            DateTime fechaIngresada;
            fechaIngresada = Convert.ToDateTime(dtpFechaNac.Value);

            hoy.AddYears(-16);

            int resultado = DateTime.Compare(fechaIngresada, hoy);

            if (resultado >= 0)
            {
                MessageBox.Show("El usuario debe ser mayor de edad", "Error");
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtContraseña.Text) ||
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
            else return true; 

        }
    }
}
