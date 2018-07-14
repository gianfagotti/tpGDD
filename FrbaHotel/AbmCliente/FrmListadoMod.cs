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

namespace FrbaHotel.AbmCliente
{
    public partial class FrmListadoMod : Form
    {
        Form abm;
        SqlDataAdapter adaptadorSql;
        DataTable tablaConDatos;

        public FrmListadoMod(Form abmPadre)
        {
            InitializeComponent();
            //Asigno el formulario anterior
            abm = abmPadre;
        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            abm.Show();
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            string consulta = "select cliente_codigo Código, cliente_nroDocumento Documento, cliente_apellido Apellido, cliente_nombre Nombre, cliente_fechaNac as 'Fecha nacimiento', cliente_mail Mail, cliente_nacionalidad Nacionalidad, cliente_calle Calle, cliente_nroCalle Número, cliente_piso Piso, cliente_dpto Dpto, cliente_tipoDocumento as 'Tipo Documento', cliente_telefono Telefono, cliente_localidad Localidad, cliente_estado Estado from FAGD.Cliente";
            string query = "";

            query = query + funcionesGlobales.filtrarAproximadamentePor("cliente_nombre", txtNombre.Text);
            query = query + funcionesGlobales.filtrarExactamentePor("cliente_tipoDocumento", cboTipoDoc.Text);
            query = query + funcionesGlobales.filtrarAproximadamentePor("cliente_apellido", txtApellido.Text);
            query = query + funcionesGlobales.filtrarExactamentePor("cliente_nroDocumento", txtNroDoc.Text);
            query = query + funcionesGlobales.filtrarAproximadamentePor("cliente_mail", txtMail.Text);
            if (query.Length > 0) 
            {
                query = query.Remove(query.Length - 4);
                consulta = consulta + " where " + query;
            }

            adaptadorSql = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataAdapter(consulta);
            tablaConDatos = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataTable(adaptadorSql);

            BindingSource bSource = new BindingSource();

            bSource.DataSource = tablaConDatos;
            dgvFiltrado.DataSource = bSource;            
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            //Vacio todos los campos
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtNroDoc.Text = string.Empty;
            cboTipoDoc.SelectedIndex = -1;
            dgvFiltrado.DataSource = null;
            txtNombre.Focus();
        }

        private void dgvFiltrado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Cuando se selecciona un cliente
            if (e.ColumnIndex == 0)
            {
                //Obtengo todos los datos del cliente y creo un nuevo formulario de modificación para ese cliente
                string codigo = dgvFiltrado.CurrentRow.Cells[1].Value.ToString();
                string nroDoc = dgvFiltrado.CurrentRow.Cells[2].Value.ToString();
                string apellido = dgvFiltrado.CurrentRow.Cells[3].Value.ToString();
                string nombre = dgvFiltrado.CurrentRow.Cells[4].Value.ToString();
                string fecha_nac = dgvFiltrado.CurrentRow.Cells[5].Value.ToString();
                string mail = dgvFiltrado.CurrentRow.Cells[6].Value.ToString();
                string nacionalidad = dgvFiltrado.CurrentRow.Cells[7].Value.ToString();
                string calle = dgvFiltrado.CurrentRow.Cells[8].Value.ToString();
                string nroCalle = dgvFiltrado.CurrentRow.Cells[9].Value.ToString();
                string piso = dgvFiltrado.CurrentRow.Cells[10].Value.ToString();
                string dpto = dgvFiltrado.CurrentRow.Cells[11].Value.ToString();
                string tipoDoc = dgvFiltrado.CurrentRow.Cells[12].Value.ToString();
                string telefono = dgvFiltrado.CurrentRow.Cells[13].Value.ToString();
                string localidad = dgvFiltrado.CurrentRow.Cells[14].Value.ToString();
                string estado = dgvFiltrado.CurrentRow.Cells[15].Value.ToString();

                FrmModificarCliente mod = new FrmModificarCliente(abm, codigo, nroDoc, apellido, nombre, fecha_nac, mail, nacionalidad, calle, nroCalle, piso, dpto, tipoDoc, telefono, localidad, estado);
                mod.Show();
                this.Close();
            }
        }

        private void txtsSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtsSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
