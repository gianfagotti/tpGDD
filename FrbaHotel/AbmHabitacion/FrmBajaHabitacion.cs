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
            //Asigno formulario anterior
            frmMenuEmpleado = frm;
            //Obtengo el codigo del hotel al que se inicio sesión
            codigoHotel = Login.FrmSeleccionarHotel.codigoHotel;
            limpiarCampos();
            resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("SELECT DISTINCT habitacionTipo_descripcion FROM FAGD.HabitacionTipo");
            while (resultado.Read() == true)
            {
                //Agrego todos los tipos de habitación al combo box
                cboTipo.Items.Add(resultado.GetSqlString(0));
            }
            resultado.Close();

            resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("SELECT DISTINCT habitacion_ubicacion FROM FAGD.Habitacion");
            while (resultado.Read() == true)
            {
                //Agrego todas las ubicaciones al combo box
                cboUbicacion.Items.Add(resultado.GetSqlString(0));
            }
            resultado.Close();
            chkHabilitado.Checked = true;
            txtNumero.Focus();
        }

        private void FrmBajaHabitacion_Load(object sender, EventArgs e)
        {
            //Cargo la data griv con todas las habitación del hotel al que se inicio sesión
            consulta = "SELECT H.habitacion_nro Numero, H.habitacion_piso Piso, H.habitacion_ubicacion Ubicacion, H.habitacion_descripcion Descripcion, H.habitacion_estado Estado, T.habitacionTipo_descripcion Tipo FROM FAGD.Habitacion H, FAGD.HabitacionTipo T, FAGD.Hotel Ho WHERE Ho.hotel_codigo = H.habitacion_codigoHotel AND H.habitacion_tipoCodigo = T.habitacionTipo_codigo AND H.habitacion_codigoHotel = " + codigoHotel + "order by H.habitacion_nro";

            adaptadorSql = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataAdapter(consulta);
            tablaConDatos = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataTable(adaptadorSql);

            BindingSource bSource = new BindingSource();

            bSource.DataSource = tablaConDatos;
            dgvFiltrado.DataSource = bSource;
        }

        private void FrmBajaHabitacion_Activated(object sender, EventArgs e)
        {
            consulta = "SELECT H.habitacion_nro Numero, H.habitacion_piso Piso, H.habitacion_ubicacion Ubicacion, H.habitacion_descripcion Descripcion, H.habitacion_estado Estado, T.habitacionTipo_descripcion Tipo FROM FAGD.Habitacion H, FAGD.HabitacionTipo T, FAGD.Hotel Ho WHERE Ho.hotel_codigo = H.habitacion_codigoHotel AND H.habitacion_tipoCodigo = T.habitacionTipo_codigo AND H.habitacion_codigoHotel = " + codigoHotel + "order by H.habitacion_nro";


            adaptadorSql = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataAdapter(consulta);
            tablaConDatos = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataTable(adaptadorSql);

            BindingSource bSource = new BindingSource();

            bSource.DataSource = tablaConDatos;
            dgvFiltrado.DataSource = bSource;
        }

        private void limpiarCampos()
        {
            //Vacio todos los campos
            txtNumero.Text = string.Empty;
            txtPiso.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cboTipo.SelectedIndex = -1;
            cboUbicacion.SelectedIndex = -1;
            chkHabilitado.Checked = false;
            txtNumero.Focus();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.Show();
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            //Filtro por todos los campos completados
            DataView dvData = new DataView(tablaConDatos);
            string query = "";

            query = query + funcionesGlobales.filtrarExactamentePor("Numero", txtNumero.Text);
            query = query + funcionesGlobales.filtrarExactamentePor("Piso", txtPiso.Text);
            query = query + funcionesGlobales.filtrarExactamentePor("Ubicacion", cboUbicacion.Text);
            query = query + funcionesGlobales.filtrarExactamentePor("Tipo", cboTipo.Text);
            query = query + funcionesGlobales.filtrarAproximadamentePor("Descripcion", txtDescripcion.Text);


            if (query.Length > 0) { query = query.Remove(query.Length - 4); }
            dvData.RowFilter = query;
            dgvFiltrado.DataSource = dvData;
        }

        private void dgvFiltrado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Cuando selecciona una habitación
            if (e.ColumnIndex == 0)
            {
                //Valido que no este dada de baja ya
                if (dgvFiltrado.CurrentRow.Cells[5].Value.ToString() == "False")
                {
                    MessageBox.Show("La habitación ya esta inhabilitada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Obtengo el número de habitación
                string nroHabitacion = dgvFiltrado.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show("Estas seguro que desea inhabilitar la habitación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Inhabilito la habitación
                    consulta = "update FAGD.Habitacion set habitacion_estado=0 where habitacion_nro = " + nroHabitacion + " AND habitacion_codigoHotel = " + codigoHotel;

                    resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(consulta);
                    if (resultado.Read() == true)
                    {
                    }
                    resultado.Close();
                    MessageBox.Show("La habitación fue modificada satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tablaConDatos = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataTable(adaptadorSql);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = tablaConDatos;
                dgvFiltrado.DataSource = bSource;
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
