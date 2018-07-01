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
    public partial class SeleccionarHotel : Form
    {
        Form ultimoFormulario;
        String usuario;

        public SeleccionarHotel(Form formAnterior, String usuarioSeleccionado)
        {
            ultimoFormulario = formAnterior;
            usuario = usuarioSeleccionado;
            InitializeComponent();
        }
    }
}
