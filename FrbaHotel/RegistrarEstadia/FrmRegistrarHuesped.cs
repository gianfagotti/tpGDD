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
        Form ultimoForm;
        private SqlDataReader resultado;
        public static DataTable tabla;
        string nroReserva;
        decimal totalPers = 0;
        string nroEstadia;
        decimal codigoCli = 0;
        string nombre;
        string apellido;
        public static decimal persDisp = 0;
        string consulta;
        BindingSource bSource2;

        public FrmRegistrarHuesped(Form form)
        {
            InitializeComponent();
            ultimoForm = form;

        }

        public FrmRegistrarHuesped(string nroRes, string nroEst)
        {
            InitializeComponent();
            nroReserva = nroRes;
            nroEstadia = nroEst;
            tabla = new DataTable();
            tabla.Columns.Add("codigoCli");
            DataColumn column = tabla.Columns["codigoCli"];
            column.Unique = true;
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            bSource2 = new BindingSource();
            bSource2.DataSource = tabla;
            dgvHuesped.DataSource = bSource2;
            consulta = "SELECT SUM(tipoHa.habitacionTipo_cantHuespedes) FROM FAGD.ReservaXHabitacion resxh, FAGD.Habitacion ha, FAGD.TipoHabitacion tipoHa WHERE tipoHa.habitacion_codigo = ha.habitacion_codigo AND tipoHa.habitacionTipo_codigo=ha.tipo AND resxh.reserva_codigo = " + nroReserva;
            resultado = Login.FrmTipoUsuario.BD.comando(consulta);
            if (resultado.Read())
            {
                txtLimit.Text = resultado.GetDecimal(0).ToString();
                totalPers = resultado.GetDecimal(0);
                resultado.Close();
            }
            else
            {
                resultado.Close();
                MessageBox.Show("La reserva no tiene habitaciones");
                this.Close();
            }
            consulta = "SELECT cli.cliente_codigo CodigoCli, cli.cliente_nombre Nombre, cli.cliente_apellido Apellido FROM FAGD.Reserva res, FAGD.Cliente cli where res.reserva_clienteCodigo = cli.cliente_codigo and res.reserva_codigo = " + nroReserva;
            resultado = Login.FrmTipoUsuario.BD.comando(consulta);
            resultado.Read();
            txtTitular.Text = resultado.GetString(2) + " " + resultado.GetString(3);
            persDisp = totalPers - 1;
            txtRest.Text = (persDisp).ToString();
            //Defino las variables de cada registro consulta
            codigoCli = resultado.GetDecimal(0);
            nombre = resultado.GetString(1);
            apellido = resultado.GetString(2);
            DataRow row = tabla.NewRow();
            row["CodigoCli"] = codigoCli;
            row["Nombre"] = nombre;
            row["Apellido"] = apellido;
            tabla.Rows.Add(row);
            txtReserv.Text = nroReserva;
            resultado.Close();

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
            
            foreach (DataRow fila in tabla.Rows)
            {
                resultado = Login.FrmTipoUsuario.BD.comando("EXEC FAGD.RegistrarEstadiaXCliente " + fila["CodigoCli"].ToString() + "," + nroEstadia);
                if (resultado.Read())
                {
                    if (resultado.GetDecimal(0) == 0)
                    {
                        MessageBox.Show("Error. El cliente ya estaba agregado");
                    }
                }
                else
                {
                    MessageBox.Show("Error. El cliente ya estaba agregado");
                }
                resultado.Close();
            }
            MessageBox.Show("El proceso de carga de clientes finalizo correctamente");
            DistribClientes distri = new DistribClientes(tabla, nroReserva, nroEstadia);
            distri.Show();
            this.Close();
              
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();            
            ultimoForm.Show();
        }

        private void btnRegiCliente_Click(object sender, EventArgs e)
        {
           
            if (persDisp > 0)
            {
                this.Hide();
                AbmCliente.FrmAltaCliente registrarHuesped = new AbmCliente.FrmAltaCliente(this);
                registrarHuesped.Show();
            }
            else
            {
                MessageBox.Show("No se pueden agregar mas clientes para esta estadia");
            }


        }

        private void FrmRegistrarHuesped_Activated(object sender, EventArgs e)
        {
            bSource2.DataSource = tabla;
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
                MessageBox.Show("No se pueden agregar mas clientes para esta estadia");
            }
           
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tabla.Clear();
            persDisp = totalPers - 1;
            DataRow row = tabla.NewRow();
            row["CodigoCli"] = codigoCli;
            row["Nombre"] = nombre;
            row["Apellido"] = apellido;
            tabla.Rows.Add(row);

        }

        private void dgvHuesped_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int item = dgvHuesped.CurrentRow.Index;
                if (dgvHuesped.CurrentRow.Cells[1].Value.ToString() == codigoCli.ToString())
                {
                    MessageBox.Show("No se puede borrar el cliente que hizo la reserva");
                    return;
                }
                persDisp++;
                tabla.Rows.RemoveAt(item);
                dgvHuesped.DataSource = tabla;
            }
        }
    }
}
