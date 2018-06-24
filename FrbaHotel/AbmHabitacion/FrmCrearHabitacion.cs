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
    public partial class FrmCrearHabitacion : Form
    {
        Form abm;

        public FrmCrearHabitacion(Form abmPadre)
        {
            InitializeComponent();
            abm = abmPadre;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            abm.Show();
        }
    }
}
