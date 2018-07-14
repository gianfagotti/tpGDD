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
            cboBank.Items.Add("Banco Francés");
            cboBank.Items.Add("Santander Río");
            cboBank.Items.Add("Banco Comafi");
            cboBank.Items.Add("Supervielle");
            cboBank.Items.Add("Banco Itaú");
            cboBank.Items.Add("Banco Ciudad");
            cboBank.Items.Add("Banco Nación");
            cboBank.Items.Add("HSBC");
            cboBank.Items.Add("Otro");
        }

        private void txtsSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        } 

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnroTarj.Text))
            {
                MessageBox.Show("Falta ingresar el número de tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cboBank.Text))
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
            if (MessageBox.Show("¿Está seguro que ha ingresado los datos correctos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {

                string query = "EXEC FAGD.AsociarTarjetaParaPago " + facturaAsociada + ",'" + cboEntidad.Text + "','" + txtnroTarj.Text + "','" + cboBank.Text + "','" + txtTitu.Text + "'";
                SqlDataReader resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(query);
                resultado.Read();
                if (resultado.GetDecimal(0) != 0)
                {
                    resultado.Close();
                    MessageBox.Show("La tarjeta fue asociada al pago de la factura.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menuRetorno.Show();
                    this.Close();


                }
                else
                {
                    resultado.Close();
                    MessageBox.Show("La tarjeta especificada ya se encontraba asociada manualmente, concluye la facturación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menuRetorno.Show();
                    this.Close();

                }
            }
            return;
        }
    }
}
