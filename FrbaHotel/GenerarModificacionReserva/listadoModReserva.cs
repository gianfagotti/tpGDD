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

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class listadoModReserva : Form
    {
        Form abmPadre;

        public listadoModReserva(Form form)
        {
            InitializeComponent();
            abmPadre = form;
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNroReserva.Text))
            {
                MessageBox.Show("Debe ingresar un numero de reserva", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SqlDataReader comando = Login.FrmTipoUsuario.BD.comando("select reserva_codigo, reserva_fechaInicio from FAGD.Reserva where reserva_codigo = " + txtNroReserva.Text + " AND reserva_codigo not in (select reservaCancelada_codigoReserva from FAGD.ReservaCancelada)");
            if (comando.Read())
            {
                if ((comando.GetDecimal(0).ToString() == txtNroReserva.Text) && (comando.GetDateTime(1).Date >= VarGlobales.getDate().Date))
                {
                    comando.Close();
                    this.Hide();
                    ModificarReserva modificar = new ModificarReserva(abmPadre, txtNroReserva.Text);
                    modificar.Show();

                }
                else
                {
                    comando.Close();
                    MessageBox.Show("El plazo para modificar la reserva ha vencido", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                comando.Close();
                MessageBox.Show("La reserva no existe o fue cancelada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            abmPadre.Show();
            this.Close();
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




    }
}
