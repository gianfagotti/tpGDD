﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion
{
    public partial class FrmModificarHabitacion : Form
    {
        public FrmModificarHabitacion()
        {
            InitializeComponent();
        }

        private void btnVolverMod_Click(object sender, EventArgs e)
        {
            AbmRol.frmMenuEmpleado frmMenuEmpleado = new AbmRol.frmMenuEmpleado();
            this.Hide();
            frmMenuEmpleado.ShowDialog();
        }
    }
}