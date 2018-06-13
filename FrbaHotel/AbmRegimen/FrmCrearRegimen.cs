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
    public partial class FrmCrearRegimen : Form
    {
        AbmRol.frmMenuEmpleado frmMenuAnterior;

        public FrmCrearRegimen(AbmRol.frmMenuEmpleado menuAnterior)
        {
            InitializeComponent();
            frmMenuAnterior = menuAnterior;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuAnterior.Show();
        }
    }
}
