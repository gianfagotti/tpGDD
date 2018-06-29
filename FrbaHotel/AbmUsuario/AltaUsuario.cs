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
    public partial class AltaUsuario : Form
    {
        Form ultimoFormulario;


        public AltaUsuario(Form formAnterior)
        {

            InitializeComponent();
            ultimoFormulario = formAnterior;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ultimoFormulario.Show();
            this.Close();

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

            cboRol.ResetText();
            cboHotel.ResetText();
            cboDocumento.ResetText();

            //cboRol.SelectedIndex = -1;
            //cboHotel.SelectedIndex = -1;
            //cboDocumento.SelectedIndex = -1;

        }
    }
}
