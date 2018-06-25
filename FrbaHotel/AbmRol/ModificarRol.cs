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

namespace FrbaHotel.AbmRol
{
    public partial class ModificarRol : Form
    {
        Form ultimoFormulario;
        SqlDataReader resultado;
        SqlDataAdapter adapter;
        DataTable tabla;

        public ModificarRol(Form form, String rolSeleccionado)
        {
            InitializeComponent();
            ultimoFormulario = form;

            /*carga de la DGV*/
            String select = "SELECT * FROM FAGD.Funcionalidad";
            adapter = Login.FrmTipoUsuario.BD.dameDataAdapter(select);
            tabla = Login.FrmTipoUsuario.BD.dameDataTable(adapter);
            BindingSource bindSource = new BindingSource();
            bindSource.DataSource = tabla;
            dgvFuncionalidades.DataSource = bindSource;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            ultimoFormulario.Show();
        }
    }
}
