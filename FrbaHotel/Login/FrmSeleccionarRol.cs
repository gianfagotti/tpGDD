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

namespace FrbaHotel.Login
{
    public partial class FrmSeleccionarRol : Form
    {
        private SqlDataReader resultado;

        public FrmSeleccionarRol()
        {
            InitializeComponent();
            resultado = Login.FrmTipoUsuario.BD.comando("SELECT DISTINCT rol_nombre FROM FAGD.Rol where rol_nombre != 'cliente'");
            while (resultado.Read() == true)
            {
                cmbRolesRegistrados.Items.Add(resultado.GetSqlString(0));
            }
            resultado.Close();

        }

        private void cmbRolesRegistrados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSeleccionarRol_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverATipoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTipoUsuario frmTipoUsuario = new FrmTipoUsuario();
            frmTipoUsuario.Show();
        }

        private void btnAceptarRol_Click(object sender, EventArgs e)
        {
            string tipoEmpleado = cmbRolesRegistrados.SelectedItem.ToString();
            AbmRol.frmMenuEmpleado frmMenuEmpleado = new AbmRol.frmMenuEmpleado(tipoEmpleado);
            this.Close();            
            frmMenuEmpleado.ShowDialog();
        }
    }
}
