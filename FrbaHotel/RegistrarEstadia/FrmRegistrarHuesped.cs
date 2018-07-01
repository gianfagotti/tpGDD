﻿using System;
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
        decimal dniCli = 0;
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
            tabla.Columns.Add("Dni");
            DataColumn column = tabla.Columns["Dni"];
            column.Unique = true;
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            bSource2 = new BindingSource();
            bSource2.DataSource = tabla;
            dgvHuesped.DataSource = bSource2;
            consulta = "SELECT SUM(tipoHa.cantPersonas) FROM FAGD.ReservaXHabitacion resxh, FAGD.Habitacion ha, FAGD.TipoHabitacion tipoHa WHERE tipoHa.habitacion_codigo = ha.habitacion_codigo AND tipoHa.habitacionTipo_codigo=ha.tipo AND resxh.reserva_codigo = " + nroReserva;
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
            consulta = "SELECT cli.cliente_nroDocumento, cli.cliente_nombre, cli.cliente_apellido FROM FAGD.Reserva res, FAGD.Cliente cli where res.reserva_clienteNroDocumento = cli.cliente_nroDocumento and res.reserva_codigo = " + nroReserva;
            resultado = Login.FrmTipoUsuario.BD.comando(consulta);
            resultado.Read();
            txtTitular.Text = resultado.GetString(2) + " " + resultado.GetString(3);
            persDisp = totalPers - 1;
            txtRest.Text = (persDisp).ToString();
            dniCli = resultado.GetDecimal(0);
            nombre = resultado.GetString(1);
            apellido = resultado.GetString(2);
            DataRow row = tabla.NewRow();
            row["Dni"] = dniCli;
            row["Nombre"] = nombre;
            row["Apellido"] = apellido;
            tabla.Rows.Add(row);
            txtReserv.Text = nroReserva;
            resultado.Close();

        }



        private void FrmRegistrarEstadia_Load(object sender, EventArgs e)
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

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();            
            ultimoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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
            row["dni"] = dniCli;
            row["Nombre"] = nombre;
            row["Apellido"] = apellido;
            tabla.Rows.Add(row);

        }
    }
}