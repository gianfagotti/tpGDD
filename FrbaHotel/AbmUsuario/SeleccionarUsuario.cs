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

        public SeleccionarUsuario(Form form)
        {
            ultimoForm = form;
            InitializeComponent();
            cargarComboUsuarios();
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
            usuario = cboUsuarios.Text;
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void cargarComboUsuarios()
        {
            String select = "SELECT usuario_username FROM FAGD.Usuario";

            reader = Login.FrmTipoUsuario.BD.comando(select);

            DataTable tabla = new DataTable();
            tabla.Columns.Add("usuario_username", typeof(string));
            tabla.Load(reader);

            cboUsuarios.ValueMember = "usuario_username";
            cboUsuarios.DisplayMember = "usuario_username";
            cboUsuarios.DataSource = tabla;
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private Boolean checkearCbo() {
            if (String.IsNullOrEmpty(usuario))
            {
                return false;
            }
            else return true;
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            String exe = "EXEC FAGD.cambiarEstadoUsuario '"+usuario+"'";
            decimal resultado = 0;
            reader = Login.FrmTipoUsuario.BD.comando(exe);
            if (reader.Read()){
                resultado = reader.GetDecimal(0);
            }
            if (resultado == 1) MessageBox.Show("El usuario se encuentra ahora HABILITADO.", "Estado cambiado");
            if (resultado == 0) MessageBox.Show("El usuario se encuentra ahora INHABILITADO.", "Estado cambiado");
            if (resultado == 2) MessageBox.Show("Se produjo un error al cambiar el estado del usuario.", "Error");
            reader.Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            SeleccionarHotel frm = new SeleccionarHotel(this, usuario, true);
            this.Hide();
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SeleccionarHotel frm = new SeleccionarHotel(this, usuario, false);
            this.Hide();
            frm.Show();
        }



    }
}
