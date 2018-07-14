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

namespace FrbaHotel.CancelarReserva
{
    public partial class CancelarReserva : Form
    {
        Form abmPadre = new Form();
        SqlDataReader resultado;
        decimal noShow = 0, xUser = 0, xGuest = 0;

        public CancelarReserva(Form form)
        {
            InitializeComponent();
            abmPadre = form;

            txtCodigoReserva.Focus();

            resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("Select estado_codigo from FAGD.Estado where estado_descripcion = 'RESERVA CANCELADA POR NO-SHOW'");
            resultado.Read();
            noShow = resultado.GetDecimal(0);
            resultado.Close();
            resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("Select estado_codigo from FAGD.Estado where estado_descripcion = 'RESERVA CANCELADA POR RECEPCION'");
            resultado.Read();
            xUser = resultado.GetDecimal(0);
            resultado.Close();
            resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("Select estado_codigo from FAGD.Estado where estado_descripcion = 'RESERVA CANCELADA POR CLIENTE'");
            resultado.Read();
            xGuest = resultado.GetDecimal(0);
            resultado.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            abmPadre.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoReserva.Text))
            {
                MessageBox.Show("Debe ingresar un numero de reserva", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtMotivo.Text))
            {
                MessageBox.Show("Debe ingresar el motivo de la cancelación", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("Select reserva_codigo, reserva_estado, reserva_fechaInicio from FAGD.Reserva where reserva_codigo = " + txtCodigoReserva.Text);
            if (resultado.Read())
            {
                decimal estado = resultado.GetDecimal(1);
                DateTime fechaIncio = resultado.GetDateTime(2);
                resultado.Close();

                if (fechaIncio.Date <= FechaConfig.getDate().Date)
                {
                    MessageBox.Show("La reserva no se puede cancelar porque ya paso el plazo para cancelar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (estado == noShow || estado == xUser || estado == xGuest)
                {
                    MessageBox.Show("La reserva ya se encuentra cancelada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string consulta = "EXEC FAGD.CancelarReserva ";

                consulta = consulta + txtCodigoReserva.Text + ",";
                consulta = consulta +  "'" + txtMotivo.Text + "',";
                consulta = consulta + "'" + FechaConfig.getDate().ToString("yyyyMMdd HH:mm:ss") + "',";
                if (Login.FrmTipoUsuario.usuario == "guest")
                {
                    consulta = consulta + "'GUEST',";
                    consulta = consulta + xGuest;
                }
                else
                {
                    consulta = consulta + "'" + Login.FrmLoginUsuario.username + "',";
                    consulta = consulta + xUser;
                }

                resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(consulta);
                if (resultado.Read())
                {
                    if (resultado.GetDecimal(0) == 1)
                    {
                        MessageBox.Show("La reserva se cancelo correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resultado.Close();
                        abmPadre.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro al cancelar la reserva, ya se encontraba cancelada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultado.Close();
                    }
                }
            }
            else
            {
                resultado.Close();
                MessageBox.Show("Número de reserva invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
