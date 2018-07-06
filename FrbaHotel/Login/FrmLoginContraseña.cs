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
        int intentos = 0;
        private DataTable tabla;
        SqlDataReader resultado;
        private void btnIngresarContraseña_Click(object sender, EventArgs e)
        {
            if (this.txtContraseña.Text == "")
            {
                MessageBox.Show("Debe completar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string contraseñaIngresada = Login.FrmTipoUsuario.encriptar(txtContraseña.Text);
                tabla = Login.FrmTipoUsuario.BD.consulta("SELECT usuario_username, usuario_password, usuario_estado FROM FAGD.Usuario WHERE usuario_password = '"+contraseñaIngresada+"' AND usuario_username = '"+usuarioIngresado+"'");
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
                        resultado = Login.FrmTipoUsuario.BD.comando("EXEC FAGD.desactivarUsuario '"+usuarioIngresado+"'");
                        resultado.Close();
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


        private void btnPass_Click_1(object sender, EventArgs e)
        {

            AbmUsuario.CambiarPass frm = new AbmUsuario.CambiarPass(this, usuarioIngresado.ToString());
            this.Hide();
            frm.Show();
        }
    }

  


}
