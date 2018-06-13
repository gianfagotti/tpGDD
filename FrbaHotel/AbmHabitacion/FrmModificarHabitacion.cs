using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion
{
    public partial class FrmModificarHabitacion : Form
    {
        AbmRol.frmMenuEmpleado frmMenuEmpleado;

        public FrmModificarHabitacion(AbmRol.frmMenuEmpleado form)
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
