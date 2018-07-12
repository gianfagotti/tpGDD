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

namespace FrbaHotel.AbmCliente
{
    public partial class FrmAltaCliente : Form
    {
        
        SqlDataReader resultado;
        Form abmPadre;


        public FrmAltaCliente(Form form)
        {
            InitializeComponent();
            abmPadre = form;

            dtpFechaNacimiento.Value = VarGlobales.getDate();

        }

        private void txtMail_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            abmPadre.Show();
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            int a = checkearCamposVacios();
            if (a == 0) {
                string comando = "EXEC FAGD.guardarNuevoCliente ";
                comando = comando + "'" + txtNombre.Text + "',";
                comando = comando + "'" + txtApellido.Text + "',";
                comando = comando + "'" + cboTipoDoc.Text + "',";
                comando = comando + txtNroDocumento.Text + ",";
                comando = comando + "'" + txtMail.Text + "',";
                comando = comando + txtTelefono.Text + ",";
                comando = comando + "'" + txtCalle.Text + "',";
                comando = comando + txtNumero.Text + ",";
                comando = comando + "'" + txtPiso.Text + "',";
                comando = comando + "'" + txtDpto.Text + "',";
                comando = comando + "'" + txtLocalidad.Text + "',";
                comando = comando + "'" + txtNacionalidad.Text + "',";

                DateTime fecha;

                fecha = Convert.ToDateTime(dtpFechaNacimiento.Value);
                string lala = fecha.Date.ToString("yyyyMMdd HH:mm:ss");

                comando = comando + "'" + lala + "',";

                if (chkHabilitado.Checked)
                    comando = comando + "1";
                else
                    comando = comando + "0";

                decimal resu = 0;
                resultado = Login.FrmTipoUsuario.BD.comando(comando);
                if (resultado.Read()) {
                    resu = resultado.GetDecimal(0);
                }
                resultado.Close();
                if (resu == 0)
                {
                    MessageBox.Show("Error al guardar, el cliente con ese mail ya existe");
                }
                else if (resu == 2)
                    MessageBox.Show("Error al guardar, el cliente con ese tipo y número de documento ya existe");
                else
                {
                    MessageBox.Show("El cliente fue guardado correctamente");
                    if (abmPadre.Name == "GenerarReserva")
                    {
                        GenerarModificacionReserva.GenerarReserva.clienteSeleccionado = resu.ToString();
                        GenerarModificacionReserva.GenerarReserva.ActiveForm.Show();
                        this.Close();
                    }
                    else if (abmPadre.Name == "FrmRegistrarEstadia")
                        this.Close();
                    //limpiarCampos();
                }
                
            }
        }

        private void limpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNroDocumento.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtPiso.Text = string.Empty;
            txtDpto.Text = string.Empty;
            txtLocalidad.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;
            cboTipoDoc.ResetText();
            dtpFechaNacimiento.ResetText();
            txtNombre.Focus();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private int checkearCamposVacios()
        {
            int a = 0;
            string mensaje = "";

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo nombre es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo apellido es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtNacionalidad.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo nacionalidad es obligatorio\n";
            }

            if (string.IsNullOrEmpty(cboTipoDoc.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo tipo documento es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo telefono es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtNroDocumento.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo numero documento es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtMail.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo mail es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo Calle es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo Numero es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtLocalidad.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo Localidad es obligatorio\n";
            }

            if (string.IsNullOrEmpty(txtPiso.Text))
            {
                txtPiso.Text = "-";
            }
            if (string.IsNullOrEmpty(txtDpto.Text))
            {
                txtDpto.Text = "-";
            }
            
            DateTime fecha;
            fecha = Convert.ToDateTime(dtpFechaNacimiento.Value);

            DateTime s = VarGlobales.getDate();

            int result = DateTime.Compare(fecha, s);

            if (result >= 0)
            {
                a = 1;
                mensaje = mensaje + "La fecha debe ser menor a la actual\n";
            }

            if (a == 1)
            {
                MessageBox.Show(mensaje);
            }
            return a;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
