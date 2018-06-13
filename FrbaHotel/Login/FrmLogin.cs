using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

    
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (true) //En este condicional tiene que ir la validacion de que el rol que selecciona el usuario esté registrado en la bd para su usuario.
            {
                this.Close();
                FrmSeleccionarRol frmSeleccionarRol = new FrmSeleccionarRol();
                frmSeleccionarRol.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un rol válido para su usuario");
            }
        }

        private void lblDatosUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
