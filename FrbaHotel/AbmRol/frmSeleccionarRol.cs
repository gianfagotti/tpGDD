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
        SqlDataReader reader;
        String rolSeleccionado;


        public frmSeleccionarRol(AbmRol.frmMenuEmpleado form)
        {
            InitializeComponent();

            /*Cargo el combo box con los roles a modificar (exceptuando 'Administrador general')*/
            frmMenuEmpleado = form;
            String select = "SELECT rol_nombre FROM FAGD.Rol WHERE rol_nombre <> 'Administrador general'";
            
            reader = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(select);
            
            DataTable tabla = new DataTable();
            tabla.Columns.Add("rol_nombre", typeof(string));
            tabla.Load(reader);

            cboSeleccion.ValueMember = "rol_nombre";
            cboSeleccion.DisplayMember = "rol_nombre";
            cboSeleccion.DataSource = tabla;
            
        }

        /*Envío el rol seleccionado como parámetro al formulario de modificación*/
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
