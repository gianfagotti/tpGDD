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
    public partial class FrmRegistrarEstadia : Form
    {
        public FrmRegistrarEstadia()
        {
            InitializeComponent();
        }

        private void FrmRegistrarEstadia_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnFechaCheckOut_Click(object sender, EventArgs e)
        {
            this.PnlCheckInYOut.Show();
        }

        private void BtnFechaCheckIn_Click(object sender, EventArgs e)
        {
            this.PnlCheckInYOut.Show();
        }

        private void BtnAceptarCheckInYOut_Click(object sender, EventArgs e)
        {
            this.PnlCheckInYOut.Hide();
            this.TxtCheckIn.Text = this.McrCheckInYOut.SelectionRange.Start.ToShortDateString();
            this.TxtCheckOut.Text = this.McrCheckInYOut.SelectionRange.End.ToShortDateString();
        }

        private void TxtCheckIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCheckOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmRol.frmMenuEmpleado frmMenuEmpleado = new AbmRol.frmMenuEmpleado();
            frmMenuEmpleado.ShowDialog();
        }
    }
}
