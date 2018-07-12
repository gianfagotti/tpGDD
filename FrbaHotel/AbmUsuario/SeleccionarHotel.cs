using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FrbaHotel.AbmUsuario
{
    public partial class SeleccionarHotel : Form
    {
        Form ultimoFormulario;
        String usuario;
        Boolean alta;
        DataTable tablaH;

        public SeleccionarHotel(Form formAnterior, String usuarioSeleccionado, Boolean habilitarNuevo)
        {
            ultimoFormulario = formAnterior;
            usuario = usuarioSeleccionado;
            alta = habilitarNuevo;
            InitializeComponent();
            llenarCbo(alta);
            if (alta) btnHotel.Enabled = true;
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ultimoFormulario.Show();
            this.Close();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            NuevoRolXHotel frm = new NuevoRolXHotel(ultimoFormulario,this, usuario);
            this.Hide();
            frm.Show();

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboHotel.Text)) MessageBox.Show("Seleccione un hotel!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else{
                String hotel = cboHotel.Text;
                SeleccionarRol frm = new SeleccionarRol(ultimoFormulario, this, usuario, hotel, alta);
                this.Hide();
                frm.Show();
            }
        }

        private void llenarCbo(Boolean alta) {

            String select = "SELECT hotel_calle, hotel_nroCalle FROM FAGD.Hotel ";
      //      if (alta)
      //      {
      //          select = select + "WHERE hotel_codigo NOT IN (SELECT hotel_codigo FROM FAGD.UsuarioXRolXHotel WHERE '" + usuario + "' ="
      //                          + "usuario_username)";
      //      }
      //      else {
                select = select + "WHERE hotel_codigo IN (SELECT hotel_codigo FROM FAGD.UsuarioXRolXHotel WHERE '" + usuario + "' = "
                                + "usuario_username)";
      //      }

            int fila = 0;
            tablaH = Login.FrmTipoUsuario.BD.consulta(select);
            while (fila < tablaH.Rows.Count)
            {
                cboHotel.Items.Add(tablaH.Rows[fila][0].ToString() + "-" + tablaH.Rows[fila][1].ToString());
                fila++;
            }

            tablaH.Clear();
        
        }
    }
}
