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
                MessageBox.Show("Debe completar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                                                                                                                        //Se valida que se haya ingresado alguna contraseña.
            }
            else
            {
                string contraseñaIngresada = Login.FrmTipoUsuario.encriptar(txtContraseña.Text);                                                                                                                                                            //Como la contraseña en la BD se guarda encryptada, es necesario usar la funcion de hash para la contraseña ingresada y guardar lo que genera en una variable.
                tabla = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT usuario_username, usuario_password, usuario_estado FROM FAGD.Usuario WHERE usuario_password = '"+contraseñaIngresada+"' AND usuario_username = '"+usuarioIngresado+"'");  //Se trae de la base de datos aquel registro que cumpla con el username anteriormente ingresado y con la contraseña ahora ingresada y encryptada.
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
                        MessageBox.Show("Contraseña incorrecta, realizó " + intentos +"/3 intentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                                                                                  //Si la contraseña que se ingreso para el usuario anteriormente ingresado, no es la correcta, se aumenta en 1 los intentos realizados.
                    }
                    else
                    {
                        MessageBox.Show("cantidad de intentos agotada, su usuario pasará a estar inhabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                        FrmTipoUsuario frmTipoUsuario = new FrmTipoUsuario();
                        frmTipoUsuario.Show();
                        resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("EXEC FAGD.desactivarUsuario '"+usuarioIngresado+"'");                                                                                                                 //A los 3 intentos, el usuario se inhabilita y se vuelve al formulario inicial.
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

            AbmUsuario.CambiarPass frm = new AbmUsuario.CambiarPass(this, usuarioIngresado.ToString());                                                                                                                                                     //Se le permite al usuario cambiar su contraseña. El funcionamiento del cambio del contraseña esta en ABM Usuario.
            this.Hide();
            frm.Show();
        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }
    }

  


}
