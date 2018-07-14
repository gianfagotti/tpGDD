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
        SqlDataAdapter adaptador;
        DataTable tablaConDatosConsum;
        DataTable tablaConDatosConsumARegis;
        BindingSource bSourceReg;
        FrmSeleccionEstadia formAnterior;
        AbmRol.frmMenuEmpleado menuAVolver;



        public FrmAgregarConsumibles(string estadiaCodigo, string habCodigo, string habNumero, string piso, FrmSeleccionEstadia selecEst, AbmRol.frmMenuEmpleado menu)
        {
            //Cargado del form con las datatable iniciales y textbox
            InitializeComponent();
            menuAVolver = menu;
            formAnterior = selecEst;
            txtCodigoEst.Text = estadiaCodigo;
            txthab.Text = habCodigo;
            txtnroha.Text = habNumero;
            txtpiso.Text = piso;
            tablaConDatosConsumARegis = new DataTable();
            tablaConDatosConsumARegis.Columns.Add("Codigo");
            tablaConDatosConsumARegis.Columns.Add("Descripcion");
            tablaConDatosConsumARegis.Columns.Add("Precio");
            bSourceReg = new BindingSource();
            bSourceReg.DataSource = tablaConDatosConsumARegis;
            dgvConsReg.DataSource = bSourceReg;
            dgvConsReg.Columns[1].ReadOnly = true;
            dgvConsReg.Columns[2].ReadOnly = true;
            dgvConsReg.Columns[3].ReadOnly = true;
        }


          private void FrmAgregarConsumibles_Load(object sender, EventArgs e)
        {
            //Se llena la datagridview con la informacion de cada consumible en la base a traves del adaptadorSql que returnea la dataTable con los registros 
            string consultaConsumible = "SELECT consumible_codigo Codigo, consumible_descripcion Descripcion, consumible_precio Precio FROM FAGD.Consumible";
            adaptador = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataAdapter(consultaConsumible);
            tablaConDatosConsum = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataTable(adaptador);         
            BindingSource bSourceConsum = new BindingSource();
            bSourceConsum.DataSource = tablaConDatosConsum;    
            dgvCons.DataSource = bSourceConsum;
            dgvCons.Columns[1].ReadOnly = true;
            dgvCons.Columns[2].ReadOnly = true;
            dgvCons.Columns[3].ReadOnly = true;
         
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
            formAnterior.Show();
        }



        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (tablaConDatosConsumARegis.Rows.Count == 0)
            {
                MessageBox.Show("Es necesario que seleccione al menos un consumible para agregar.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("¿Está seguro que desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                //Se adiciona de a 1 consumible por vez y luego se los agrupa en el itemFactura
                foreach (DataRow fila in tablaConDatosConsumARegis.Rows)
                {
                    resultadoDeOperacion = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("EXEC FAGD.RegistrarConsuXEstXHabitacion " + txtCodigoEst.Text + "," + fila["Codigo"].ToString() + "," + txthab.Text);
                    if (resultadoDeOperacion.Read())
                    {
                        if (resultadoDeOperacion.GetDecimal(0) == 0)
                        {
                            MessageBox.Show("El consumible ya estaba agregado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El consumible ya estaba agregado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    resultadoDeOperacion.Close();
                }
                MessageBox.Show("El proceso de carga de consumibles finalizó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                menuAVolver.Show();
            }
            return;
        }


        private void txthab_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoEst_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnroha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpiso_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si se toca la celda de la primer columna de la primer datagridv se adiciona toda la fila al datatable que se vincula a la segunda datagridv
            if (e.ColumnIndex == 0)
            {
                string codigoConsu = dgvCons.CurrentRow.Cells[1].Value.ToString();
                string descripcionConsu = dgvCons.CurrentRow.Cells[2].Value.ToString();
                string precioConsu = dgvCons.CurrentRow.Cells[3].Value.ToString();
                DataRow row = tablaConDatosConsumARegis.NewRow();
                row["Codigo"] = codigoConsu;
                row["Descripcion"] = descripcionConsu;
                row["Precio"] = precioConsu;
                tablaConDatosConsumARegis.Rows.Add(row);
                dgvConsReg.DataSource = bSourceReg;
            }
        }

        private void dgvConsReg_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {//Se quita consumible en particular
                int consuARemover = dgvConsReg.CurrentRow.Index;
                tablaConDatosConsumARegis.Rows.RemoveAt(consuARemover);
            }
        }


 

        }
    }

