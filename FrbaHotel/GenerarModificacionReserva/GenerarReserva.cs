﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.AbmRol;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class GenerarReserva : Form
    {
        Form ultimoFormulario;

        public GenerarReserva(Form form)
        {
            InitializeComponent();
            
            ultimoFormulario = form;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            ultimoFormulario.Show();
        }

    }
}
