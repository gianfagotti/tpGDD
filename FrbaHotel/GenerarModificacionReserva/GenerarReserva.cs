using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.AbmRol;
using System.Data.SqlClient;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class GenerarReserva : Form
    {
        Form ultimoFormulario;
        private DataTable tabla, dTable, table2;
        int Fila = 0;
        BindingSource bSource2;
        private SqlDataReader resultado;
        SqlDataAdapter sAdapter;
        string consulta;
        decimal codHotelSeleccionado;
        public static string clienteSeleccionado = "";
        int cant = 0;
        string habitaciones = "";
        int dias = 0;
        decimal total = 0;

        public GenerarReserva(Form form)
        {
            InitializeComponent();
            ultimoFormulario = form;
            table2 = new DataTable();
            table2.Columns.Add("Id");
            DataColumn column = table2.Columns["Id"];
            column.Unique = true;
            table2.Columns.Add("Precio");
            bSource2 = new BindingSource();
            bSource2.DataSource = table2;
            dataGridView2.DataSource = bSource2;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            ultimoFormulario.Show();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            cboHotel.ResetText();
            cboRegimen.ResetText();
            cboTipoHabitacion.ResetText();
            txtCliente.ResetText();
            dtpDesde.ResetText();
            dtpHasta.ResetText();
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {
            //clienteSeleccionado = "";

            if (Login.FrmTipoUsuario.usuario == "guest")
            {
                cboHotel.Enabled = true;

                tabla = Login.FrmTipoUsuario.BD.consulta("SELECT DISTINCT [GD1C2018].[FAGD].[Hotel].[hotel_codigo] ,[hotel_calle],[hotel_nroCalle],[hotel_nombre],usuario_username  FROM [GD1C2018].[FAGD].[Hotel] JOIN [GD1C2018].[FAGD].[UsuarioXRolXHotel] ON([GD1C2018].[FAGD].[Hotel].hotel_codigo = [GD1C2018].[FAGD].[UsuarioXRolXHotel].hotel_codigo) where [GD1C2018].[FAGD].[Hotel].hotel_estado = 1");
                while (Fila < tabla.Rows.Count)
                {
                    if (string.IsNullOrEmpty(tabla.Rows[Fila][3].ToString()))
                    {
                        cboHotel.Items.Add(tabla.Rows[Fila][0].ToString() + "-" + tabla.Rows[Fila][1].ToString() + " " + tabla.Rows[Fila][2]);
                    }
                    else
                    {
                        cboHotel.Items.Add(tabla.Rows[Fila][0].ToString() + "-" + tabla.Rows[Fila][3].ToString());
                    }
                    Fila++;
                }
                tabla.Clear();
            }
            else
            {
                cboHotel.Text = Login.FrmSeleccionarHotel.hotelSeleccionado;

                consulta = "select distinct habitacionTipo_descripcion from FAGD.HabitacionTipo, FAGD.Habitacion, FAGD.Hotel where habitacionTipo_codigo = habitacion_tipoCodigo AND habitacion_codigoHotel = hotel_codigo AND hotel_codigo = " + Login.FrmSeleccionarHotel.codigoHotel;
                resultado = Login.FrmTipoUsuario.BD.comando(consulta);
                cboTipoHabitacion.Items.Clear();
                while (resultado.Read() == true)
                {
                    cboTipoHabitacion.Items.Add(resultado.GetString(0));
                }
                resultado.Close();
                consulta = "select distinct R.regimen_descripcion from FAGD.Regimen R, FAGD.HotelXRegimen H where R.regimen_codigo = H.regimen_codigo AND H.hotel_codigo = " + Login.FrmSeleccionarHotel.codigoHotel;
                resultado = Login.FrmTipoUsuario.BD.comando(consulta);
                cboRegimen.Items.Clear();
                while (resultado.Read() == true)
                {
                    cboRegimen.Items.Add(resultado.GetString(0));
                }
                resultado.Close();
            }
        }

        private void cboHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            codHotelSeleccionado = Convert.ToDecimal(cboHotel.Text.Split('-')[0]);

            consulta = "select distinct habitacionTipo_descripcion from FAGD.HabitacionTipo, FAGD.Habitacion, FAGD.Hotel where habitacionTipo_codigo = habitacion_tipoCodigo AND habitacion_codigoHotel = hotel_codigo AND hotel_codigo = " + codHotelSeleccionado;
            resultado = Login.FrmTipoUsuario.BD.comando(consulta);
            cboTipoHabitacion.Items.Clear();
            while (resultado.Read() == true)
            {
                cboTipoHabitacion.Items.Add(resultado.GetString(0));
            }
            resultado.Close();
            consulta = "select distinct R.regimen_descripcion from FAGD.Regimen R, FAGD.HotelXRegimen H where R.regimen_codigo = H.regimen_codigo AND H.hotel_codigo = " + codHotelSeleccionado;
            resultado = Login.FrmTipoUsuario.BD.comando(consulta);
            cboRegimen.Items.Clear();
            while (resultado.Read() == true)
            {
                cboRegimen.Items.Add(resultado.GetString(0));
            }
            resultado.Close();
        }

        private void butClienteExistente_Click(object sender, EventArgs e)
        {
            BuscarClientes cli = new BuscarClientes(this);
            cli.Show();
        }

        private void GenerarReserva_Activated(object sender, EventArgs e)
        {
            if (clienteSeleccionado != "")
            {
                txtCliente.Text = clienteSeleccionado;
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbmCliente.FrmAltaCliente frmAltaCliente = new AbmCliente.FrmAltaCliente(this);
            frmAltaCliente.Show();
        }

        private void butSeleccionar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;


            if (string.IsNullOrEmpty(cboTipoHabitacion.Text))
            {
                MessageBox.Show("Tiene que especificar un tipo de habitacion");
                return;
            }
            if (string.IsNullOrEmpty(cboTipoHabitacion.Text))
            {
                MessageBox.Show("Tiene que especificar un tipo de habitacion");
                return;
            }
            if (string.IsNullOrEmpty(cboHotel.Text))
            {
                MessageBox.Show("Tiene que especificar un hotel");
                return;
            }
            DateTime fechaDesde = Convert.ToDateTime(dtpDesde.Value);
            DateTime fechaHasta = Convert.ToDateTime(dtpHasta.Value);
            DateTime fechaHoy = DateTime.Now;
            int result = DateTime.Compare(fechaDesde, fechaHasta);
            if (result >= 0)
            {

                MessageBox.Show("La fecha desde debe ser menor a la fecha hasta\n");
                return;
            }
            result = DateTime.Compare(fechaDesde.Date, fechaHoy);
            if (result < 0)
            {
                MessageBox.Show("La fecha desde debe ser mayor a la fecha actual\n");
                return;
            }
            string query = "EXEC FAGD.BuscarHabitacionesDisponibles ";
            query = query + cboHotel.Text.Split('-')[0] + ",";
            query = query + "'" + dtpDesde.Value.Date.ToString("yyyyMMdd HH:mm:ss") + "',";
            query = query + "'" + dtpHasta.Value.Date.ToString("yyyyMMdd HH:mm:ss") + "',";
            if (string.IsNullOrEmpty(cboRegimen.Text))
            {
                query = query + "null,";
            }
            else
            {
                query = query + "'" + cboRegimen.Text + "',";
            }
            query = query + "'" + cboTipoHabitacion.Text + "'";

            sAdapter = Login.FrmTipoUsuario.BD.dameDataAdapter(query);
            dTable = Login.FrmTipoUsuario.BD.dameDataTable(sAdapter);
            //BindingSource to sync DataTable and DataGridView
            BindingSource bSource = new BindingSource();
            //set the BindingSource DataSource
            bSource.DataSource = dTable;
            //set the DataGridView DataSource
            dataGridView1.DataSource = bSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string id = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string precio = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string regimen = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                int item = dataGridView1.CurrentRow.Index;

                DataRow row = table2.NewRow();
                row["Id"] = id;
                row["Precio"] = precio;
                try
                {
                    tabla.Rows.Add(row);
                    if (cant == 0)
                    {
                        habitaciones = habitaciones + id;
                        cboRegimen.Text = regimen;
                        cboTipoHabitacion.Enabled = false;
                        cboHotel.Enabled = false;
                        dtpDesde.Enabled = false;
                        dtpHasta.Enabled = false;
                        dias = dtpHasta.Value.Date.Subtract(dtpDesde.Value.Date).Days;
                    }
                    else
                    {
                        habitaciones = habitaciones + "," + id;
                    }
                    total = total + (((decimal)dataGridView1.CurrentRow.Cells[3].Value) * dias);
                    dataGridView1.Rows.RemoveAt(item);
                    txtTotal.Text = total.ToString();
                    cant++;
                    dataGridView2.DataSource = bSource2;
                    butSeleccionar_Click(null, null);
                }
                catch
                {
                    MessageBox.Show("Esa habitación ya fue agregada");
                }
            }
        }

    }
}
