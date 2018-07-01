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
    public partial class SeleccionarRol : Form
    {
        Form ultimoFormulario;
        String usuario;
        String direccion;
        Boolean alta;
        Char separacion = '-';
        SqlDataReader reader;


        public SeleccionarRol(Form formAnterior, String usuarioSeleccionado, String hotel, Boolean habilitarAlta)
        {
            ultimoFormulario = formAnterior;
            usuario = usuarioSeleccionado;
            alta = habilitarAlta;
            direccion = hotel;
            InitializeComponent();
            llenarCboRol();
            if (alta) lblDescripcion.Text = "Seleccione un rol a desempeñar en el hotel";
            else lblDescripcion.Text = "Seleccione el rol que dejará de desempeñar en el hotel";

        }

        private void btnVolver_Click(object sender, EventArgs e){
            ultimoFormulario.Show();
            this.Close();
           

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String exe = crearConsulta();

            decimal resultado = 0;
            reader = Login.FrmTipoUsuario.BD.comando(exe);

            if (reader.Read())
            {
                resultado = reader.GetDecimal(0);
            }
            reader.Close();

            if (alta){
                if (resultado == 0) MessageBox.Show("Hubo un error al guardar el puesto.", "Error");
                else MessageBox.Show("Puesto guardado correctamente!", "Usuario Guardado");
            }
            else{
                if (resultado == 0) MessageBox.Show("Hubo un error al borrar el puesto.", "Error");
                else MessageBox.Show("Puesto borrado correctamente!", "Usuario Guardado");
            }
        }

        private String crearConsulta(){

            String consulta;
            String direccionHotelR = direccion;
            string[] direccionHotel = direccionHotelR.Split(separacion);
            String calle = direccionHotel[0];
            String nro = direccionHotel[1];
            String rol = cboRol.Text;

            if (alta){
                consulta = "EXEC FAGD.nuevoPuesto '" + usuario + "', '" + calle + "', '" + nro + "', '" + rol + "'";
                return consulta;
            }
            else {
                consulta = "EXEC FAGD.borrarPuesto '" + usuario + "', '" + calle + "', '" + nro + "', '" + rol + "'";
                return consulta;
            }
    }

        private void llenarCboRol() {

            String select = "SELECT rol_nombre FROM FAGD.Rol";
            reader = Login.FrmTipoUsuario.BD.comando(select);

            DataTable tabla = new DataTable();
            tabla.Columns.Add("rol_nombre", typeof(string));
            tabla.Load(reader);

            cboRol.ValueMember = "rol_nombre";
            cboRol.DisplayMember = "rol_nombre";
            cboRol.DataSource = tabla;
        }
    }
}
