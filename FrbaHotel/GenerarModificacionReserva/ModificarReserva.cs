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
        public ModificarReserva()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
      
            this.Hide();
            DisponibilidadReserva frmDisponibilidadReserva = new DisponibilidadReserva();
            frmDisponibilidadReserva.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuesUsuarios.frmMenuCliente frmMenuCliente = new MenuesUsuarios.frmMenuCliente();
            this.Hide();
            frmMenuCliente.ShowDialog();
        }
        }
    }

