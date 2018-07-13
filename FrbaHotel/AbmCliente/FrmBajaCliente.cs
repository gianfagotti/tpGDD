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
            string query = "select cliente_codigo Código, cliente_tipoDocumento as 'Tipo Documento', cliente_nroDocumento Documento, cliente_nombre Nombre, cliente_apellido Apellido, cliente_mail Mail, cliente_estado Estado from FAGD.Cliente";
            adaptadorSql = Login.FrmTipoUsuario.BD.dameDataAdapter(query);
            tablaConDatos = Login.FrmTipoUsuario.BD.dameDataTable(adaptadorSql);
            //BindingSource to sync DataTable and DataGridView
            BindingSource bSource = new BindingSource();
            //set the BindingSource DataSource
            bSource.DataSource = tablaConDatos;
            //set the DataGridView DataSource
            dataGridView1.DataSource = bSource;
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
            dataGridView1.DataSource = null;
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

            query = query + this.filtrarAproximadamentePor("Nombre", txtNombre.Text);
            query = query + this.filtrarExactamentePor("Tipo Documento", cboTipoDoc.Text);
            query = query + this.filtrarAproximadamentePor("Apellido", txtApellido.Text);
            query = query + this.filtrarExactamentePor("Documento", txtNroDoc.Text);
            query = query + this.filtrarAproximadamentePor("Mail", txtMail.Text);
            if (query.Length > 0) { query = query.Remove(query.Length - 4); }
            dvData.RowFilter = query;
            dataGridView1.DataSource = dvData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "False")
                {
                    MessageBox.Show("El cliente ya esta dado de baja", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string codigo = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show("Estas seguro que desea inhabilitar al cliente?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    consulta = "update FAGD.Cliente set cliente_estado=0 where cliente_codigo = " + codigo;

                    resultado = Login.FrmTipoUsuario.BD.comando(consulta);
                    if (resultado.Read() == true)
                    {
                    }
                    resultado.Close();
                    MessageBox.Show("El cliente fue inhabilitado satisfactoriamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tablaConDatos = Login.FrmTipoUsuario.BD.dameDataTable(adaptadorSql);
                //BindingSource to sync DataTable and DataGridView
                BindingSource bSource = new BindingSource();
                //set the BindingSource DataSource
                bSource.DataSource = tablaConDatos;
                //set the DataGridView DataSource
                dataGridView1.DataSource = bSource;
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
