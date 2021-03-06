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

namespace FrbaHotel.AbmHabitacion
{
    public partial class FrmListadoMod : Form
    {
        Form frmMenuEmpleado;
        private SqlDataReader resultado;
        SqlDataAdapter adaptadorSql;
        DataTable tablaConDatos;
        decimal codigoHotel = 0;

        public FrmListadoMod(Form form)
        {
            InitializeComponent();
            frmMenuEmpleado = form;

            codigoHotel = Login.FrmSeleccionarHotel.codigoHotel;

            resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("SELECT DISTINCT habitacionTipo_descripcion FROM FAGD.HabitacionTipo");
            while (resultado.Read() == true)
            {
                cboTipoHabitacion.Items.Add(resultado.GetSqlString(0));
            }
            resultado.Close();

            resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("SELECT DISTINCT habitacion_ubicacion FROM FAGD.Habitacion");
            while (resultado.Read() == true)
            {
                cboUbicacion.Items.Add(resultado.GetSqlString(0));
            }
            resultado.Close();
            chkHabilitado.Checked = true;
            txtNroHab.Focus();
        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.Show();
        }

        private void limpiarCampos()
        {
            txtNroHab.Text = string.Empty;
            txtPiso.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cboTipoHabitacion.SelectedIndex = -1;
            cboUbicacion.SelectedIndex = -1;
            chkHabilitado.Checked = false;
            txtNroHab.Focus();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT H.habitacion_codigo Codigo, H.habitacion_nro Numero, H.habitacion_piso Piso, H.habitacion_ubicacion Ubicacion, H.habitacion_descripcion Descripcion, H.habitacion_estado Estado, T.habitacionTipo_descripcion as 'Tipo habitación' FROM FAGD.Habitacion H, FAGD.HabitacionTipo T WHERE habitacion_codigoHotel = " + codigoHotel;
            consulta = consulta + "AND H.habitacion_tipoCodigo = T.habitacionTipo_codigo";
            string query = "";

            query = query + funcionesGlobales.filtrarExactamentePor("H.habitacion_nro", txtNroHab.Text);
            query = query + funcionesGlobales.filtrarExactamentePor("H.habitacion_piso", txtPiso.Text);
            query = query + funcionesGlobales.filtrarExactamentePor("H.habitacion_ubicacion", cboUbicacion.Text);
            query = query + funcionesGlobales.filtrarExactamentePor("T.habitacionTipo_descripcion", cboTipoHabitacion.Text);
            query = query + funcionesGlobales.filtrarAproximadamentePor("H.habitacion_descripcion", txtDescripcion.Text);

            if (chkHabilitado.Checked)
            {
                query = query + "H.habitacion_estado = 1 AND";
            }
            else
            {
                query = query + "H.habitacion_estado = 0 AND";
            }

            if (query.Length > 0)
            {
                query = query.Remove(query.Length - 4);
                consulta = consulta + " AND "+ query;
            }
            

            adaptadorSql = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataAdapter(consulta);
            tablaConDatos = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataTable(adaptadorSql);

            BindingSource bSource = new BindingSource();

            bSource.DataSource = tablaConDatos;
            dgvFiltrado.DataSource = bSource;
        }

        private void dgvFiltrado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string codigoHabitacion = dgvFiltrado.CurrentRow.Cells[1].Value.ToString();
                string numero = dgvFiltrado.CurrentRow.Cells[2].Value.ToString();
                string piso = dgvFiltrado.CurrentRow.Cells[3].Value.ToString();
                string ubicacion = dgvFiltrado.CurrentRow.Cells[4].Value.ToString();
                string descripcion = dgvFiltrado.CurrentRow.Cells[5].Value.ToString();
                string estado = dgvFiltrado.CurrentRow.Cells[6].Value.ToString();
                string tipoHabitacion = dgvFiltrado.CurrentRow.Cells[7].Value.ToString();

                decimal id = 0;

                string consulta = "select habitacion_codigo from FAGD.Habitacion where habitacion_nro = " + numero + " and habitacion_codigoHotel = " + codigoHotel;
                resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(consulta);
                if (resultado.Read())
                {
                    id = resultado.GetDecimal(0);
                }
                resultado.Close();

                this.Hide();
                AbmHabitacion.FrmModificarHabitacion frm = new FrmModificarHabitacion(this, id, numero, piso, ubicacion, descripcion, estado, tipoHabitacion);
                frm.Show();
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
