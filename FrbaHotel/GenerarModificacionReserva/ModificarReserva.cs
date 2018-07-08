using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class ModificarReserva : Form
    {
        Form abmPadre = new Form();

        public ModificarReserva(Form form, string codigoReserva)
        {
            InitializeComponent();
            abmPadre = form;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            abmPadre.Show();
        }
        }
    }

