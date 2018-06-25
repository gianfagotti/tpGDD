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
    public partial class FrmLoginContraseña : Form
    {
        public FrmLoginContraseña(String usuario)
        {
            InitializeComponent();
            usuarioIngresado = usuario;
        }

        SqlConnection conexion = new SqlConnection("Data Source=.\\SQLSERVER2012;Initial Catalog=GD1C2018;user=gdHotel2018;password=gd2018");
        int intentos = 0;

        private void btnIngresarContraseña_Click(object sender, EventArgs e)
        {
            if (this.txtContraseña.Text == "")
            {
                MessageBox.Show("Debe completar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string contraseñaIngresada = this.txtContraseña.Text;
                SqlCommand validarContraseña = new SqlCommand("SELECT usuario_username, usuario_password, usuario_estado FROM FAGD.Usuario WHERE usuario_password = @contraseña AND usuario_username = @usuario", conexion);
                validarContraseña.Parameters.AddWithValue("contraseña", contraseñaIngresada);
                validarContraseña.Parameters.AddWithValue("usuario", usuarioIngresado);
                SqlDataAdapter adaptador = new SqlDataAdapter(validarContraseña);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                if (tabla.Rows.Count == 1)
                {
                    this.Close();
                    FrmSeleccionarHotel frmSeleccionarHotel = new FrmSeleccionarHotel(usuarioIngresado.ToString());
                    frmSeleccionarHotel.Show();
                }
                else
                {
                    intentos++;
                    if (intentos < 3)
                    {
                        MessageBox.Show("Contraseña incorrecta, realizó " + intentos +"/3 intentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("cantidad de intentos agotada, su usuario pasará a estar inhabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                        FrmTipoUsuario frmTipoUsuario = new FrmTipoUsuario();
                        frmTipoUsuario.Show();
                        //ACA VA EL UPDATE EN EL ESTADO DEL USUARIO, FALTA HACER LUEGO
                    }
                }
            }
        }

        private void BtnVolverContraseña_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTipoUsuario frmTipoUsuario = new FrmTipoUsuario();
            frmTipoUsuario.Show();
        }

        public object usuarioIngresado { get; set; }
    }
}
