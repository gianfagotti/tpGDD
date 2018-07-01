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
    public partial class FrmRegistrarHuesped : Form
    {
        Form ultimoForm;
        public static DataTable tabla;
        public static decimal persDisp = 0;

        public FrmRegistrarHuesped(Form form)
        {
            InitializeComponent();
            ultimoForm = form;

        }

        private void FrmRegistrarEstadia_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            this.Close();            
            ultimoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbmCliente.FrmAltaCliente registrarHuesped = new AbmCliente.FrmAltaCliente(this);
            registrarHuesped.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
