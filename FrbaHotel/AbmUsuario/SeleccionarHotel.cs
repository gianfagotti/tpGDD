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


namespace FrbaHotel.AbmUsuario
{
    public partial class SeleccionarHotel : Form
    {
        Form ultimoFormulario;
        String usuario;
        Boolean alta;
        DataTable tablaH;

        public SeleccionarHotel(Form formAnterior, String usuarioSeleccionado, Boolean habilitarNuevo)
        {
            ultimoFormulario = formAnterior;
            usuario = usuarioSeleccionado;
            alta = habilitarNuevo; /*Recibo un booleano según el botón ingresado en el menú de modificación (true si es una habilitacion, false en caso contrario)*/
            InitializeComponent();
            llenarCbo(); /*Lleno el cbo con los hoteles donde trabaja el usuario*/
            if (alta) btnHotel.Enabled = true; /*en caso de habilitar un nuevo rol, permito que se cree un rol en un nuevo hotel (donde no trabaje actualmente el empleado) */
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ultimoFormulario.Show();
            this.Close();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            NuevoRolXHotel frm = new NuevoRolXHotel(ultimoFormulario,this, usuario);
            this.Hide();
            frm.Show();

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            /*Verifico que se haya seleccionado un hotel*/
            if (String.IsNullOrEmpty(cboHotel.Text)) MessageBox.Show("Seleccione un hotel!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else{
                String hotel = cboHotel.Text;
                /*prosigo a seleccionar un rol a habilitar/eliminar según el booleano alta*/
                SeleccionarRol frm = new SeleccionarRol(ultimoFormulario, this, usuario, hotel, alta);
                this.Hide();
                frm.Show();
            }
        }

        private void llenarCbo() { /*selecciono los hoteles donde trabaja actualmente el usuario*/

            String select = "SELECT hotel_calle, hotel_nroCalle FROM FAGD.Hotel ";
            select = select + "WHERE hotel_codigo IN (SELECT hotel_codigo FROM FAGD.UsuarioXRolXHotel WHERE '" + usuario + "' = "
                            + "usuario_username)";
            int fila = 0;
            tablaH = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta(select);
            while (fila < tablaH.Rows.Count)
            {
                cboHotel.Items.Add(tablaH.Rows[fila][0].ToString() + "-" + tablaH.Rows[fila][1].ToString());
                fila++;
            }

            tablaH.Clear();
        
        }
    }
}
