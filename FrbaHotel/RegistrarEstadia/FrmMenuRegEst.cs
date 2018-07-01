using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class FrmMenuRegEst : Form
    {
        private AbmRol.frmMenuEmpleado frmMenuEmpleado;

        public FrmMenuRegEst()
        {
            InitializeComponent();
        }

        public FrmMenuRegEst(AbmRol.frmMenuEmpleado frmMenuEmpleado)
        {
            this.frmMenuEmpleado = frmMenuEmpleado;
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            FrmCheckin checkIn = new FrmCheckin();
            this.Hide();
            checkIn.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            /*
            FrmCheckout checkOut = new FrmCheckOut();
            this.Hide();
            checkOut.Show();   */
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuEmpleado.Show();
        }
    }
}
