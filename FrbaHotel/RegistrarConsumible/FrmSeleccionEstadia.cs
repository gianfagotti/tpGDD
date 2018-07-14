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
        AbmRol.frmMenuEmpleado menu;
       

        public FrmSeleccionEstadia()
        {
            InitializeComponent();
        }

        public FrmSeleccionEstadia(AbmRol.frmMenuEmpleado form)
        {
            menu = form;
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
            menu.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void FrmSeleccionEstadia_Load(object sender, EventArgs e)
        {
            //Consulta que nos trae todas las estadias ACTIVAS menores a la fecha actual del sistema
            string query = "SELECT DISTINCT clieXEst.estadia_codigo CodigoEstadia, clieXEst.habitacion_codigo CodigoHab, ha.habitacion_nro HabNumero, ha.habitacion_piso Piso FROM FAGD.Estadia est, FAGD.ClienteXEstadia clieXEst, FAGD.Habitacion ha WHERE est.estadia_fechaFin >= '" + Login.FrmTipoUsuario.fechaAppConvertida + "' AND est.estadia_fechaInicio <= '" + Login.FrmTipoUsuario.fechaAppConvertida + "' AND clieXEst.estadia_codigo = est.estadia_codigo AND clieXEst.habitacion_codigo = ha.habitacion_codigo AND ha.habitacion_codigoHotel = " + Login.FrmSeleccionarHotel.codigoHotel;
            adaptadorSql = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataAdapter(query);
            tablaConDatosEstadias = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataTable(adaptadorSql);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = tablaConDatosEstadias;
            dgvEstadias.DataSource = bSource;
        }

        private void dgvEstadias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {//Se registran los datos de la estadia a la que se le cargaran consumiciones
                string estadiaCodigo = dgvEstadias.CurrentRow.Cells[1].Value.ToString();
                string habCodigo = dgvEstadias.CurrentRow.Cells[2].Value.ToString();
                string habnumero = dgvEstadias.CurrentRow.Cells[3].Value.ToString();
                string piso = dgvEstadias.CurrentRow.Cells[4].Value.ToString();
                FrmAgregarConsumibles agregarConsu = new FrmAgregarConsumibles(estadiaCodigo, habCodigo, habnumero, piso,this,menu);
                agregarConsu.Show();
                this.Hide();
            }
        }
    }
}
