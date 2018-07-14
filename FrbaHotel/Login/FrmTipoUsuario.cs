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
    public partial class FrmTipoUsuario : Form
    {
    
        public static ConectorBaseDeDatos conexionBaseDeDatos = new ConectorBaseDeDatos();                                  //Se instancia por primera y unica vez la conexion a la base de datos, la cual sera reutilizada en cada formulario que lo necesite.
        public static string usuario = "";
        public static DateTime fechaApp = FechaConfig.getDate();
        public static string fechaAppConvertida = fechaApp.Date.ToString("yyyy-MM-dd HH:mm:ss");                            //Se obtiene la fecha del archivo de configuracion, y se la convierte al formato deseado.
        public FrmTipoUsuario()
        {
            InitializeComponent();
            conexionBaseDeDatos.conectar();
                                                                                                                            //Se actualiza el estado de la reserva segun la fecha del archivo configuración.
            string comandoReservas = "EXEC FAGD.SetearEstadosReservaSegunConfig '" + fechaAppConvertida + "'";
            SqlDataReader resultado = conexionBaseDeDatos.comando(comandoReservas);
            resultado.Close();
        }

        private void btnAceptarTipoUsuario_Click(object sender, EventArgs e)
        {                                                                                                                    //Se valida que se seleccione lo correspondiente del combo box (que se seleccione algo), asi como también el tipo de usuario seleccionado del mismo.
            if (cmbTiposDeUsuario.SelectedItem != null)
            {
                if (cmbTiposDeUsuario.SelectedItem.ToString() == "Cliente")
                {
                    usuario = "guest";
                    AbmRol.frmMenuCliente frmMenuCliente = new AbmRol.frmMenuCliente();
                    this.Hide();
                    frmMenuCliente.Show();                                                                                    //Dependiendo de que tipo de usuario se seleccione, se abriran los formularios correspondientes.
                }
                else
                {
                    usuario = "empleado";
                    FrmLoginUsuario frmLoginUsuario = new FrmLoginUsuario();
                    this.Hide();
                    frmLoginUsuario.Show();
                }
            }
            else 
            MessageBox.Show("Debe Seleccionar algún tipo de usuario","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void FrmTipoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmTipoUsuario_Load(object sender, EventArgs e)
        {

        }

        public static string encriptar(string clave)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(clave);

            System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();     //Se "codea" la funcion de  que va a ser llamada posteriormente en el login para el encryptado de contraseñas.
            byte[] hash = sha256hashstring.ComputeHash(bytes);
            string hashstring = string.Empty;
            foreach (byte x in hash)
            {
                hashstring += String.Format("{0:x2}", x);
            }
            return hashstring;
        }


    }
}
