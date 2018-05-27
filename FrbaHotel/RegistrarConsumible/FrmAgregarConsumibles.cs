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
    public partial class FrmAgregarConsumibles : Form
    {
        public FrmAgregarConsumibles()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSeleccionarEstadia frmSeleccionarEstadia = new FrmSeleccionarEstadia();
            frmSeleccionarEstadia.ShowDialog();
        }
    }
}
