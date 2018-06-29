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
        AbmRol.frmMenuEmpleado frmMenuEmpleado;
        SqlDataAdapter adaptador;
        DataTable tablaConDatosConsum;


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
            dataGridView2.DataSource = bSourceConsum;
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

    
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgregarConsumible_Click(object sender, EventArgs e)
        {
            int total = int.Parse(TxtCantidad.Text) * int.Parse(TxtPrecioIndividual.Text);
            dataGridView1.Rows.Add(txtCodigoEst.Text,txtCodigoConsu.Text, TxtPrecioIndividual.Text, txtCodigoEst.Text, TxtCantidad.Text, total);
        }


      
        }
    }

