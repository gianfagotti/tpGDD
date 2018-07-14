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
    public partial class FrmCheckout : Form
    {
        string consulta;
        SqlDataReader resultado;
        SqlDataAdapter sAdapter;
        DataTable dTable;
        AbmRol.frmMenuEmpleado menuAVolver;
        FrmMenuRegEst menuAnterior;

        public FrmCheckout(FrmMenuRegEst menuRegEst, AbmRol.frmMenuEmpleado menu)
        {
            InitializeComponent();
            menuAnterior = menuRegEst;
            menuAVolver = menu;
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

        private void FrmCheckout_Load(object sender, EventArgs e)
        {//Se consulta nuevamente por TODAS las estadias ACTIVAS que aun falta para que concluyan (menores a la fecha del sistema)
            string query = "SELECT DISTINCT clieXEst.estadia_codigo estadiaCodigo,  clieXEst.habitacion_codigo habCodigo, ha.habitacion_nro habNumero, ha.habitacion_piso habPiso FROM FAGD.Estadia est, FAGD.ClienteXEstadia clieXEst, FAGD.Habitacion ha WHERE est.estadia_fechaInicio <= '" + Login.FrmTipoUsuario.fechaAppConvertida + "' AND est.estadia_fechaFin >= '" + Login.FrmTipoUsuario.fechaAppConvertida + "'  AND clieXEst.estadia_codigo = est.estadia_codigo AND clieXEst.habitacion_codigo = ha.habitacion_codigo AND ha.habitacion_codigoHotel = " + Login.FrmSeleccionarHotel.codigoHotel;
            sAdapter = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataAdapter(query);
            dTable = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataTable(sAdapter);
            BindingSource bSource = new BindingSource(); 
            bSource.DataSource = dTable;  
            dgvFinalizar.DataSource = bSource;
            dgvFinalizar.Columns[1].ReadOnly = true;
            dgvFinalizar.Columns[2].ReadOnly = true;
            dgvFinalizar.Columns[3].ReadOnly = true;
            dgvFinalizar.Columns[4].ReadOnly = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //filtrado de estadias
            DataView dvData = new DataView(dTable);
            string query = "";
            query = query + funcionesGlobales.filtrarExactamentePor("estadiaCodigo", txtEst.Text);
            query = query + funcionesGlobales.filtrarExactamentePor("habCodigo", txthab.Text);
            query = query + funcionesGlobales.filtrarExactamentePor("habNumero", txtNrohab.Text);
            query = query + funcionesGlobales.filtrarExactamentePor("habPiso", txtPiso.Text);
            if (query.Length > 0) { query = query.Remove(query.Length - 4); }
            dvData.RowFilter = query;
            dgvFinalizar.DataSource = dvData;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Se limpia por completo los filtros de busqueda
            txtEst.Clear();
            txtNrohab.Clear();
            txtPiso.Clear();
            txthab.Clear();
            txtEst.Focus();
            this.btnBuscar_Click(null, null);
        }

        private void dgvFinalizar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Se intenta comenzar el proceso de facturación tomando como parametros los campos de referencia de la datagridview, la fecha del sistema y el usuario que se logueó para hacer la operación
                consulta = "EXEC FAGD.CheckoutParaEstadia ";
                consulta = consulta + dgvFinalizar.CurrentRow.Cells[1].Value.ToString();
                consulta = consulta + ",'" + Login.FrmTipoUsuario.fechaAppConvertida + "',";
                consulta = consulta + Login.FrmLoginUsuario.username;
                resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(consulta);
                resultado.Read();
                if (resultado.GetDecimal(0) == 1)
                {
                    //Se procede
                    resultado.Close();
                    FacturarEstadia.FrmFacturarEstadia procesoDeFacturacion = new FacturarEstadia.FrmFacturarEstadia(dgvFinalizar.CurrentRow.Cells[1].Value.ToString(),menuAVolver);
                    MessageBox.Show("El checkout se ha realizado correctamente. Se procede a la facturación.","Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    procesoDeFacturacion.Show();
                    this.Close();
                }
                else
                {   //Se detiene
                    resultado.Close();
                    MessageBox.Show("El check-out no se pudo realizar correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}
