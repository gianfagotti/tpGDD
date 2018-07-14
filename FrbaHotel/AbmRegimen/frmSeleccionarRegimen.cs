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

namespace FrbaHotel.AbmRegimen
{
    public partial class frmSeleccionarRegimen : Form
    {
        Form ultimoForm;
        SqlDataReader reader;
        Boolean modificacion;

        public frmSeleccionarRegimen(Form formAnterior, Boolean modif)
        {
            ultimoForm = formAnterior;
            modificacion = modif;
            InitializeComponent();
            if (modif){ label1.Text = "Seleccione el régimen a modificar:"; }
            else { 
                label1.Text = "Seleccione el régimen a inhabilitar:";
                Aceptar.Text = "Inhabilitar";
            }
            llenarCboRegimen();
        }

        private void llenarCboRegimen(){
            String select = "SELECT regimen_descripcion FROM FAGD.Regimen";
            DataTable tabla = new DataTable();

            reader = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(select);

            tabla.Columns.Add("regimen_descripcion", typeof(string));
            tabla.Load(reader);

            cboRegimenes.ValueMember = "regimen_descripcion";
            cboRegimenes.DisplayMember = "regimen_descripcion";
            cboRegimenes.DataSource = tabla;
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            ultimoForm.Show();
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboRegimenes.Text))
            {
                MessageBox.Show("Seleccione un regimen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (modificacion)
                {
                    FrmRegimen frm = new FrmRegimen(ultimoForm, "Modificar");
                    frm.Show();
                    this.Close();
                }
            }
        }

    }
}
