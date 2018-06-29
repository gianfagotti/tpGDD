using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class FrmAltaHotel : Form
    {
        AbmRol.frmMenuEmpleado frmMenuEmpleado;
        public FrmAltaHotel(AbmRol.frmMenuEmpleado frmMenuEmpladoRecibido)
        {
            InitializeComponent();
            frmMenuEmpleado = frmMenuEmpladoRecibido;
        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadDeEstrellas_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaHotel_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrarTextosHotel_Click(object sender, EventArgs e)
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

        private void btnVolverHotel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.Show();
        }

        private void btnCrearHotel_Click(object sender, EventArgs e)
        {
            int txtsVacios = 0;
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox && string.IsNullOrEmpty(control.Text))
                        txtsVacios++;
                    else
                        func(control.Controls);
            };
            func(Controls);
            if (txtsVacios != 0)
            {
                MessageBox.Show("Debe completar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //operacion de ingresar el hotel
            }
        }

        private void lblDatosHotel_Click(object sender, EventArgs e)
        {

        }
    }
}