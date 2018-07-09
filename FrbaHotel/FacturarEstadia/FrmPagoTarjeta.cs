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

namespace FrbaHotel.FacturarEstadia
{

    public partial class FrmPagoTarjeta : Form
    {
        string facturaAsociada;
        AbmRol.frmMenuEmpleado menuRetorno;

        public FrmPagoTarjeta(string fact, AbmRol.frmMenuEmpleado menu)
        {
            InitializeComponent();
            menuRetorno = menu;
            facturaAsociada = fact;
            cboEntidad.Items.Add("Visa");
            cboEntidad.Items.Add("Mastercard");
            cboEntidad.Items.Add("American Express");
            cboEntidad.Items.Add("Cabal");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnroTarj.Text))
            {
                MessageBox.Show("Falta ingresar el número de tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtBanco.Text))
            {
                MessageBox.Show("Falta ingresar el banco emisor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cboEntidad.Text))
            {
                MessageBox.Show("Es necesario especificar la entidad financiera asociada a la tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtTitu.Text))
            {
                MessageBox.Show("Falta ingresar al titular de la tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "EXEC FAGD.AsociarTarjeta " + facturaAsociada + ",'" + cboEntidad.Text + "'," + txtnroTarj + ",'" + txtBanco.Text + "','" + txtTitu.Text + "'"; 
            SqlDataReader resultado = Login.FrmTipoUsuario.BD.comando(query);
            resultado.Read();
            if (resultado.GetDecimal(0) != 0)
            {
                resultado.Close();
                MessageBox.Show("La tarjeta fue asociada a la factura.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menuRetorno.Show();
                this.Close();
                
                
            }
            else
            {
                resultado.Close();
                MessageBox.Show("La tarjeta ya estaba asociada previamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
              
            }
        }
    }
}
