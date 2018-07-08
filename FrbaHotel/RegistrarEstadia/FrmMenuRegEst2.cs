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
        Form ultimoform;

        public FrmMenuRegEst2(Form form)
        {
            InitializeComponent();
            ultimoform = form;
        }



        private void FrmMenuRegEst_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ultimoform.Show();
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
            FrmCheckout checkout = new FrmCheckout();
            checkout.ShowDialog();
            this.Show();    
        }
    }
}