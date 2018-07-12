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
    public partial class FrmRegistrarHuesped : Form
    {
        Form menuAVolver;
        private SqlDataReader infoQuery;
        public static DataTable tablaConInfoClientes;
        string nroReserva;
        decimal totalPers = 0;
        string nroEstadia;
        decimal codigoCli = 0;
        string nombre;
        string apellido;
        public static decimal persDisp = 0;
        string query;
        BindingSource bSource2;

        public FrmRegistrarHuesped(Form form)
        {
            InitializeComponent();
            menuAVolver = form;

        }

        public FrmRegistrarHuesped(string nroRes, string nroEst, Form form)
        {
            InitializeComponent();
            nroReserva = nroRes;
            nroEstadia = nroEst;
            menuAVolver = form;
            tablaConInfoClientes = new DataTable();
            tablaConInfoClientes.Columns.Add("codigoCli");
            DataColumn column = tablaConInfoClientes.Columns["codigoCli"];
            column.Unique = true;
            tablaConInfoClientes.Columns.Add("Nombre");
            tablaConInfoClientes.Columns.Add("Apellido");
            bSource2 = new BindingSource();
            bSource2.DataSource = tablaConInfoClientes;
            dgvHuesped.DataSource = bSource2;
            //Para tener disponible la cantidad de clientes a hospedar
            query = "SELECT SUM(tipoHa.habitacionTipo_cantHuespedes) FROM FAGD.ReservaXHabitacion resxh, FAGD.Habitacion ha, FAGD.HabitacionTipo tipoHa WHERE resxh.habitacion_codigo = ha.habitacion_codigo AND tipoHa.habitacionTipo_codigo = ha.habitacion_tipoCodigo AND resxh.reserva_codigo = " + nroReserva;
            infoQuery = Login.FrmTipoUsuario.BD.comando(query);
            if (infoQuery.Read())
            {
                txtLimit.Text = infoQuery.GetDecimal(0).ToString();
                totalPers = infoQuery.GetDecimal(0);
                infoQuery.Close();
            }
            else
            {
                infoQuery.Close();
                MessageBox.Show("La reserva no tiene habitaciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            query = "SELECT cli.cliente_codigo CodigoCli, cli.cliente_nombre Nombre, cli.cliente_apellido Apellido FROM FAGD.Reserva res, FAGD.Cliente cli where res.reserva_clienteCodigo = cli.cliente_codigo and res.reserva_codigo = " + nroReserva;
            infoQuery = Login.FrmTipoUsuario.BD.comando(query);
            infoQuery.Read();
            txtTitular.Text = infoQuery.GetString(1) + " " + infoQuery.GetString(2);
            persDisp = totalPers - 1;
            txtRest.Text = (persDisp).ToString();
            //Defino las variables de cada registro consulta
            codigoCli = infoQuery.GetDecimal(0);
            nombre = infoQuery.GetString(1);
            apellido = infoQuery.GetString(2);
            DataRow fila = tablaConInfoClientes.NewRow();
            fila["CodigoCli"] = codigoCli;
            fila["Nombre"] = nombre;
            fila["Apellido"] = apellido;
            tablaConInfoClientes.Rows.Add(fila);
            txtReserv.Text = nroReserva;
            infoQuery.Close();
            dgvHuesped.Columns[1].ReadOnly = true;
            dgvHuesped.Columns[2].ReadOnly = true;
            dgvHuesped.Columns[3].ReadOnly = true;
        }



        private void FrmRegistrarHuesped_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void TxtCheckIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCheckOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            
            foreach (DataRow fila in tablaConInfoClientes.Rows)
            {
                infoQuery = Login.FrmTipoUsuario.BD.comando("EXEC FAGD.RegistrarEstadiaXCliente " + fila["CodigoCli"].ToString() + "," + nroEstadia);
                if (infoQuery.Read())
                {
                    if (infoQuery.GetDecimal(0) == 0)
                    {
                        MessageBox.Show("El cliente ya estaba agregado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El cliente ya estaba agregado.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                infoQuery.Close();
            }
            MessageBox.Show("El proceso de carga de clientes finalizó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmHuespedxHabitacion organizarClientes = new FrmHuespedxHabitacion(tablaConInfoClientes, nroReserva, nroEstadia, menuAVolver);
            organizarClientes.Show();
            this.Close();
              
        }


        private void btnRegiCliente_Click(object sender, EventArgs e)
        {
           
            if (persDisp > 0)
            {
                AbmCliente.FrmAltaCliente registrarHuesped = new AbmCliente.FrmAltaCliente(this);
                registrarHuesped.Show();
            }
            else
            {
                MessageBox.Show("No se pueden agregar mas clientes para esta estadía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FrmRegistrarHuesped_Activated(object sender, EventArgs e)
        {
            bSource2.DataSource = tablaConInfoClientes;
            txtRest.Text = persDisp.ToString();
        }

        private void btnSeleCliente_Click(object sender, EventArgs e)
        {
            if (persDisp > 0)
            {
                this.Hide();
                GenerarModificacionReserva.BuscarClientes busquedaCliente = new GenerarModificacionReserva.BuscarClientes(this);
                busquedaCliente.Show();
            }
            else
            {
                MessageBox.Show("No se pueden agregar mas clientes para esta estadía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tablaConInfoClientes.Clear();
            persDisp = totalPers - 1;
            DataRow row = tablaConInfoClientes.NewRow();
            row["CodigoCli"] = codigoCli;
            row["Nombre"] = nombre;
            row["Apellido"] = apellido;
            tablaConInfoClientes.Rows.Add(row);
        }

        private void dgvHuesped_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int item = dgvHuesped.CurrentRow.Index;
                if (dgvHuesped.CurrentRow.Cells[1].Value.ToString() == codigoCli.ToString())
                {
                    MessageBox.Show("No se puede borrar el cliente que hizo la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                persDisp++;
                tablaConInfoClientes.Rows.RemoveAt(item);
                dgvHuesped.DataSource = tablaConInfoClientes;
            }
        }
    }
}
