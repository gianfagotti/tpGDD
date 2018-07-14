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

namespace FrbaHotel.Login
{
    public partial class FrmLoginUsuario : Form
    {

        public static string username;

        public FrmLoginUsuario(){
            InitializeComponent();
        }

        private DataTable tabla;
      
        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTipoUsuario frmTipoUsuario = new FrmTipoUsuario();
            frmTipoUsuario.Show();

        }

        private void btnIngresarUsuario_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                MessageBox.Show("Debe completar el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                                                       //Se valida que se haya ingresado algo
            }
            else
            {
                string usuarioIngresado = this.txtUsuario.Text;
                tabla = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT usuario_username, usuario_estado FROM FAGD.Usuario WHERE usuario_username = '"+usuarioIngresado+"'"); //Se trae de la base de datos el usuario que cumple con el username ingresado en el textbox.
                if (tabla.Rows.Count == 1 && (bool)tabla.Rows[0][1])
                {
                    username = tabla.Rows[0][0].ToString();
                    this.Close();
                    FrmLoginContraseña frmLoginContraseña = new FrmLoginContraseña(usuarioIngresado);                                                                                   //De haber un usuario en la base de datos con el nombre ingresado en el textbox, el cual esta habilitado, se procede al formulario contraseña.
                    frmLoginContraseña.Show();
                }
                else
                {
                    if (tabla.Rows.Count == 1 && !(bool)tabla.Rows[0][1])
                    {
                        MessageBox.Show("Usuario inhabilitado, contáctese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                  //Si en la base de datos hay un registro cuyo nombre de usuario es el ingresado, pero dicho usuario esta inhabilitado, no se permite loguear.
                    }
                    else {
                        MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                                                     //Si en la base de datos no existe ningun usuario con el nombre ingresado, tampoco se permite loguear.
                    }
                }
            }
        }

        private void lblDatosUsuario_Click(object sender, EventArgs e)
        {

        }

        private void FrmLoginUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}