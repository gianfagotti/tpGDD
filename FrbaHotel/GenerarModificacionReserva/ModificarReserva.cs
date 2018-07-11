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
    public partial class ModificarReserva : Form
    {
        Form abmPadre = new Form();
        SqlDataReader resultado;
        DataTable tabla, tabla2, dTable;
        BindingSource bSource2;
        SqlDataAdapter sAdapter;
        int Fila = 0;
        string hotel, consulta, reservaMod;
        decimal codHotelSeleccionado = 0;
        int cant = 0;
        int dias = 0;
        decimal total = 0;
        decimal precio = 0;
        DateTime fechaDesde;
        DateTime fechaHasta;


        public ModificarReserva(Form form, string codigoReserva)
        {
            InitializeComponent();
            abmPadre = form;
            tabla2 = new DataTable();
            reservaMod = codigoReserva;

            llenarCampos(codigoReserva);
            llenarDataGriv(codigoReserva);
        }

        public void llenarCampos(string reserva)
        {
            consulta = "SELECT reserva_fechaInicio, reserva_FechaFin, reserva_clienteCodigo, reserva_codigoHotel, reserva_costoTotal, regimen_descripcion FROM FAGD.Reserva join FAGD.Regimen on (reserva_codigoRegimen = regimen_codigo) where reserva_codigo = " + reserva;
            resultado = Login.FrmTipoUsuario.BD.comando(consulta);
            if (resultado.Read())
            {
                dtpDesde.Value = resultado.GetDateTime(0);
                dtpHasta.Value = resultado.GetDateTime(1);
                dias = dtpHasta.Value.Date.Subtract(dtpDesde.Value.Date).Days;
                txtCliente.Text = resultado.GetDecimal(2).ToString();
                hotel = resultado.GetDecimal(3).ToString();
                txtTotal.Text = resultado.GetDecimal(4).ToString();
                total = resultado.GetDecimal(4);
                cboRegimen.Text = resultado.GetString(5);
                resultado.Close();
            }
            else
            {
                resultado.Close();
                MessageBox.Show("Error en la reserva");
                abmPadre.Show();
                this.Shown += new EventHandler(ModificarReserva_CloseOnStart);
            }


            if (Login.FrmTipoUsuario.usuario != "guest")
            {
                if (Login.FrmSeleccionarHotel.codigoHotel.ToString() != hotel)
                {
                    MessageBox.Show("No puedes modificar una reserva para un hotel que no trabajas");
                    abmPadre.Show();
                    this.Shown += new EventHandler(ModificarReserva_CloseOnStart);
                }

                cboHotel.Text = Login.FrmSeleccionarHotel.hotelSeleccionado;
            }
            else
            {
                consulta = "SELECT DISTINCT hotel_codigo, hotel_calle, hotel_nroCalle, hotel_nombre FROM FAGD.Hotel where hotel_estado = 1";
                tabla = Login.FrmTipoUsuario.BD.consulta(consulta);
                while (Fila < tabla.Rows.Count)
                {
                    if (string.IsNullOrEmpty(tabla.Rows[Fila][3].ToString()))
                    {
                        cboHotel.Items.Add(tabla.Rows[Fila][0].ToString() + "-" + tabla.Rows[Fila][1].ToString() + " " + tabla.Rows[Fila][2]);
                        if (tabla.Rows[Fila][0].ToString() == hotel)
                            cboHotel.Text = tabla.Rows[Fila][0].ToString() + "-" + tabla.Rows[Fila][1].ToString() + " " + tabla.Rows[Fila][2];
                    }
                    else
                    {
                        cboHotel.Items.Add(tabla.Rows[Fila][0].ToString() + "-" + tabla.Rows[Fila][3].ToString());
                        if (tabla.Rows[Fila][0].ToString() == hotel)
                            cboHotel.Text = tabla.Rows[Fila][0].ToString() + "-" + tabla.Rows[Fila][3].ToString();
                    }
                    Fila++;
                }
                tabla.Clear();
            }

            cboHotel_SelectedIndexChanged(null, null);
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

        private void ModificarReserva_CloseOnStart(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenarDataGriv(string reserva)
        {
            tabla2.Columns.Add("Id");
            DataColumn column = tabla2.Columns["Id"];
            column.Unique = true;
            tabla2.Columns.Add("Precio");

            consulta = "EXEC FAGD.BuscarHabitacionesReservadas " + reserva;
            resultado = Login.FrmTipoUsuario.BD.comando(consulta);

            while (resultado.Read())
            {
                DataRow row = tabla2.NewRow();
                row["Id"] = resultado.GetDecimal(0).ToString();
                precio = resultado.GetDecimal(1) * dias;
                row["Precio"] = precio.ToString();
                tabla2.Rows.Add(row);
                cant++;
            }
            resultado.Close();

            bSource2 = new BindingSource();
            bSource2.DataSource = tabla2;
            dataGridView2.DataSource = bSource2;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            abmPadre.Show();
            this.Close();
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


                    DataRow row = tabla2.NewRow();
                    row["Id"] = id;
                    try
                    {
                        precio = (((decimal)dataGridView1.CurrentRow.Cells[3].Value) * dias);
                        row["Precio"] = precio.ToString();

                    }
                    catch { return; }

                    try
                    {
                        tabla2.Rows.Add(row);
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

            string command = "EXEC FAGD.ModificarReserva ";
            command = command + reservaMod + ",";
            command = command + "'" + VarGlobales.getDate().ToString("yyyyMMdd HH:mm:ss") + "',";
            command = command + "'" + dtpDesde.Value.Date.ToString("yyyyMMdd HH:mm:ss") + "',";
            command = command + "'" + dtpHasta.Value.Date.ToString("yyyyMMdd HH:mm:ss") + "',";

            command = command + ab.ToString() + ",";
            command = command + "'" + cboRegimen.Text + "',";
            if (Login.FrmTipoUsuario.usuario == "guest")
            {
                command = command + "'GUEST',";
            }
            else
            {
                command = command + "'" + Login.FrmLoginUsuario.username + "',";
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
                MessageBox.Show("No se pudo modificar la reserva");
                butLimpiar_Click(null, null);
                return;
            }

            Login.FrmTipoUsuario.BD.executeOnly("DELETE FROM FAGD.ReservaXHabitacion WHERE reserva_codigo = " + reservaMod);

            string insertar = "EXEC FAGD.InsertarReservaXHabitacion " + reservaMod + ",";

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

            MessageBox.Show("Reserva modificada con éxito, su número de reserva es: " + reservaMod);
            butLimpiar_Click(null, null);


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
            tabla2.Clear();
            total = 0;
            txtTotal.Text = "0";
            cboTipoHabitacion.Enabled = true;
            cboRegimen.Enabled = true;
            dtpDesde.Enabled = true;
            dtpHasta.Enabled = true;
            dtpDesde.Value = VarGlobales.getDate();
            dtpHasta.Value = VarGlobales.getDate();
        }
    }
}


