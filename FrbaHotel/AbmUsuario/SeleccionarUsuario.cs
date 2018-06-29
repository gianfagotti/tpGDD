using System;
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
    public partial class SeleccionarUsuario : Form
    {
        Form ultimoForm;
        String usuario;
        public SeleccionarUsuario(Form form)
        {
            ultimoForm = form;
            InitializeComponent();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            usuario = cboUsuarios.Text;
            ModificarUsuarioDatos frm = new ModificarUsuarioDatos(this, usuario);
            this.Hide();
            frm.Show();
        }

        private void btnHoteles_Click(object sender, EventArgs e)
        {
            usuario = cboUsuarios.Text;
            ModificarUsuarioHoteles frm = new ModificarUsuarioHoteles(this, usuario);
            this.Hide();
            frm.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            usuario = cboUsuarios.Text;
            ModificarUsuarioRoles frm = new ModificarUsuarioRoles(this, usuario);
            this.Hide();
            frm.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ultimoForm.Show();
            this.Close();
        }

       
    }
}
