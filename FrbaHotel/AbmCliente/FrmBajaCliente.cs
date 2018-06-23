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
    public partial class FrmBajaCliente : Form
    {
        Form abm;
        SqlDataAdapter adaptadorSql;
        DataTable tablaConDatos;
        SqlDataReader resultado;
        string consulta;

        public FrmBajaCliente(Form abmPadre)
        {
            InitializeComponent();
            abm = abmPadre;
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            string query = "select * from FAGD.Cliente";
            adaptadorSql = Login.FrmTipoUsuario.BD.dameDataAdapter(query);
            tablaConDatos = Login.FrmTipoUsuario.BD.dameDataTable(adaptadorSql);
            //BindingSource to sync DataTable and DataGridView
            BindingSource bSource = new BindingSource();
            //set the BindingSource DataSource
            bSource.DataSource = tablaConDatos;
            //set the DataGridView DataSource
            dgvBaja.DataSource = bSource;
        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            abm.Show();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtNroDoc.Text = string.Empty;
            cboTipoDoc.ResetText();
            dgvBaja.DataSource = null;
            txtNombre.Focus();
        }

        private string filtrarExactamentePor(string columna, string valor)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                return columna + " = '" + valor + "' AND ";
            }
            return "";
        }

        private string filtrarAproximadamentePor(string columna, string valor)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                return columna + " LIKE '%" + valor + "%' AND ";
            }
            return "";
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            DataView dvData = new DataView(tablaConDatos);
            string query = "";

            query = query + this.filtrarAproximadamentePor("cliente_nombre", txtNombre.Text);
            query = query + this.filtrarExactamentePor("cliente_tipoDocumento", cboTipoDoc.Text);
            query = query + this.filtrarAproximadamentePor("cliente_apellido", txtApellido.Text);
            query = query + this.filtrarExactamentePor("cliente_nroDocumento", txtNroDoc.Text);
            query = query + this.filtrarAproximadamentePor("cliente_mail", txtMail.Text);
            if (query.Length > 0) { query = query.Remove(query.Length - 4); }
            dvData.RowFilter = query;
            dgvBaja.DataSource = dvData;
        }

        private void dgvBaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (dgvBaja.CurrentRow.Cells[15].Value.ToString() == "False")
                {
                    MessageBox.Show("El cliente ya esta dado de baja");
                    return;
                }
                string nroDocumento = dgvBaja.CurrentRow.Cells[2].Value.ToString();

                if (MessageBox.Show("Estas seguro que desea inhabilitar al cliente?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    consulta = "update FAGD.Cliente set cliente_estado=0 where cliente_nroDocumento = " + nroDocumento;

                    resultado = Login.FrmTipoUsuario.BD.comando(consulta);
                    if (resultado.Read() == true)
                    {
                    }
                    resultado.Close();
                }
                tablaConDatos = Login.FrmTipoUsuario.BD.dameDataTable(adaptadorSql);
                //BindingSource to sync DataTable and DataGridView
                BindingSource bSource = new BindingSource();
                //set the BindingSource DataSource
                bSource.DataSource = tablaConDatos;
                //set the DataGridView DataSource
                dgvBaja.DataSource = bSource;
            }
        }
    }
}
