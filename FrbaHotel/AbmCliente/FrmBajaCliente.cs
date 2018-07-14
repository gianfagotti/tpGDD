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
            //Asigno formulario anterior
            abm = abmPadre;
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            //Cargo en la data griv todos los clientes
            string query = "select cliente_codigo Código, cliente_tipoDocumento as 'Tipo Documento', cliente_nroDocumento Documento, cliente_nombre Nombre, cliente_apellido Apellido, cliente_mail Mail, cliente_estado Estado from FAGD.Cliente";
            adaptadorSql = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataAdapter(query);
            tablaConDatos = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataTable(adaptadorSql);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = tablaConDatos;
            dataGridView1.DataSource = bSource;
        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            abm.Show();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            //Vacio todos los campos
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtNroDoc.Text = string.Empty;
            cboTipoDoc.ResetText();
            dataGridView1.DataSource = null;
            txtNombre.Focus();
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            //Filtro la data griv con los campos completados
            DataView dvData = new DataView(tablaConDatos);
            string query = "";

            query = query + funcionesGlobales.filtrarAproximadamentePor("Nombre", txtNombre.Text);
            query = query + funcionesGlobales.filtrarExactamentePor("Tipo Documento", cboTipoDoc.Text);
            query = query + funcionesGlobales.filtrarAproximadamentePor("Apellido", txtApellido.Text);
            query = query + funcionesGlobales.filtrarExactamentePor("Documento", txtNroDoc.Text);
            query = query + funcionesGlobales.filtrarAproximadamentePor("Mail", txtMail.Text);
            if (query.Length > 0) { query = query.Remove(query.Length - 4); }
            dvData.RowFilter = query;
            dataGridView1.DataSource = dvData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cuando selecciona un cliente
            if (e.ColumnIndex == 0)
            {
                //Me fijo si el cliente ya esta dado de baja
                if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "False")
                {
                    MessageBox.Show("El cliente ya esta dado de baja", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Obtengo el codigo del cliente
                string codigo = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show("Estas seguro que desea inhabilitar al cliente?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    consulta = "update FAGD.Cliente set cliente_estado=0 where cliente_codigo = " + codigo;

                    resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(consulta);
                    if (resultado.Read() == true)
                    {
                    }
                    resultado.Close();
                    MessageBox.Show("El cliente fue inhabilitado satisfactoriamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tablaConDatos = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataTable(adaptadorSql);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = tablaConDatos;
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
