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
    public partial class NuevoRolXHotel : Form
    {
        Form ultimoFormulario;
        String usuario;

        public NuevoRolXHotel(Form formAnterior, String usuarioSeleccionado)
        {
            ultimoFormulario = formAnterior;
            usuario = usuarioSeleccionado;
            InitializeComponent();
        }
    }
}
