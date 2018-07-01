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
        //SqlDataAdapter adapter;
        DataTable tabla, tablaH;
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

            //cboRol.SelectedIndex = -1;
            //cboHotel.SelectedIndex = -1;
            //cboDocumento.SelectedIndex = -1;

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
                exe = exe + "'" + txtContraseña.Text + "', ";
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

            ultimoFormulario.Show();
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
            else { return true; }

        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void cargarComboRol()
        {
            String select = "SELECT rol_nombre FROM FAGD.Rol";

            // adapter = Login.FrmTipoUsuario.BD.dameDataAdapter(select);
            reader = Login.FrmTipoUsuario.BD.comando(select);

            DataTable tabla = new DataTable();
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
            

    }

}

