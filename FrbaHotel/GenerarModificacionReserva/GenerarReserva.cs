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
        int dias = 0;
        decimal total = 0;
        decimal precio = 0;
        DateTime fechaDesde;
        DateTime fechaHasta;

        public GenerarReserva(Form form)
        {
            InitializeComponent();
            ultimoFormulario = form;
            dtpDesde.Value = VarGlobales.getDate();
            dtpHasta.Value = VarGlobales.getDate();
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            total = 0;
            txtTotal.Text = "0";
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
            if (Login.FrmTipoUsuario.usuario == "guest")
            {
                cboHotel.ResetText();
                cboHotel.Enabled = true;
            }
            else 
            {
                cboHotel.Enabled = false;
            }
            cboRegimen.ResetText();
            cboTipoHabitacion.ResetText();
            txtCliente.ResetText();
            dtpDesde.ResetText();
            dtpHasta.ResetText();
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = bSource2;
            cant = 0;
            table2.Clear();
            total = 0;
            txtTotal.Text = "0";
            cboTipoHabitacion.Enabled = true;
            cboRegimen.Enabled = true;
            dtpDesde.Enabled = true;
            dtpHasta.Enabled = true;
            dtpDesde.Value = VarGlobales.getDate();
            dtpHasta.Value = VarGlobales.getDate();

        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {
            //clienteSeleccionado = "";

            if (Login.FrmTipoUsuario.usuario == "guest")
            {
                cboHotel.Enabled = true;

                tabla = Login.FrmTipoUsuario.BD.consulta("SELECT DISTINCT hotel_codigo, hotel_calle, hotel_nroCalle, hotel_nombre FROM FAGD.Hotel where hotel_estado = 1");
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
                cboHotel.Items.Add(Login.FrmSeleccionarHotel.hotelSeleccionado);
                cboHotel.SelectedIndex = 0;

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

            fechaDesde = Convert.ToDateTime(dtpDesde.Value);
            fechaHasta = Convert.ToDateTime(dtpHasta.Value);

            int result = DateTime.Compare(fechaDesde, fechaHasta);
            if (result >= 0)
            {

                MessageBox.Show("La fecha desde debe ser menor a la fecha hasta\n");
                return;
            }
            result = DateTime.Compare(fechaDesde.Date, VarGlobales.getDate());
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

            dias = dtpHasta.Value.Date.Subtract(dtpDesde.Value.Date).Days;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DateTime inicio = Convert.ToDateTime(dtpDesde.Value);
                DateTime fin = Convert.ToDateTime(dtpHasta.Value);
                if (DateTime.Compare(fechaDesde, inicio) == 0 && DateTime.Compare(fin, fechaHasta) == 0)
                {
                    string id = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string regimen = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    

                    DataRow row = table2.NewRow();
                    row["Id"] = id;
                    try
                    {
                        precio = (((decimal)dataGridView1.CurrentRow.Cells[3].Value) * dias);
                        row["Precio"] = precio.ToString();

                    }
                    catch { return; }

                    try
                    {
                        table2.Rows.Add(row);
                        if (cant == 0)
                        {
                            cboHotel.Enabled = false;
                            dtpDesde.Enabled = false;
                            dtpHasta.Enabled = false;
                            cboRegimen.Text = regimen;
                            cboRegimen.Enabled = false;
                        }
                        
                        total += (((decimal)dataGridView1.CurrentRow.Cells[3].Value) * dias);
                        txtTotal.Text = total.ToString();
                        cant++;
                        dataGridView2.DataSource = bSource2;
                        butSeleccionar_Click(null, null);
                    }
                    catch
                    {
                        MessageBox.Show("Esa habitación ya fue agregada");
                        return;
                    }
                }
                else 
                {
                    MessageBox.Show("Por favor, vuelva a buscar habitación si cambio la fecha");
                }
                
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) 
            {
                try
                {
                    int item = dataGridView2.CurrentRow.Index;
                    dataGridView2.Rows.RemoveAt(item);
                    cant--;

                    if (cant == 0)
                    {
                        cboHotel.Enabled = true;
                        dtpDesde.Enabled = true;
                        dtpHasta.Enabled = true;
                        cboRegimen.Enabled = true;
                        dataGridView2.DataSource = bSource2;
                    }
                    decimal precio = (((decimal)dataGridView1.CurrentRow.Cells[3].Value) * dias);
                    total -= precio;
                    txtTotal.Text = total.ToString();
                }
                catch { return; }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigoHabitacion = "";

            if (cant == 0)
            {
                MessageBox.Show("Seleccione al menos una habitación");
                return;
            }

            if (string.IsNullOrEmpty(txtCliente.Text))
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }

            bool habilitado = false;

            resultado = Login.FrmTipoUsuario.BD.comando("select cliente_estado from FAGD.Cliente where cliente_codigo = " + txtCliente.Text);
            if (resultado.Read())
                habilitado = resultado.GetBoolean(0);

            resultado.Close();

            if (habilitado == false)
            {
                MessageBox.Show("El cliente esta inhabilitado para realizar reservas");
                return;
            }
            double ab = (dtpHasta.Value - dtpDesde.Value).TotalDays;

            string command = "EXEC FAGD.InsertarNuevaReserva ";
            command = command + "'" + VarGlobales.getDate().ToString("yyyyMMdd HH:mm:ss") + "',";
            command = command + "'" + dtpDesde.Value.Date.ToString("yyyyMMdd HH:mm:ss") + "',";
            command = command + "'" + dtpHasta.Value.Date.ToString("yyyyMMdd HH:mm:ss") + "',";
            
            command = command + ab.ToString() + ",";
            command = command + "'" + cboRegimen.Text + "',";
            command = command + txtCliente.Text + ",";
            if (Login.FrmTipoUsuario.usuario == "guest")
            {
                command = command + "'GUEST',";
                command = command + codHotelSeleccionado + ",";
            }
            else
            {
                command = command + "'" + Login.FrmLoginUsuario.username + "',";
                command = command + Login.FrmSeleccionarHotel.codigoHotel + ",";
            }
            command = command + Convert.ToInt32(total).ToString();

            decimal id = 0;
            resultado = Login.FrmTipoUsuario.BD.comando(command);
            if (resultado.Read() == true)
            {
                id = resultado.GetDecimal(0);
            }
            resultado.Close();

            if (id == 0)
            {
                MessageBox.Show("No se pudo generar la reserva");
                butLimpiar_Click(null, null);
                return;
            }

            string insertar = "EXEC FAGD.InsertarReservaXHabitacion " + id.ToString() + ",";

            for (int i = 0; i < cant; i++)
            {
                codigoHabitacion = dataGridView2.Rows[i].Cells[1].Value.ToString();
                resultado = Login.FrmTipoUsuario.BD.comando(insertar + codigoHabitacion);

                if (!resultado.Read() || resultado.GetDecimal(0) == 0)
                {
                    MessageBox.Show("No se pudo ingresar la habitación: " + codigoHabitacion.ToString());
                    resultado.Close();
                    return;
                }
                resultado.Close();
            }

            MessageBox.Show("Reserva generada con éxito, su número de reserva es: " + id.ToString());
            butLimpiar_Click(null, null);


        }

    }
}
