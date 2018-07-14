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
    public partial class SeleccionarUsuario : Form
    {
        Form ultimoForm;
        String usuario;
        SqlDataReader reader;
        decimal hotelLogin;

        public SeleccionarUsuario(Form form)
        {
            ultimoForm = form;
            InitializeComponent();
            hotelLogin = Login.FrmSeleccionarHotel.codigoHotel; /*Verifico en qué hotel se está logueado actualmente*/
            cargarComboUsuarios(); /*lleno el combo box con los usuarios que ejercen algún rol en el hotel donde está logueado el admin*/
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnDatos_Click(object sender, EventArgs e)
        {
            if (checkearCbo())
            {
                ModificarUsuarioDatos frm = new ModificarUsuarioDatos(this, usuario);
                this.Hide();
                frm.Show();
            }
            else MessageBox.Show("Debe seleccionar un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            ultimoForm.Show();
            this.Close();
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void cboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            usuario = cboUsuarios.Text; /*seteo el valor de la variable cada vez que se selecciona un item en el combobox*/
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void cargarComboUsuarios() /*cargo el combo con los usuarios que ejercen algún rol en el hotel donde está logueado el administrador (exceptuando admin y guest)*/
        {
            String select = "SELECT usuario_username FROM FAGD.Usuario WHERE usuario_username <> 'GUEST' AND usuario_username <> 'admin' AND usuario_username IN (SELECT usuario_username FROM "
                           +"FAGD.UsuarioXRolXHotel WHERE hotel_codigo = '" +hotelLogin+"')";

            reader = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(select);

            DataTable tabla = new DataTable();
            tabla.Columns.Add("usuario_username", typeof(string));
            tabla.Load(reader);

            cboUsuarios.ValueMember = "usuario_username";
            cboUsuarios.DisplayMember = "usuario_username";
            cboUsuarios.DataSource = tabla;
            reader.Close();
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private Boolean checkearCbo() { /*verifico que se haya seleccionado algun rol*/
            if (String.IsNullOrEmpty(usuario))
            {
                return false;
            }
            else return true;
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (checkearCbo())
            {
                /*ejecuto el procedimiento que cambia el estado del usuario seleccionado */
                String exe = "EXEC FAGD.cambiarEstadoUsuario '"+usuario+"'";
                decimal resultado = 0;
                reader = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(exe);
                if (reader.Read()){
                    resultado = reader.GetDecimal(0);
                 }
                /*Si el procedimiento devuelve 1, el usuario pasó a habilitarse, si devuelve 2, a inhabilitarse, y si devuelve 0 hubo un error*/
                if (resultado == 1) MessageBox.Show("El usuario se encuentra ahora HABILITADO.", "Estado cambiado");
                if (resultado == 0) MessageBox.Show("El usuario se encuentra ahora INHABILITADO.", "Estado cambiado");
                if (resultado == 2) MessageBox.Show("Se produjo un error al cambiar el estado del usuario.", "Error");
                reader.Close();
            }
            else MessageBox.Show("Debe seleccionar un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (checkearCbo())
            {
                SeleccionarHotel frm = new SeleccionarHotel(this, usuario, true);
                this.Hide();
                frm.Show();
            }
            else MessageBox.Show("Debe seleccionar un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (checkearCbo())
            {
                SeleccionarHotel frm = new SeleccionarHotel(this, usuario, false);
                this.Hide();
                frm.Show();
            }
            else MessageBox.Show("Debe seleccionar un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        
    }
}
