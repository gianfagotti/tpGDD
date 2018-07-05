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
    
        public static Conector2 BD = new Conector2();
        public static string usuario = "";
        public static DateTime fechaApp = VarGlobales.getDate();
        public static string fechaAppConvertida = fechaApp.Date.ToString("yyyy-MM-dd HH:mm:ss");
        public FrmTipoUsuario()
        {
            InitializeComponent();
            BD.conectar();
            label2.Text = fechaAppConvertida;

            string comandoReservas = "EXEC FAGD.SetearEstadosReservaSegunConfig '" + fechaApp + "'";
            BD.comando(comandoReservas);
        }

        private void btnAceptarTipoUsuario_Click(object sender, EventArgs e)
        {
            if (cmbTiposDeUsuario.SelectedItem != null)
            {
                if (cmbTiposDeUsuario.SelectedItem.ToString() == "Cliente")
                {
                    usuario = "guest";
                    AbmRol.frmMenuCliente frmMenuCliente = new AbmRol.frmMenuCliente();
                    this.Hide();
                    frmMenuCliente.Show();
                }
                else
                {
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
    }
}
