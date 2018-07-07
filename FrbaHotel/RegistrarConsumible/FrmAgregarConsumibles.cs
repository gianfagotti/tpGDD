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
    public partial class FrmAgregarConsumibles : Form
    {
        private SqlDataReader resultadoDeOperacion;
        AbmRol.frmMenuEmpleado frmMenuEmpleado;
        SqlDataAdapter adaptador;
        DataTable tablaConDatosConsum;
        BindingSource bSourceReg;

        public FrmAgregarConsumibles(string estadiaCodigo, string habCodigo, string habNumero, string piso)
        {
            
            InitializeComponent();
            txtCodigoEst.Text = estadiaCodigo;
            txthab.Text = habCodigo;
            txtnroha.Text = habNumero;
            txtpiso.Text = piso;
            tablaConDatosConsum = new DataTable();
            tablaConDatosConsum.Columns.Add("Codigo");
            tablaConDatosConsum.Columns.Add("Precio");
            tablaConDatosConsum.Columns.Add("Descripcion");
            bSourceReg = new BindingSource();
            bSourceReg.DataSource = tablaConDatosConsum;
            dgvRegCons.DataSource = bSourceReg;
        }


        public FrmAgregarConsumibles(AbmRol.frmMenuEmpleado form)
        {
            frmMenuEmpleado = form;
            InitializeComponent();
        }

          private void FrmAgregarConsumibles_Load(object sender, EventArgs e)
        {
            string consultaConsumible = "SELECT consumible_codigo,consumible_descripcion,consumible_precio FROM FAGD.Consumible";
            adaptador = Login.FrmTipoUsuario.BD.dameDataAdapter(consultaConsumible);
            tablaConDatosConsum = Login.FrmTipoUsuario.BD.dameDataTable(adaptador);         
            BindingSource bSourceConsum = new BindingSource();
            bSourceConsum.DataSource = tablaConDatosConsum;    
            dgvCons.DataSource = bSourceConsum;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.ShowDialog();
           
        }

    
        private void dgvCons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string codigoConsu = dgvCons.CurrentRow.Cells[1].Value.ToString();
                string precioConsu = dgvCons.CurrentRow.Cells[2].Value.ToString();
                string descripcionConsu = dgvCons.CurrentRow.Cells[3].Value.ToString();
                DataRow row = tablaConDatosConsum.NewRow();
                row["Codigo"] = codigoConsu;
                row["Precio"] = precioConsu;
                row["Descripcion"] = descripcionConsu;
                tablaConDatosConsum.Rows.Add(row);
                dgvRegCons.DataSource = bSourceReg;
            }

        }

        private void dgvCons_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgregarConsumible_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvRegCons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int consuARemover = dgvRegCons.CurrentRow.Index;
                tablaConDatosConsum.Rows.RemoveAt(consuARemover);
            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (tablaConDatosConsum.Rows.Count == 0)
            {
                MessageBox.Show("Es necesario que seleccione al menos un consumible para agregar.");
                return;
            }
            foreach (DataRow fila in tablaConDatosConsum.Rows)
            {
                resultadoDeOperacion = Login.FrmTipoUsuario.BD.comando("EXEC FAGD.RegistrarConsXEstadiaXHab " + txtCodigoEst.Text + "," + fila["Codigo"].ToString() + "," + txthab.Text);
                if (resultadoDeOperacion.Read())
                {
                    if (resultadoDeOperacion.GetDecimal(0) == 0)
                    {
                        MessageBox.Show("Error. El consumible ya estaba agregado");
                    }
                }
                else
                {
                    MessageBox.Show("Error. El consumible ya estaba agregado");
                }
                resultadoDeOperacion.Close();
            }
            MessageBox.Show("El proceso de carga de consumibles finalizo correctamente");
            this.Close();

        }
      

        }
    }

