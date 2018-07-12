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
            cboTrim.Items.Insert(0,"1");
            cboTrim.Items.Insert(1,"2");
            cboTrim.Items.Insert(2,"3");
            cboTrim.Items.Insert(3,"4");

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
            string trimestreInicio = "";
            string trimestreFin = "";
                switch (cboTrim.SelectedIndex)
            {
                case 0:
                    trimestreInicio = dtpAnio.Text + "-01-01";
                    trimestreFin = dtpAnio.Text + "-03-31";
                    break;
                case 1:
                    trimestreInicio = dtpAnio.Text + "-04-01";
                    trimestreFin = dtpAnio.Text + "-06-30";
                    break;
                case 2:
                    trimestreInicio = dtpAnio.Text + "-07-01";
                    trimestreFin = dtpAnio.Text + "-09-30";
                    break;
                case 3:
                    trimestreInicio = dtpAnio.Text + "-10-01";
                    trimestreFin = dtpAnio.Text + "-12-31";
                    break;
             

            }
            string categoriaSeleccionada = "";
            switch (cboCateg.SelectedIndex)
            {
                case 0:
                    categoriaSeleccionada = "EXEC FAGD.ListadoHotelesMayorCantidadReservasCanceladas '" + trimestreInicio + "','" + trimestreFin + "'";
                    break;
                case 1:
                    categoriaSeleccionada = "EXEC FAGD.ListadoHotelesMayorCantidadConsumFacturados '" + trimestreInicio + "','" + trimestreFin + "'";
                    break;
                case 2:
                    categoriaSeleccionada = "EXEC FAGD.ListadoHotelesMayorCantidadDiasDeBaja '" + trimestreInicio + "','" + trimestreFin + "'";
                    break;
                case 3:
                    categoriaSeleccionada = "EXEC FAGD.ListadoHabitacionesMasVecesUtilizadas '" + trimestreInicio + "','" + trimestreFin + "'";
                    break;
                case 4:
                    categoriaSeleccionada = "EXEC FAGD.ListadoClientesConMayoresPuntajes '" + trimestreInicio + "','" + trimestreFin + "'";
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
