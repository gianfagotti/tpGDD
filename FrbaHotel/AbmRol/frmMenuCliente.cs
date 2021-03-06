﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class frmMenuCliente : Form
    {
        public frmMenuCliente()
        {
            InitializeComponent();
        }
        /*Seteo de funcionalidades de los botones del menú del Cliente*/
        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {

            GenerarModificacionReserva.GenerarReserva frmGenerarReserva = new GenerarModificacionReserva.GenerarReserva(this);
            this.Hide();
            frmGenerarReserva.Show();

        }

        private void btnModificarReserva_Click_1(object sender, EventArgs e)
        {
            GenerarModificacionReserva.listadoModReserva frmModificarReserva = new GenerarModificacionReserva.listadoModReserva(this);
            this.Hide();
            frmModificarReserva.Show();
        }

        private void btnCancelarReserva_Click_1(object sender, EventArgs e)
        {
            CancelarReserva.CancelarReserva frmCancelarReserva = new CancelarReserva.CancelarReserva(this);
            this.Hide();
            frmCancelarReserva.Show();
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            Login.FrmTipoUsuario frmTipoUsuario = new Login.FrmTipoUsuario();
            this.Hide();
            frmTipoUsuario.Show();
        }
    }
}
