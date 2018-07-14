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
        Form menu;
        String usuario;
        String direccion;
        Boolean alta;
        Char separacion = '-';
        SqlDataReader reader;
        String calle;
        String nro;
        String rol;


        public SeleccionarRol(Form seleccionarUsuario ,Form formAnterior, String usuarioSeleccionado, String hotel, Boolean habilitarAlta)
        {
            ultimoFormulario = formAnterior;
            menu = seleccionarUsuario;
            usuario = usuarioSeleccionado;
            alta = habilitarAlta;
            direccion = hotel;

            InitializeComponent();

            String direccionHotelR = direccion;
            string[] direccionHotel = direccionHotelR.Split(separacion);
            calle = direccionHotel[0];
            nro = direccionHotel[1];

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
            if (String.IsNullOrEmpty(cboRol.Text)) MessageBox.Show("Seleccione un rol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                String exe = crearConsulta();
                decimal resultado = 0;
                reader = Login.FrmTipoUsuario.BD.comando(exe);

                if (reader.Read())
                {
                    resultado = reader.GetDecimal(0);
                }
                reader.Close();

                if (alta)
                {
                    if (resultado == 0) MessageBox.Show("Hubo un error al guardar el puesto.", "Error");
                    else MessageBox.Show("Puesto guardado correctamente!", "Usuario Guardado");
                    menu.Show();
                    this.Close();
                }
                else
                {
                    if (resultado == 0) MessageBox.Show("Hubo un error al borrar el puesto.", "Error");
                    else
                    {
                        MessageBox.Show("Puesto borrado correctamente!", "Usuario Guardado");
                        menu.Show();
                        this.Close();
                    }
                }
            }
        }

        private String crearConsulta(){
            rol = cboRol.Text;
            String consulta;
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

            String select = "SELECT rol_nombre FROM FAGD.Rol WHERE rol_nombre <> 'Administrador General' AND ";

            if (alta){
                select = select + "rol_codigo NOT IN (SELECT rol_codigo FROM FAGD.UsuarioXRolXHotel WHERE usuario_username = '"
                                + usuario + "' AND hotel_codigo = (SELECT hotel_codigo FROM FAGD.Hotel WHERE hotel_calle = '"
                                + calle +"' AND hotel_nroCalle = '" + nro + "'))";
            }
            else {
                select = select + "rol_codigo IN (SELECT rol_codigo FROM FAGD.UsuarioXRolXHotel WHERE usuario_username = '"
                                + usuario + "' AND hotel_codigo = (SELECT hotel_codigo FROM FAGD.Hotel WHERE hotel_calle = '"
                                + calle + "' AND hotel_nroCalle = '" + nro + "'))";
            }

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
