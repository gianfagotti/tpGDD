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
    public partial class FrmHuespedxHabitacion : Form
    {
        string query;
        SqlDataReader infoQuery;
        DataTable tablaConInfoHuespedes;
        string estadia;
        Form formAVolver;


        public FrmHuespedxHabitacion(DataTable tablaHuespedes, string reservaCodigo, string nroEstadia, Form menu)
        {
            InitializeComponent();
            tablaConInfoHuespedes = tablaHuespedes;
            estadia = nroEstadia;
            formAVolver = menu;
            dgvDistri.DataSource = tablaConInfoHuespedes;
            query = "SELECT habitacion_codigo FROM FAGD.ReservaXHabitacion WHERE reserva_codigo = " + reservaCodigo;
            infoQuery = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(query);
            while(infoQuery.Read())
            {
                cbohab.Items.Add(infoQuery.GetDecimal(0));
            }
            infoQuery.Close();   

        }


        private void DistribClientes_Load(object sender, EventArgs e)
        {

        }

        private void cbohab_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se debe elegir la habitacion y en base a eso rellenar los demas textbox con la informacion adicional
            query = "SELECT ha.habitacion_nro, ha.habitacion_piso, tipoHa.habitacionTipo_descripcion, tipoHa.habitacionTipo_cantHuespedes FROM FAGD.Habitacion ha, FAGD.HabitacionTipo tipoHa WHERE ha.habitacion_tipoCodigo = tipoHa.habitacionTipo_codigo AND ha.habitacion_codigo = " + cbohab.Text;
            infoQuery = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(query);
            if (infoQuery.Read())
            {
                txtnroHab.Text = infoQuery.GetDecimal(0).ToString();
                txtPiso.Text = infoQuery.GetDecimal(1).ToString();
                txtTipo.Text = infoQuery.GetString(2);
                txtCantHab.Text = infoQuery.GetDecimal(3).ToString();
            }
            else
            {
                MessageBox.Show("La habitación asignada ya no existe en el hotel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            infoQuery.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (tablaConInfoHuespedes.Rows.Count == 0)
            {
                this.Close();
                formAVolver.Show();
            }
            else
            {
                MessageBox.Show("No pueden quedar huéspedes sin una habitación asignada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDistri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (Convert.ToInt32(cbohab.SelectedIndex) == -1)
                {
                    MessageBox.Show("Debe seleccionar una habitación para asignarle al huésped.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                
                if (MessageBox.Show("¿Está seguro de agregar el cliente a la habitación seleccionada? Esta acción no se puede deshacer.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    
                    int index = dgvDistri.CurrentRow.Index;
                    query = "SELECT COUNT(*) FROM FAGD.ClienteXEstadia WHERE estadia_codigo = " + estadia + " AND habitacion_codigo = " + cbohab.Text;
                    infoQuery = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(query);
                    infoQuery.Read();
                    int cantLimite = infoQuery.GetInt32(0);
                    infoQuery.Close();
                    //Se revisa que el límite de huespedes en la habitacion no sea superado
                    if (cantLimite < Convert.ToInt32(txtCantHab.Text))
                    {//Se da lugar a la accion de registrar el cliente para la estadia en la habitacion particular seleccionada con confirmación
                        query = "EXEC FAGD.SeleccionarHabitacionDeCliente " + cbohab.Text + "," + dgvDistri.CurrentRow.Cells[1].Value.ToString() + "," + estadia;
                        infoQuery = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(query);
                        infoQuery.Read();
                        if (infoQuery.GetDecimal(0) == 1)
                        {
                            MessageBox.Show("El huésped se ha registrado correctamente a la habitación.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tablaConInfoHuespedes.Rows.RemoveAt(index);
                            dgvDistri.DataSource = tablaConInfoHuespedes;
                            infoQuery.Close();
                            this.Close();
                        }
                        else
                        {
                            infoQuery.Close();
                            MessageBox.Show("El cliente elegido ya se encuentra agregado a esta estadía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esa habitación ya se encuentra llena.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    return;
                }
            }
        }

    }
}
