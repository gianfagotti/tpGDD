﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class FrmAltaHotel : Form
    {
        AbmRol.frmMenuEmpleado frmMenuEmpleado;
        private SqlDataReader regimenes;
        private SqlDataReader resultadosCreacionDeHotel;
        private SqlDataReader resultadosCreacionDeRegimen;
        private DataTable hoteles,callesYAlturas;
        private String nombreHotelIngresado;
        private String mailHotelIngresado;
        private String telefonoHotelIngresado;
        private String calleHotelIngresado;
        private String alturaHotelIngresado;
        private String estrellasHotelIngresado;
        private String recargaEstrellasHotelIngresado;
        private String ciudadHotelIngresado;
        private String paisHotelIngresado;
        private String fechaCreacionHotelIngresadoPosta;
        private DateTime fechaCreacionHotelIngresado;
        public FrmAltaHotel(AbmRol.frmMenuEmpleado frmMenuEmpleadoRecibido)
        {
            InitializeComponent();
            frmMenuEmpleado = frmMenuEmpleadoRecibido;
            regimenes = Login.FrmTipoUsuario.BD.comando("SELECT regimen_descripcion FROM FAGD.Regimen");
            while (regimenes.Read() == true)
            {
                this.clbRegimenes.Items.Add(regimenes.GetSqlString(0), true);
            }
            regimenes.Close();
            dtpFechaCreacionHotel.Value = Login.FrmTipoUsuario.fechaApp;
        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadDeEstrellas_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaHotel_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrarTextosHotel_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
            this.cboCantidadDeEstrellas.SelectedIndex = -1;
            dtpFechaCreacionHotel.Value = Login.FrmTipoUsuario.fechaApp;
        }

        private void btnVolverHotel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.Show();
        }

        private void btnCrearHotel_Click(object sender, EventArgs e)
        {
            int txtsVacios = 0;
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox && string.IsNullOrEmpty(control.Text))
                        txtsVacios++;
                    else
                        func(control.Controls);
            };
            func(Controls);
            if (txtsVacios != 0 || this.cboCantidadDeEstrellas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (validarEmail(this.txtMailHotel.Text) != true)
            {
                MessageBox.Show("Ingrese un email válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombreHotelIngresado = this.txtNombreHotel.Text;
                hoteles = Login.FrmTipoUsuario.BD.consulta("SELECT hotel_nombre FROM FAGD.Hotel WHERE hotel_nombre = '" + nombreHotelIngresado + "'");
                if (hoteles.Rows.Count == 1)
                {
                    MessageBox.Show("Ya existe un hotel con ese nombre, ingrese un nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                calleHotelIngresado = this.txtCalleHotel.Text;
                alturaHotelIngresado = this.txtAlturaHotel.Text;
                callesYAlturas = Login.FrmTipoUsuario.BD.consulta("SELECT hotel_calle, hotel_nroCalle FROM FAGD.Hotel WHERE hotel_calle = '" + calleHotelIngresado + "' AND hotel_nroCalle = " + alturaHotelIngresado);
                if (callesYAlturas.Rows.Count != 0)
                {
                    MessageBox.Show("Ya existe un hotel con esa dirección, ingrese un dirección válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mailHotelIngresado = this.txtMailHotel.Text;
                    telefonoHotelIngresado = this.txtTelefonoHotel.Text;
                    estrellasHotelIngresado = this.cboCantidadDeEstrellas.SelectedItem.ToString();
                    recargaEstrellasHotelIngresado = this.txtRecargaPorEstrellasHotel.Text;
                    ciudadHotelIngresado =  this.txtCiudadHotel.Text;
                    paisHotelIngresado = this.txtPaisHotel.Text;
                    fechaCreacionHotelIngresado = Convert.ToDateTime(this.dtpFechaCreacionHotel.Value);
                    fechaCreacionHotelIngresadoPosta = fechaCreacionHotelIngresado.Date.ToString("yyyyMMdd HH:mm:ss");
                    resultadosCreacionDeHotel = Login.FrmTipoUsuario.BD.comando("EXEC FAGD.insertarHotel " + estrellasHotelIngresado + ", " + recargaEstrellasHotelIngresado + ", '" + paisHotelIngresado + "', '" + ciudadHotelIngresado + "', '" + calleHotelIngresado + "', " + alturaHotelIngresado + ", '" + nombreHotelIngresado + "', '" + fechaCreacionHotelIngresadoPosta + "', '" + mailHotelIngresado + "', " + telefonoHotelIngresado);
                    resultadosCreacionDeHotel.Close();
                    foreach(object itemChecked in clbRegimenes.CheckedItems)
                    {
                        resultadosCreacionDeRegimen = Login.FrmTipoUsuario.BD.comando("EXEC FAGD.insertarRegimenDeHotelCreado '"+nombreHotelIngresado+"', '"+itemChecked.ToString()+"'");
                        resultadosCreacionDeRegimen.Close();
                    }
                    MessageBox.Show("Hotel creado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    SeleccionarAdministrador frmSeleccionarAdministrador = new SeleccionarAdministrador(frmMenuEmpleado, nombreHotelIngresado);
                    frmSeleccionarAdministrador.Show();
                }
            }
        }

        private void lblDatosHotel_Click(object sender, EventArgs e)
        {

        }

        private void lblPais_Click(object sender, EventArgs e)
        {
        
        }

        private void txtTelefonoHotel_TextChanged(object sender, EventArgs e)
        {

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

         private static bool validarEmail(string email)
         {
             try
             {
                 new System.Net.Mail.MailAddress(email);
                 return true;
             }
             catch (FormatException)
             {
                 return false;
             }
         }
    }
}