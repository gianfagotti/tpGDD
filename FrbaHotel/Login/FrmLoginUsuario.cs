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
        public FrmLoginUsuario(){
            InitializeComponent();
        }
     
        SqlConnection conexion = new SqlConnection("Data Source=.\\SQLSERVER2012;Initial Catalog=GD1C2018;user=gdHotel2018;password=gd2018");

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
                MessageBox.Show("Debe completar el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string usuarioIngresado = this.txtUsuario.Text;
                SqlCommand validarUsuario = new SqlCommand("SELECT usuario_username, usuario_estado FROM FAGD.Usuario WHERE usuario_username = @usuario", conexion);
                validarUsuario.Parameters.AddWithValue("usuario", usuarioIngresado);
                SqlDataAdapter adaptador = new SqlDataAdapter(validarUsuario);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                if (tabla.Rows.Count == 1 && (bool)tabla.Rows[0][1])
                {
                    this.Close();
                    FrmLoginContraseña frmLoginContraseña = new FrmLoginContraseña(usuarioIngresado);
                    frmLoginContraseña.Show();

                }
                else
                {
                    if (tabla.Rows.Count == 1 && !(bool)tabla.Rows[0][1])
                    {
                        MessageBox.Show("Usuario inhabilitado, contáctese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void lblDatosUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}