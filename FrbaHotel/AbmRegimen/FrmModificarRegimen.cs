using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRegimen
{
    public partial class FrmModificarRegimen : Form
    {
        AbmRol.frmMenuEmpleado frmMenuEmpleado;

        public FrmModificarRegimen(AbmRol.frmMenuEmpleado form)
        {
            InitializeComponent();
            frmMenuEmpleado = form;
        }

        private void btnVolverMod_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuEmpleado.Show();
        }
    }
}
