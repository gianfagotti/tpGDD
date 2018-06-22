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
        public static Conector2 BD = new Conector2();

        public FrmListadoMod(Form abmPadre)
        {
            InitializeComponent();
            abm = abmPadre;
        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            abm.Show();
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
            string consulta = "select * from FAGD.Cliente";
            string query = "";

            query = query + this.filtrarAproximadamentePor("cliente_nombre", txtNombre.Text);
            query = query + this.filtrarExactamentePor("cliente_tipoDocumento", cboTipoDoc.Text);
            query = query + this.filtrarAproximadamentePor("cliente_apellido", txtApellido.Text);
            query = query + this.filtrarExactamentePor("cliente_nroDocumento", txtNroDoc.Text);
            query = query + this.filtrarAproximadamentePor("cliente_mail", txtMail.Text);
            if (query.Length > 0) 
            {
                query = query.Remove(query.Length - 4);
                consulta = consulta + " where " + query;
            }

            adaptadorSql = BD.dameDataAdapter(consulta);
            tablaConDatos = BD.dameDataTable(adaptadorSql);

            BindingSource bSource = new BindingSource();

            bSource.DataSource = tablaConDatos;
            dgvFiltrado.DataSource = bSource;            
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtNroDoc.Text = string.Empty;
            cboTipoDoc.ResetText();
            dgvFiltrado.DataSource = null;
            txtNombre.Focus();
        }

    }
}
