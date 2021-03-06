﻿using System;
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
    public partial class BuscarClientes : Form
    {
        Form abmPadre;
        SqlDataAdapter sAdapter;
        DataTable dTable;

        public BuscarClientes(Form frm)
        {
            InitializeComponent();
            abmPadre = frm;
            txtNroDoc.Focus();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            txtMail.Clear();
            txtNroDoc.Clear();
            cboTipoDoc.SelectedIndex = -1;
            txtNroDoc.Focus();
            this.butBuscar_Click(null, null);
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            DataView dvData = new DataView(dTable);
            string query = "";

            query = query + funcionesGlobales.filtrarExactamentePor("TipoDoc", cboTipoDoc.Text);

            query = query + funcionesGlobales.filtrarExactamentePor("NroDoc", txtNroDoc.Text);
            query = query + funcionesGlobales.filtrarAproximadamentePor("Mail", txtMail.Text);
            if (query.Length > 0) { query = query.Remove(query.Length - 4); }
            dvData.RowFilter = query;
            dataGridView1.DataSource = dvData;
        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            abmPadre.Show();
        }

        private void BuscarClientes_Load(object sender, EventArgs e)
        {
            string query = "SELECT cliente_codigo CodigoCli, cliente_nombre Nombre,cliente_apellido Apellido,cliente_tipoDocumento TipoDoc,cliente_nroDocumento NroDoc,cliente_mail Mail from FAGD.Cliente";
            sAdapter = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataAdapter(query);
            dTable = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataTable(sAdapter);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dTable;
            dataGridView1.DataSource = bSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Type t = abmPadre.GetType();
                if (t.Equals(typeof(GenerarReserva)))
                {
                    GenerarModificacionReserva.GenerarReserva.clienteSeleccionado = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    GenerarModificacionReserva.GenerarReserva.ActiveForm.Show();
                    this.Close();
                }
                else  {
                    string nombre = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    string apellido = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    string codigoCli = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    DataRow row = RegistrarEstadia.FrmRegistrarHuesped.tablaConInfoClientes.NewRow();
                    row["CodigoCli"] = codigoCli;
                    row["Nombre"] = nombre;
                    row["Apellido"] = apellido;
                    try
                    {
                        RegistrarEstadia.FrmRegistrarHuesped.tablaConInfoClientes.Rows.Add(row);
                        RegistrarEstadia.FrmRegistrarHuesped.persDisp--;
                    }
                    catch
                    {
                        MessageBox.Show("Ese cliente ya esta agregado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    abmPadre.Show();
                    this.Close();
                }
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
