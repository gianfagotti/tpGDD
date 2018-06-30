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

namespace FrbaHotel.AbmHabitacion
{

    public partial class FrmBajaHabitacion : Form
    {
        Form frmMenuEmpleado;
        SqlDataReader resultado;
        SqlDataAdapter adaptadorSql;
        DataTable tablaConDatos;
        decimal codigoHotel = 0;
        string consulta;

        public FrmBajaHabitacion(Form frm)
        {
            InitializeComponent();
            frmMenuEmpleado = frm;

            codigoHotel = Login.FrmSeleccionarHotel.codigoHotel;
            limpiarCampos();
            resultado = Login.FrmTipoUsuario.BD.comando("SELECT DISTINCT habitacionTipo_descripcion FROM FAGD.HabitacionTipo");
            while (resultado.Read() == true)
            {
                cboTipo.Items.Add(resultado.GetSqlString(0));
            }
            resultado.Close();

            resultado = Login.FrmTipoUsuario.BD.comando("SELECT DISTINCT habitacion_ubicacion FROM FAGD.Habitacion");
            while (resultado.Read() == true)
            {
                cboUbicacion.Items.Add(resultado.GetSqlString(0));
            }
            resultado.Close();
            chkHabilitado.Checked = true;
            txtNumero.Focus();
        }

        private void FrmBajaHabitacion_Load(object sender, EventArgs e)
        {
            consulta = "SELECT H.habitacion_nro Numero, H.habitacion_piso Piso, H.habitacion_ubicacion Ubicacion, H.habitacion_descripcion Descripcion, H.habitacion_estado Estado, T.habitacionTipo_descripcion Tipo FROM FAGD.Habitacion H, FAGD.HabitacionTipo T, FAGD.Hotel Ho WHERE Ho.hotel_codigo = H.habitacion_codigoHotel AND H.habitacion_tipoCodigo = T.habitacionTipo_codigo AND H.habitacion_codigoHotel = " + codigoHotel;

            adaptadorSql = Login.FrmTipoUsuario.BD.dameDataAdapter(consulta);
            tablaConDatos = Login.FrmTipoUsuario.BD.dameDataTable(adaptadorSql);

            BindingSource bSource = new BindingSource();

            bSource.DataSource = tablaConDatos;
            dgvFiltrado.DataSource = bSource;
        }

        private void FrmBajaHabitacion_Activated(object sender, EventArgs e)
        {
            consulta = "SELECT H.habitacion_nro Numero, H.habitacion_piso Piso, H.habitacion_ubicacion Ubicacion, H.habitacion_descripcion Descripcion, H.habitacion_estado Estado, T.habitacionTipo_descripcion Tipo FROM FAGD.Habitacion H, FAGD.HabitacionTipo T, FAGD.Hotel Ho WHERE Ho.hotel_codigo = H.habitacion_codigoHotel AND H.habitacion_tipoCodigo = T.habitacionTipo_codigo AND H.habitacion_codigoHotel = " + codigoHotel;


            adaptadorSql = Login.FrmTipoUsuario.BD.dameDataAdapter(consulta);
            tablaConDatos = Login.FrmTipoUsuario.BD.dameDataTable(adaptadorSql);

            BindingSource bSource = new BindingSource();

            bSource.DataSource = tablaConDatos;
            dgvFiltrado.DataSource = bSource;
        }

        private void limpiarCampos()
        {
            txtNumero.Text = string.Empty;
            txtPiso.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cboTipo.ResetText();
            cboUbicacion.ResetText();
            chkHabilitado.Checked = false;
            txtNumero.Focus();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.Show();
        }

        private string filtrarExactamentePor(string columna, string valor)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                return columna + " = '" + valor + "' AND ";
            }
            return "";
        }

        private string filtrarAproximadamentePor(string columna, string valor)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                return columna + " LIKE '%" + valor + "%' AND ";
            }
            return "";
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            DataView dvData = new DataView(tablaConDatos);
            string query = "";

            query = query + this.filtrarExactamentePor("Numero", txtNumero.Text);
            query = query + this.filtrarExactamentePor("Piso", txtPiso.Text);
            query = query + this.filtrarExactamentePor("Ubicacion", cboUbicacion.Text);
            query = query + this.filtrarExactamentePor("Tipo", cboTipo.Text);
            query = query + this.filtrarAproximadamentePor("Descripcion", txtDescripcion.Text);


            if (query.Length > 0) { query = query.Remove(query.Length - 4); }
            dvData.RowFilter = query;
            dgvFiltrado.DataSource = dvData;
        }

        private void dgvFiltrado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dgvFiltrado.CurrentRow.Cells[5].Value.ToString() == "False")
                {
                    MessageBox.Show("La habitación ya esta inhabilitada");
                    return;
                }
                string nroHabitacion = dgvFiltrado.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show("Estas seguro que desea inhabilitar la habitación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    consulta = "update FAGD.Habitacion set habitacion_estado=0 where habitacion_nro = " + nroHabitacion + " AND habitacion_codigoHotel = " + codigoHotel;

                    resultado = Login.FrmTipoUsuario.BD.comando(consulta);
                    if (resultado.Read() == true)
                    {
                    }
                    resultado.Close();
                }
                tablaConDatos = Login.FrmTipoUsuario.BD.dameDataTable(adaptadorSql);
                //BindingSource to sync DataTable and DataGridView
                BindingSource bSource = new BindingSource();
                //set the BindingSource DataSource
                bSource.DataSource = tablaConDatos;
                //set the DataGridView DataSource
                dgvFiltrado.DataSource = bSource;
            }
        }

        
        
    }
}
