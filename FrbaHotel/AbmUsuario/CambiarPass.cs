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
    public partial class CambiarPass : Form
    {
        Form ultimoFormulario;
        String usuario;
        SqlDataReader reader;

        public CambiarPass(Form formAnterior, String usuarioSeleccionado)
        {
            ultimoFormulario = formAnterior;
            usuario = usuarioSeleccionado;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ultimoFormulario.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e){
            /*Checkeo que los campos estén llenos*/
            if (checkearCampos()){
                /*Procedo a encriptar ambas contraseñas (nueva y vieja)*/
                string ingresadaVieja = Login.FrmTipoUsuario.encriptar(txtPassVieja.Text);
                string ingresadaNueva = Login.FrmTipoUsuario.encriptar(txtPassNueva.Text);
                string passVieja = string.Empty;

                /*Realizo un select, guardando la password anterior en una variable*/
                string select = "SELECT usuario_password FROM FAGD.Usuario WHERE usuario_username = '" + usuario + "'";
                reader = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(select);

                if (reader.Read()){
                    passVieja = reader.GetString(0);
                    reader.Close();
                    /*Verifico si las contraseña vieja ingresada y la que figura en la BD son iguales*/
                    if (ingresadaVieja == passVieja)
                    {
                        /*Realizo el update a la tabla usuario, cambiando la contraseña vieja por la nueva*/
                        string exe = "UPDATE FAGD.Usuario SET usuario_password = '" + ingresadaNueva + "' WHERE usuario_username = '" + usuario + "'";
                        reader = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(exe);
                        reader.Read();
                        MessageBox.Show("Password cambiada correctamente!","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        reader.Close();
                        ultimoFormulario.Show();
                        this.Close();
                    }
                    else
                    {
                        /*En caso de que la contraseña anterior no coincida con la de la BD*/
                        MessageBox.Show("La clave anterior no es correcta. Vuelva a intentarlo");
                        txtPassVieja.Clear();
                        txtPassNueva.Clear();
                        txtPassVieja.Focus();
                    }
                }
              }
        }

        private bool checkearCampos() {

            if (string.IsNullOrEmpty(txtPassVieja.Text) || string.IsNullOrEmpty(txtPassNueva.Text))
            {
                MessageBox.Show("Por favor, complete ambos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else{
                string passVieja = txtPassVieja.Text;
                string passNueva = txtPassNueva.Text;

                /*Verifico que la pass nueva y la vieja sean distintas*/
                if (passNueva == passVieja){
                    MessageBox.Show("La nueva contraseña no puede ser igual a la anterior", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else{
                    return true;
                }
            }

        }

    }
}
