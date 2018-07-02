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
        DateTime diaActual = DateTime.Today;


        public FrmCheckout()
        {
            InitializeComponent();
        
        }

        private string filtrarExactamentePor(string columna, string valor)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                return columna + " = '" + valor + "' AND ";
            }
            return "";
        }

        private void FrmCheckout_Load(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT clieXEst.estadia_codigo estadiaCodigo,  clieXEst.habitacion_codigo habCodigo, ha.habitacion_numero habNumero, ha.habitacion_piso habPiso FROM FAGD.Estadia est, FAGD.ClienteXEstadia cliXEst, FAGD.Habitacion ha WHERE est.estadia_fechaInicio <= '" + diaActual + "' AND cliXEst.estadia_codigo = est.estadia_codigo AND cliXEst.habitacion_codigo = ha.habitacion_codigo AND ha.habitacion_codigoHotel = " + Login.FrmSeleccionarHotel.codigoHotel;
            sAdapter = Login.FrmTipoUsuario.BD.dameDataAdapter(query);
            dTable = Login.FrmTipoUsuario.BD.dameDataTable(sAdapter);
            BindingSource bSource = new BindingSource(); 
            bSource.DataSource = dTable;  
            dgvFinalizar.DataSource = bSource;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataView dvData = new DataView(dTable);
            string query = "";
            query = query + this.filtrarExactamentePor("estadiaCodigo", txtEst.Text);
            query = query + this.filtrarExactamentePor("habCodigo", txthab.Text);
            query = query + this.filtrarExactamentePor("habNumero", txtNrohab.Text);
            query = query + this.filtrarExactamentePor("habPiso", txtPiso.Text);
            if (query.Length > 0) { query = query.Remove(query.Length - 4); }
            dvData.RowFilter = query;
            dgvFinalizar.DataSource = dvData;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
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
                //generar facturacion
                consulta = "EXEC FAGD.CheckoutParaEstadia ";
                consulta = consulta + dgvFinalizar.CurrentRow.Cells[1].Value.ToString();
                consulta = consulta + ",'" + diaActual.ToString("yyyyMMdd HH:mm:ss") + "',";
            //    consulta = consulta + Login.HomeLogin.idUsuario;
                resultado = Login.FrmTipoUsuario.BD.comando(consulta);
                resultado.Read();
                if (resultado.GetDecimal(0) == 1)
                {

                    resultado.Close();
                    //aca va lo de facturacion
                    /*
                    Facturar_Estadia.Facturacion factu = new FrbaHotel.Facturar_Estadia.Facturacion(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    MessageBox.Show("El checkout se ha realizado correctamente. Se procede a la facturacion");
                    factu.Show(); */
                }
                else
                {
                    resultado.Close();
                    MessageBox.Show("El check-out no se pudo realizar correctamente");
                }
                this.Close();
            }
        }
    }
}
