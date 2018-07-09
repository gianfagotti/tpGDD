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
    public partial class FrmMenuRegEst2 : Form
    {
        AbmRol.frmMenuEmpleado menuAVolver;

        public FrmMenuRegEst2(AbmRol.frmMenuEmpleado menu)
        {
            InitializeComponent();
            menuAVolver = menu;
        }

        private void FrmMenuRegEst_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
            menuAVolver.Show();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCheckin checkin = new FrmCheckin();
            checkin.ShowDialog();
            this.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCheckout checkout = new FrmCheckout(this, menuAVolver);
            checkout.ShowDialog();
            this.Show();    
        }
    }
}