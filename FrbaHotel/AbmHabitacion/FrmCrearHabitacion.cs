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
            abm = abmPadre;

            resultado = Login.FrmTipoUsuario.BD.comando("SELECT DISTINCT habitacionTipo_descripcion FROM FAGD.HabitacionTipo");
            while (resultado.Read() == true)
            {
                cboTipoHabitacion.Items.Add(resultado.GetSqlString(0));
            }
            resultado.Close();
            txtNroHab.Focus();
        }

        private void txtNroHab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            abm.Show();
        }

        private void limpiarCampos()
        {
            txtNroHab.Text = string.Empty;
            txtPiso.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cboTipoHabitacion.ResetText();
            cboUbicacion.ResetText();
            chkHabilitado.Checked = false;
            txtNroHab.Focus();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            if (checkearCamposVacios() == 0)
            {
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
                resultado = Login.FrmTipoUsuario.BD.comando(comando);
                if (resultado.Read())
                    resu = resultado.GetDecimal(0);
                resultado.Close();
                if (resu == 1)
                {
                    MessageBox.Show("La habitacion a sido guardada correctamente");
                    limpiarCampos();
                }
                else if (resu == 2)
                    MessageBox.Show("Error al guardar, la habitacion con ese numero ya existe en este hotel");
                else
                    MessageBox.Show("Error al guardar la habitacion");
            }
        }

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
                MessageBox.Show(mensaje);
            }
            return a;
        }
    }
}
