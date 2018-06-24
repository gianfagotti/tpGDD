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
    public partial class FrmLogin : Form
    {
        Form abm;
        DataTable tabla;
        public static Conector2 BD = new Conector2();

        public FrmLogin(Form abmPadre){
            InitializeComponent();
            abm = abmPadre;
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
            abm.Show();

        }

        private void btnIngresar_Click(object sender, EventArgs e){
            if (this.txtUsuario.Text == "" || this.txtContraseña.Text == "")
            {
                FrmSeleccionarRol frmSeleccionarRol = new FrmSeleccionarRol();
                frmSeleccionarRol.Show();
                //MessageBox.Show("Debe completar los campos Usuario y Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String nombreIngresado = this.txtUsuario.Text;
                String passwordIngresado = this.txtContraseña.Text;
                BD.conectar();
                tabla = BD.consultaLogin(nombreIngresado, passwordIngresado);
                if (tabla.Rows.Count == 1)
                {
                    this.Close();
                    FrmSeleccionarRol frmSeleccionarRol = new FrmSeleccionarRol();
                    frmSeleccionarRol.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblDatosUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}