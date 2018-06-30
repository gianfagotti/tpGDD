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

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class BuscarClientes : Form
    {
        Form abmPadre;
        string consulta;
        SqlDataReader resultado;
        SqlDataAdapter sAdapter;
        DataTable dTable;

        public BuscarClientes(Form frm)
        {
            InitializeComponent();
            abmPadre = frm;
            txtNroDoc.Focus();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            txtMail.Clear();
            txtNroDoc.Clear();
            cboTipoDoc.ResetText();
            txtNroDoc.Focus();
            this.butBuscar_Click(null, null);
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            DataView dvData = new DataView(dTable);
            string query = "";

            query = query + this.filtrarExactamentePor("TipoDoc", cboTipoDoc.Text);

            query = query + this.filtrarExactamentePor("NroDoc", txtNroDoc.Text);
            query = query + this.filtrarAproximadamentePor("Mail", txtMail.Text);
            if (query.Length > 0) { query = query.Remove(query.Length - 4); }
            dvData.RowFilter = query;
            dataGridView1.DataSource = dvData;
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

        private void butVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            abmPadre.Show();
        }

        private void BuscarClientes_Load(object sender, EventArgs e)
        {
            string query = "select cliente_nombre Nombre,cliente_apellido Apellido,cliente_tipoDocumento TipoDoc,cliente_nroDocumento NroDoc,cliente_mail Mail from FAGD.Cliente";
            sAdapter = Login.FrmTipoUsuario.BD.dameDataAdapter(query);
            dTable = Login.FrmTipoUsuario.BD.dameDataTable(sAdapter);
            //BindingSource to sync DataTable and DataGridView
            BindingSource bSource = new BindingSource();
            //set the BindingSource DataSource
            bSource.DataSource = dTable;
            //set the DataGridView DataSource
            dataGridView1.DataSource = bSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                GenerarModificacionReserva.GenerarReserva.clienteSeleccionado = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                GenerarModificacionReserva.GenerarReserva.ActiveForm.Show();
                this.Close();
            }
        }
    }
}
