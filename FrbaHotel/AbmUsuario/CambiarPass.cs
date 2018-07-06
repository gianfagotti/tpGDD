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

            if (checkearCampos()){
                string ingresadaVieja = Login.FrmTipoUsuario.encriptar(txtPassVieja.Text);
                string ingresadaNueva = Login.FrmTipoUsuario.encriptar(txtPassNueva.Text);
                string passVieja = string.Empty;
                string select = "SELECT usuario_password FROM FAGD.Usuario WHERE usuario_username = '" + usuario + "'";

                reader = Login.FrmTipoUsuario.BD.comando(select);

                if (reader.Read()){
                    passVieja = reader.GetString(0);
                    reader.Close();
                    if (ingresadaVieja == passVieja)
                    {
                        string exe = "UPDATE FAGD.Usuario SET usuario_password = '" + ingresadaNueva + "' WHERE usuario_username = '" + usuario + "'";
                        reader = Login.FrmTipoUsuario.BD.comando(exe);
                        reader.Read();
                        MessageBox.Show("Password cambiada correctamente!","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        reader.Close();
                        this.Close();
                    }
                    else
                    {
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
