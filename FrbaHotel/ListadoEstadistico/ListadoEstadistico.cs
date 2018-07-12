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

namespace FrbaHotel.ListadoEstadistico
{
    public partial class ListadoEstadistico : Form
    {
        AbmRol.frmMenuEmpleado frmMenuEmpleado;
        SqlDataAdapter adaptadorSql;
        DataTable tablaConDatos;

        public ListadoEstadistico(AbmRol.frmMenuEmpleado form)
        {
            InitializeComponent();
            frmMenuEmpleado = form;
            cboCateg.Items.Insert(0, "Hotel con mayor cantidad de reservas canceladas");
            cboCateg.Items.Insert(1, "Hotel con mayor cantidad de consumibles facturados");
            cboCateg.Items.Insert(2, "Hotel con mas dias fuera de servicio");
            cboCateg.Items.Insert(3, "Habitacion mayor cantidad de veces ocupada");
            cboCateg.Items.Insert(4, "Cliente con mayor cantidad de puntos");
            cboTrim.Items.Add("1");
            cboTrim.Items.Add("2");
            cboTrim.Items.Add("3");
            cboTrim.Items.Add("4");

        }

        private void frmListadoEstadistico_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrarEstadist_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboCateg.Text))
            {
                MessageBox.Show("Debe seleccionar una categoría a evaluar.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cboTrim.Text))
            {
                MessageBox.Show("Es necesario que especifique el trimestre dentro del cual se evaluará la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(dtpAnio.Text))
            {
                MessageBox.Show("Falta seleccionar el año de evaluación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            String categoriaSeleccionada = "";
            switch (cboCateg.SelectedIndex)
            {
                case 0:
                    categoriaSeleccionada = "EXEC FAGD.ListadoHotelesMayorCantidadReservasCanceladas " + cboTrim.Text + ", " + dtpAnio.Text;
                    break;
                case 1:
                    categoriaSeleccionada = "EXEC FAGD.ListadoHotelesMayorCantidadConsumFacturados " + cboTrim.Text + ", " + dtpAnio.Text;
                    break;
                case 2:
                    categoriaSeleccionada = "EXEC FAGD.ListadoHotelesMayorCantidadDiasDeBaja " + cboTrim.Text + ", " + dtpAnio.Text;
                    break;
                case 3:
                    categoriaSeleccionada = "EXEC FAGD.ListadoHabitacionesMasVecesUtilizadas " + cboTrim.Text + ", " + dtpAnio.Text;
                    break;
                case 4:
                    categoriaSeleccionada = "EXEC FAGD.ListadoClientesConMayoresPuntajes " + cboTrim.Text + ", " + dtpAnio.Text;
                    break;

            }

            adaptadorSql = Login.FrmTipoUsuario.BD.dameDataAdapter(categoriaSeleccionada);
            tablaConDatos = Login.FrmTipoUsuario.BD.dameDataTable(adaptadorSql);
            //Establezo que la dataGridView va a ser alimentada por la tabla virtual del adaptador, siendo la bindSource el puente que las une
            BindingSource bindSource = new BindingSource();
            //Seteo la fuente de la bindSource, la tabla del adaptador
            bindSource.DataSource = tablaConDatos;
            //Seteo la fuente de la dataGridView, la bindSource
            dgvEstadistico.DataSource = bindSource;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.ShowDialog();
        }


    }
}
