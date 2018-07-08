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
                MessageBox.Show("Debe ingresar un numero de reserva");
                return;
            }
            SqlDataReader comando = Login.FrmTipoUsuario.BD.comando("select reserva_codigo, reserva_fechaInicio from FAGD.Reserva where reserva_codigo = " + txtNroReserva.Text);
            if (comando.Read())
            {
                if ((comando.GetDecimal(0).ToString() == txtNroReserva.Text) && (comando.GetDateTime(1).Date >= VarGlobales.getDate().Date))
                {
                    comando.Close();
                    //ModificarReserva modificar = new ModificarReserva(this, txtNroReserva.Text);
                    //modificar.Show();
                    this.Hide();
                }
                else
                {
                    comando.Close();
                    MessageBox.Show("El plazo para modificar la reserva ha vencido");
                    return;
                }
            }

        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            abmPadre.Show();
            this.Close();
        }

        private void txtNroReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
