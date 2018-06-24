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
    public partial class FrmRegimen : Form
    {
        Form abm;
        string query;
        SqlDataReader resultado;

        public FrmRegimen(Form abmPadre, string accion)
        {
            InitializeComponent();
            abm = abmPadre;
            this.Text = accion + "Regimen";
            button3.Text = accion;
            txtCodigo.Text = Login.FrmTipoUsuario.BD.executeAndReturn("SELECT count(*) + 1 FROM FAGD.Regimen");
        }

        public FrmRegimen(Form abmPadre, string accion, string id, string precio, string descripcion, bool estado)
        {
            InitializeComponent();
            abm = abmPadre;
            this.Text = accion + "Regimen";
            button3.Text = accion;
            txtCodigo.Text = id;
            txtPrecio.Text = precio;
            txtDescripcion.Text = descripcion;
            chkEstado.Checked = estado;
        }

        private void FrmRegimen_Load(object sender, EventArgs e)
        {

        }

        private void limpiarCampos()
        {
            txtPrecio.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            chkEstado.Checked = false;
            txtPrecio.Focus();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            abm.Show();
        }

        private int checkearCampos()
        {
            int a = 0;
            string mensaje = "";

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                a++;
                mensaje = mensaje + "El campo precio esta vacio\n";
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                a++;
                mensaje = mensaje + "El campo descripcion esta vacio\n";
            }

            if (a > 0)
                MessageBox.Show(mensaje);

            return a;
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkearCampos() == 0)
            {
                switch (button3.Text)
                {
                    case "Crear":
                        query = "EXEC FAGD.crearRegimen ";
                        query = query + txtPrecio.Text.Replace(',', '.');
                        query = query + ",'" + txtDescripcion.Text + "',";
                        if (chkEstado.Checked)
                            query = query + "1";
                        else
                            query = query + "0";
                        decimal resu = 0;
                        resultado = Login.FrmTipoUsuario.BD.comando(query);
                        if (resultado.Read())
                        {
                            resu = resultado.GetDecimal(0);
                        }
                        resultado.Close();
                        if (resu == 1)
                        {
                            MessageBox.Show("El regimen fue creado correctamente");
                            limpiarCampos();
                        }
                        else if (resu == 2)
                            MessageBox.Show("Error al guardar, el regimen ya existe");
                        else
                            MessageBox.Show("Error al querer crear el regimen");

                        txtCodigo.Text = Login.FrmTipoUsuario.BD.executeAndReturn("SELECT count(*) + 1 FROM FAGD.Regimen");
                        break;



                }
            }
        }
    }
}
