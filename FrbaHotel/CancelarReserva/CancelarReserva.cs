﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.CancelarReserva
{
    public partial class CancelarReserva : Form
    {
        public CancelarReserva()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AbmRol.frmMenuCliente frmMenuCliente = new AbmRol.frmMenuCliente();
            this.Hide();
            frmMenuCliente.ShowDialog();
        }
    }
}
