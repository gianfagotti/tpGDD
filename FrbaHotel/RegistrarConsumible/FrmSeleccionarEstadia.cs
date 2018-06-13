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
        AbmRol.frmMenuEmpleado frmMenuEmpleado;

        public FrmSeleccionarEstadia(AbmRol.frmMenuEmpleado form)
        {
            InitializeComponent();
            frmMenuEmpleado = form;
        }

        private void LblSeleccionarEstadia_Click(object sender, EventArgs e)
        {

        }

        private void BtnSeleccionarEstadia_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptarSeleccionEstadia_Click(object sender, EventArgs e)
        {
            FrmAgregarConsumibles frmAgregarConsumibles = new FrmAgregarConsumibles(this);
            this.Hide();            
            frmAgregarConsumibles.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();            
            frmMenuEmpleado.Show();
        }
    }
}
