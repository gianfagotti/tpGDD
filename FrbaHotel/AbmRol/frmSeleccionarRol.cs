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
    public partial class frmSeleccionarRol : Form
    {
        AbmRol.frmMenuEmpleado frmMenuEmpleado;
     // SqlDataAdapter adapter;
        SqlDataReader reader;
        String rolSeleccionado;


        public frmSeleccionarRol(AbmRol.frmMenuEmpleado form)
        {
            InitializeComponent();
            frmMenuEmpleado = form;
            String select = "SELECT rol_nombre FROM FAGD.Rol";
            
           // adapter = Login.FrmTipoUsuario.BD.dameDataAdapter(select);
            reader = Login.FrmTipoUsuario.BD.comando(select);
            
            DataTable tabla = new DataTable();
            tabla.Columns.Add("rol_nombre", typeof(string));
            tabla.Load(reader);

            cboSeleccion.ValueMember = "rol_nombre";
            cboSeleccion.DisplayMember = "rol_nombre";
            cboSeleccion.DataSource = tabla;
            
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            AbmRol.ModificarRol modificarRol = new AbmRol.ModificarRol(this, rolSeleccionado);
            this.Hide();
            modificarRol.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuEmpleado.Show();
        }

        private void cboSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            rolSeleccionado = cboSeleccion.SelectedValue.ToString();
        }
    }
}
