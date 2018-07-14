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
    public partial class NuevoRolXHotel : Form
    {
        Form ultimoFormulario;
        Form menu;
        String usuario;
        DataTable tablaH;
        SqlDataReader reader, reader2;
        Char separacion = '-';

        public NuevoRolXHotel(Form seleccionarUsuario, Form formAnterior, String usuarioSeleccionado)
        {
            ultimoFormulario = formAnterior;
            menu = seleccionarUsuario;
            usuario = usuarioSeleccionado;
            InitializeComponent();
            llenarCboHotel();
            llenarCboRol();

        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void btnVolver_Click(object sender, EventArgs e)
        {
            ultimoFormulario.Show();
            this.Close();
        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*Lleno el combo box con todos los hoteles donde NO trabaja el usuario a actualizar*/
        private void llenarCboHotel() {
            String select = "SELECT hotel_calle, hotel_nroCalle FROM FAGD.Hotel WHERE hotel_codigo "
                          + "NOT IN (SELECT hotel_codigo FROM FAGD.UsuarioXRolXHotel WHERE '" + usuario + "' = usuario_username)";
            
            int fila = 0;
            tablaH = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta(select);
            while (fila < tablaH.Rows.Count)
            {
                cboHotel.Items.Add(tablaH.Rows[fila][0].ToString() + "-" + tablaH.Rows[fila][1].ToString());
                fila++;
            }

            tablaH.Clear();
        }


        /*lleno el combo box con todos los roles (exceptuando 'administrador general')*/
        private void llenarCboRol() {
            String select = "SELECT rol_nombre FROM FAGD.Rol WHERE rol_nombre <> 'Administrador general'";

            reader = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(select);

            DataTable tabla = new DataTable();
            tabla.Columns.Add("rol_nombre", typeof(string));
            tabla.Load(reader);

            cboRol.ValueMember = "rol_nombre";
            cboRol.DisplayMember = "rol_nombre";
            cboRol.DataSource = tabla;
        
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean exito = checkearCampos(); /*checkeo que los campos estén completos*/

            if (exito) { 
                String direccionHotelR = cboHotel.Text;
                string[] direccionHotel = direccionHotelR.Split(separacion);
                String calle = direccionHotel[0];
                String nro = direccionHotel[1];
                String rol = cboRol.Text;
    
                string exe = "EXEC FAGD.nuevoPuesto '" + usuario + "', '" + calle + "', '" + nro + "', '" + rol +"'";
                decimal resultado = 0;
                
                /*genero el nuevo puesto en el hotel ingresado*/
                reader2 = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(exe);
                if (reader2.Read())
                {
                    resultado = reader2.GetDecimal(0);
                }
                reader2.Close();
                /*Verifico posibles errores*/
                if (resultado == 0) MessageBox.Show("Hubo un error al crear el puesto.", "Error");
                else{
                    /*Notifico del éxito y vuelvo al menú de modificación*/
                    MessageBox.Show("Puesto guardado correctamente!", "Usuario Guardado");
                    menu.Show();
                    ultimoFormulario.Close();
                    this.Close();
                }
                
            }
          }
         
        private Boolean checkearCampos() {

            if (string.IsNullOrEmpty(cboHotel.Text) || string.IsNullOrEmpty(cboRol.Text)) {
                MessageBox.Show("Debe seleccionar un hotel y un rol a cumplir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else return true;

        }


    }
}
