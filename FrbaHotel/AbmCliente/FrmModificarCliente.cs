﻿using System;
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
    public partial class FrmModificarCliente : Form
    {
        Form frmMenuEmpleado;
        SqlDataReader resultado;
        string codigoCliente;

        public FrmModificarCliente(Form form,string codigo, string nroDoc, string apellido, string nombre, string fecha_nac, string mail, string nacionalidad, string calle, string nroCalle, string piso, string dpto, string tipoDoc, string tel, string localidad, string estado)
        {
            InitializeComponent();
            //Asigno el formulario del menú
            frmMenuEmpleado = form;
            //Completo todos los campos con los datos del cliente
            txtNroDocumentoMod.Text = nroDoc;
            txtApellidoMod.Text = apellido;
            txtNombreMod.Text = nombre;
            dtpFechaNacimientoMod.Text = fecha_nac;
            txtMailMod.Text = mail;
            txtNacionalidadMod.Text = nacionalidad;
            txtCalleMod.Text = calle;
            txtNumeroMod.Text = nroCalle;
            txtPisoMod.Text = piso;
            txtDptoMod.Text = dpto;
            cboTipoDocMod.Text = tipoDoc;
            txtTelefonoMod.Text = tel;
            txtLocalidadMod.Text = localidad;
            codigoCliente = codigo;

            if (estado == "True")
                chkHabilitadoMod.Checked = true;

            txtNombreMod.Focus();
        }

        private void btnVolverMod_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.Show();
        }

        private void limpiarCampos()
        {
            //Vacio todos los campos
            txtNombreMod.Text = string.Empty;
            txtApellidoMod.Text = string.Empty;
            txtNroDocumentoMod.Text = string.Empty;
            txtMailMod.Text = string.Empty;
            txtTelefonoMod.Text = string.Empty;
            txtCalleMod.Text = string.Empty;
            txtNumeroMod.Text = string.Empty;
            txtPisoMod.Text = string.Empty;
            txtDptoMod.Text = string.Empty;
            txtLocalidadMod.Text = string.Empty;
            txtNacionalidadMod.Text = string.Empty;
            cboTipoDocMod.SelectedIndex = -1;
            dtpFechaNacimientoMod.Value = FechaConfig.getDate();
            txtNombreMod.Focus();
        }

        private void butLimpiarMod_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        //Función para chequear que haya completado todos los campos
        private int checkearCamposVacios()
        {
            int a = 0;
            string mensaje = "";

            if (string.IsNullOrEmpty(txtNombreMod.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo nombre es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtApellidoMod.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo apellido es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtNacionalidadMod.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo nacionalidad es obligatorio\n";
            }

            if (string.IsNullOrEmpty(cboTipoDocMod.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo tipo documento es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtTelefonoMod.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo telefono es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtNroDocumentoMod.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo numero documento es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtMailMod.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo mail es obligatorio\n";
            }
            else
            {
                //Valido que lo que ingreso sea un mail
                if (!funcionesGlobales.validarEmail(txtMailMod.Text))
                {
                    a = 1;
                    mensaje = mensaje + "El campo mail es invalido\n";
                }
            }
            if (string.IsNullOrEmpty(txtCalleMod.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo Calle es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtNumeroMod.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo Numero es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtLocalidadMod.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo Localidad es obligatorio\n";
            }

            if (string.IsNullOrEmpty(txtPisoMod.Text))
            {
                txtPisoMod.Text = "-";
            }
            if (string.IsNullOrEmpty(txtDptoMod.Text))
            {
                txtDptoMod.Text = "-";
            }

            DateTime fecha;
            fecha = Convert.ToDateTime(dtpFechaNacimientoMod.Value);

            DateTime s = FechaConfig.getDate();

            int result = DateTime.Compare(fecha, s);
            //Comparo la fecha ingresada
            if (result >= 0)
            {
                a = 1;
                mensaje = mensaje + "La fecha debe ser menor a la actual\n";
            }

            if (a == 1)
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return a;
        }

        private void butGuardarMod_Click(object sender, EventArgs e)
        {
            //Chequeo que todos los campos esten completos
            int a = checkearCamposVacios();
            if (a == 0)
            {
                string comando = "EXEC FAGD.modificarCliente ";
                comando = comando + codigoCliente + ",";
                comando = comando + "'" + txtNombreMod.Text + "',";
                comando = comando + "'" + txtApellidoMod.Text + "',";
                comando = comando + "'" + cboTipoDocMod.Text + "',";
                comando = comando + txtNroDocumentoMod.Text + ",";
                comando = comando + "'" + txtMailMod.Text + "',";
                comando = comando + txtTelefonoMod.Text + ",";
                comando = comando + "'" + txtCalleMod.Text + "',";
                comando = comando + txtNumeroMod.Text + ",";
                comando = comando + "'" + txtPisoMod.Text + "',";
                comando = comando + "'" + txtDptoMod.Text + "',";
                comando = comando + "'" + txtLocalidadMod.Text + "',";
                comando = comando + "'" + txtNacionalidadMod.Text + "',";

                DateTime fecha;

                fecha = Convert.ToDateTime(dtpFechaNacimientoMod.Value);
                string lala = fecha.Date.ToString("yyyyMMdd HH:mm:ss");

                comando = comando + "'" + lala + "',";

                if (chkHabilitadoMod.Checked)
                    comando = comando + "1";
                else
                    comando = comando + "0";

                decimal resu = 0;
                resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(comando);
                if (resultado.Read())
                {
                    resu = resultado.GetDecimal(0);
                }
                resultado.Close();
                if (resu == 1)
                {
                    MessageBox.Show("Los cambios fueron guardados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMenuEmpleado.Show();
                    this.Close();
                }
                else if (resu == 2)
                    MessageBox.Show("No se pudieron guardar los cambios, el cliente con ese tipo y numero de documento ya existe", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("No se pudieron guardar los cambios, el cliente con ese mail ya existe", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
