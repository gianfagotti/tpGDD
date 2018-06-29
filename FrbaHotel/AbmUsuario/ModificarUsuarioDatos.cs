﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmUsuario
{
    public partial class ModificarUsuarioDatos : Form
    {
        Form ultimoForm;
        String usuario;
        public ModificarUsuarioDatos(Form formAnterior, String usuarioSeleccionado)
        {
            usuario = usuarioSeleccionado;
            ultimoForm = formAnterior;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            ultimoForm.Show();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
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

        }
    }
}
