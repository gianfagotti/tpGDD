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

namespace FrbaHotel.AbmHabitacion
{
    public partial class FrmCrearHabitacion : Form
    {
        Form abm;
        private SqlDataReader resultado;
        decimal codigoHotel;

        public FrmCrearHabitacion(Form abmPadre)
        {
            InitializeComponent();
            //Asigno el formulario anterior
            abm = abmPadre;
            //Obtengo el codigo del hotel del que se inicio sesión
            codigoHotel = Login.FrmSeleccionarHotel.codigoHotel;

            resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("SELECT DISTINCT habitacionTipo_descripcion FROM FAGD.HabitacionTipo");
            while (resultado.Read() == true)
            {
                //Cargo todos los tipos de habitación al combo box
                cboTipoHabitacion.Items.Add(resultado.GetSqlString(0));
            }
            resultado.Close();

            resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("SELECT DISTINCT habitacion_ubicacion FROM FAGD.Habitacion");
            while (resultado.Read() == true)
            {
                //Cargo todas las ubicaciones al combo box
                cboUbicacion.Items.Add(resultado.GetSqlString(0));
            }
            resultado.Close();
            txtNroHab.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            abm.Show();
        }

        private void limpiarCampos()
        {
            //Vacio todos los campos
            txtNroHab.Text = string.Empty;
            txtPiso.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cboTipoHabitacion.SelectedIndex = -1;
            cboUbicacion.SelectedIndex = -1;
            chkHabilitado.Checked = false;
            txtNroHab.Focus();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            //Chequeo que todos los campos esten completos
            if (checkearCamposVacios() == 0)
            {
                //Completo el store procedure a ejecutar con los datos ingresados
                string comando = "EXEC FAGD.GuardarNuevaHabitacion ";
                comando = comando + txtNroHab.Text + ",";
                comando = comando + txtPiso.Text + ",";
                comando = comando + "'" + cboUbicacion.Text + "',";
                comando = comando + "'" + cboTipoHabitacion.Text + "',";
                if (!string.IsNullOrEmpty(txtDescripcion.Text))
                    comando = comando + "'" + txtDescripcion.Text + "',";
                else
                    comando = comando + "NULL,";
                comando = comando + codigoHotel + ",";

                if (chkHabilitado.Checked)
                    comando = comando + "1";
                else
                    comando = comando + "0";

                decimal resu = 0;
                resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(comando);
                if (resultado.Read())
                    resu = resultado.GetDecimal(0);
                resultado.Close();
                if (resu == 1)
                {
                    MessageBox.Show("La habitacion ha sido guardada correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
                else if (resu == 2)
                    MessageBox.Show("Error al guardar, la habitacion con ese numero ya existe en este hotel", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Error al guardar la habitacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Función que chequea que todos los campos esten completos
        private int checkearCamposVacios()
        {
            int a = 0;
            string mensaje = "";
            if (string.IsNullOrEmpty(txtNroHab.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo numero es obligatorio\n";
            }
            if (string.IsNullOrEmpty(txtPiso.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo piso es obligatorio\n";
            }
            if (string.IsNullOrEmpty(cboUbicacion.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo ubicacion es obligatorio\n";
            }
            if (string.IsNullOrEmpty(cboTipoHabitacion.Text))
            {
                a = 1;
                mensaje = mensaje + "El campo tipo de habitacion es obligatorio\n";
            }
            if (a == 1)
            {
                MessageBox.Show(mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return a;
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
    }
}
