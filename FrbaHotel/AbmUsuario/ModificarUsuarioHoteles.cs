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
    public partial class ModificarUsuarioHoteles : Form
    {
        Form ultimoFormulario;
        String usuario;
        public ModificarUsuarioHoteles(Form form, String usuarioSeleccionado)
        {
            ultimoFormulario = form;
            usuario = usuarioSeleccionado;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ultimoFormulario.Show();
            this.Close();
        }
    }
}
