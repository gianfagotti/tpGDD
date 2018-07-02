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

namespace FrbaHotel.RegistrarEstadia
{
    public partial class DistribClientes : Form
    {
        string consulta;
        SqlDataReader resultado;
        DataTable tabla;
        string estadia;

        public DistribClientes(DataTable tablaP,string nroReserva, string nroEstadia)
        {
            InitializeComponent();
            tabla = tablaP;
            estadia = nroEstadia;
            dgvDistri.DataSource = tabla;
            consulta= "SELECT habitacion_codigo FROM FAGD.ReservaXHabitacion WHERE reserva_codigo = "+nroReserva;
            resultado = Login.FrmTipoUsuario.BD.comando(consulta);
            while( resultado.Read())
            {
                cbohab.Items.Add(resultado.GetDecimal(0));
            }
            resultado.Close();   

        }


        private void DistribClientes_Load(object sender, EventArgs e)
        {

        }

        private void cbohab_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta = "SELECT ha.habitacion_numero, ha.habitacion_piso, tipoHa.habitacionTipo_descripcion, tipoHa.habitacionTipo_cantHuespedes FROM FAGD.Habitacion ha, FAGD.HabitacionTipo tipoHa WHERE ha.habitacion_tipoCodigo = tipoHa.habitacionTipo_codigo AND ha.habitacion_codigo = " + cbohab.Text;
            resultado = Login.FrmTipoUsuario.BD.comando(consulta);
            if (resultado.Read())
            {
                txtnroHab.Text = resultado.GetDecimal(0).ToString();
                txtPiso.Text = resultado.GetDecimal(1).ToString();
                txtTipo.Text = resultado.GetString(2);
                txtCant.Text = resultado.GetDecimal(3).ToString();
            }
            else
            {
                MessageBox.Show("Error la habitacion no existe");
            }
            resultado.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (tabla.Rows.Count == 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe asignar los clientes restantes a una habitacion");
            }
        }

        private void dgvDistri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (Convert.ToInt32(cbohab.SelectedIndex) == -1)
                {
                    MessageBox.Show("Debe seleccionar una habitacion");
                    return;

                }
                int index = dgvDistri.CurrentRow.Index;
                consulta = "SELECT COUNT(*) FROM FAGD.ClienteXEstadia WHERE estadia_codigo = " + estadia + " AND habitacion_codigo = " + cbohab.Text;
                resultado = Login.FrmTipoUsuario.BD.comando(consulta);
                resultado.Read();
                int aux = resultado.GetInt32(0);
                resultado.Close();
                if (aux < Convert.ToInt32(txtCant.Text))
                {
                    consulta = "EXEC FAGD.ModificarClienteXEstadia " + cbohab.Text + "," + dgvDistri.CurrentRow.Cells[1].Value.ToString() + "," + estadia;
                    resultado = Login.FrmTipoUsuario.BD.comando(consulta);
                    resultado.Read();
                    if (resultado.GetDecimal(0) == 1)
                    {
                        MessageBox.Show("El cliente se agrego correctamente");
                        tabla.Rows.RemoveAt(index);
                        dgvDistri.DataSource = tabla;
                        resultado.Close();
                    }
                    else
                    {
                        resultado.Close();
                        MessageBox.Show("El cliente ya estaba agregado a esa estadia");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Esa habitacion ya esta llena");
                }
            }
        }

    }
}
