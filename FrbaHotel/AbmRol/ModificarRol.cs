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
    public partial class ModificarRol : Form
    {
        Form ultimoFormulario;

        public ModificarRol(Form form)
        {
            InitializeComponent();
            ultimoFormulario = form;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            ultimoFormulario.Show();
        }
    }
}
