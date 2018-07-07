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

namespace FrbaHotel.RegistrarConsumible
{
    public partial class FrmSeleccionEstadia : Form
    {
        SqlDataAdapter adaptadorSql;
        DataTable tablaConDatosEstadias;
        AbmRol.frmMenuEmpleado frmMenuEmpleado;
       

        public FrmSeleccionEstadia()
        {
            InitializeComponent();
        }

        public FrmSeleccionEstadia(AbmRol.frmMenuEmpleado form)
        {
            frmMenuEmpleado = form;
            InitializeComponent();
        }

        private string filtrarPor(string columna, string valor)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                return columna + " = '" + valor + "' AND ";
            }
            return "";
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoEst.Clear();
            txthab.Clear();
            txtnroha.Clear();
            txtpiso.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void FrmSeleccionEstadia_Load(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT consXEst.estadia_codigo CodigoEstadia, est.habitacion_codigo CodigoHab, ha.habitacion_numero HabNumero, ha.habitacion_piso Piso from FAGD.Estadia est, FAGD.ClienteXEstadia consXEst, FAGD.Habitacion ha WHERE est.estadia_fechaFin IS NULL AND est.estadia_fechaInicio <= '" + Login.FrmTipoUsuario.fechaApp + "' AND consXEst.estadia_codigo = est.estadia_codigo AND consXEst.habitacion_codigo = ha.habitacion_codigo AND ha.habitacion_codigoHotel = " + Login.FrmSeleccionarHotel.codigoHotel;
            adaptadorSql = Login.FrmTipoUsuario.BD.dameDataAdapter(query);
            tablaConDatosEstadias = Login.FrmTipoUsuario.BD.dameDataTable(adaptadorSql);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = tablaConDatosEstadias;
            dgvEstadias.DataSource = bSource;
        }

        private void dgvEstadias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string estadiaCodigo = dgvEstadias.CurrentRow.Cells[1].Value.ToString();
                string habCodigo = dgvEstadias.CurrentRow.Cells[2].Value.ToString();
                string habnumero = dgvEstadias.CurrentRow.Cells[3].Value.ToString();
                string piso = dgvEstadias.CurrentRow.Cells[4].Value.ToString();
                FrmAgregarConsumibles agregarConsu = new FrmAgregarConsumibles(estadiaCodigo, habCodigo, habnumero, piso);
                agregarConsu.Show();
                this.Close();
            }
        }
    }
}
