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
        Char separacion = '-';

        public AltaUsuario(Form formAnterior)
        {
            InitializeComponent();
            ultimoFormulario = formAnterior;
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

            cboRol.ResetText();
            cboHotel.ResetText();
            cboDocumento.ResetText();

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

                String direccionHotelR = cboHotel.Text;
                string[] direccionHotel = direccionHotelR.Split(separacion);
                String calle = direccionHotel[0];
                String nro = direccionHotel[1];

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
                reader = Login.FrmTipoUsuario.BD.comando(exe);
                if (reader.Read())
                {
                    resultado = reader.GetDecimal(0);
                }

                reader.Close();
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
                    MessageBox.Show("Usuario guardado correctamente!", "Usuario Guardado");
                    ultimoFormulario.Show();
                    this.Close();
                }
                
            }

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private Boolean chequearCampos()
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

                DateTime fechaMinima = VarGlobales.getDate().AddYears(-16);
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
                    return true;
                }
            }

        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void cargarComboRol()
        {
            String select = "SELECT rol_nombre FROM FAGD.Rol";
            DataTable tabla = new DataTable();

            reader = Login.FrmTipoUsuario.BD.comando(select);
            
            tabla.Columns.Add("rol_nombre", typeof(string));
            tabla.Load(reader);

            cboRol.ValueMember = "rol_nombre";
            cboRol.DisplayMember = "rol_nombre";
            cboRol.DataSource = tabla;
        }


        private void cargarComboHotel(){

            int fila = 0;
            tablaH = Login.FrmTipoUsuario.BD.consulta("SELECT DISTINCT hotel_calle, hotel_nroCalle FROM FAGD.Hotel");
            while (fila < tablaH.Rows.Count){
                cboHotel.Items.Add(tablaH.Rows[fila][0].ToString() + "-" + tablaH.Rows[fila][1].ToString());
                fila++;
            }
                
            tablaH.Clear();
        }

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

