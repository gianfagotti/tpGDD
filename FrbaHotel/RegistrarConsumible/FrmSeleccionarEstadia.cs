using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarConsumible
{
    public partial class FrmSeleccionarEstadia : Form
    {
        public FrmSeleccionarEstadia()
        {
            InitializeComponent();
        }

        private void LblSeleccionarEstadia_Click(object sender, EventArgs e)
        {

        }

        private void BtnSeleccionarEstadia_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptarSeleccionEstadia_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAgregarConsumibles frmAgregarConsumibles = new FrmAgregarConsumibles();
            frmAgregarConsumibles.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmRol.frmMenuEmpleado frmMenuEmpleado = new AbmRol.frmMenuEmpleado();
            frmMenuEmpleado.ShowDialog();
        }
    }
}
