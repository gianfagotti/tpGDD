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

namespace FrbaHotel.Login
{
    public partial class FrmSeleccionarHotel : Form
    {
        private DateTime fechaArchivoConfiguracion = FechaConfig.getDate();
        private DataTable tabla, tabla2, tabla3, tablaHotelesDeBaja, tablaHotelesDeAlta;
        private SqlDataReader resultado2, resultado;
        int Fila = 0;
        public static decimal codigoHotel;
        private decimal codigoRol;
        public string usuarioIngresado;
        public static String hotelSeleccionado;
        char guion = '-';
        private Decimal codigoHotelBaja;


        public FrmSeleccionarHotel(String usuario)
        {
            checkearHoteles();                                                                                                                                  //Se llama a esta funcion cada vez que se cargue este formulario, con el fin de actualizar, segun la fecha del app.config, el estado de los hoteles. (habilitado o inhabilitado)
            usuarioIngresado = usuario;
            InitializeComponent();

            tabla = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT DISTINCT [GD1C2018].[FAGD].[Hotel].[hotel_codigo] ,[hotel_calle],[hotel_nroCalle],[hotel_nombre],usuario_username  FROM [GD1C2018].[FAGD].[Hotel] JOIN [GD1C2018].[FAGD].[UsuarioXRolXHotel] ON([GD1C2018].[FAGD].[Hotel].hotel_codigo = [GD1C2018].[FAGD].[UsuarioXRolXHotel].hotel_codigo) WHERE usuario_username = '" + usuarioIngresado + "'");
            while (Fila < tabla.Rows.Count)
            {
                if (string.IsNullOrEmpty(tabla.Rows[Fila][3].ToString()))
                {
                    cboSeleccionarHotel.Items.Add(tabla.Rows[Fila][0].ToString() + "-" + tabla.Rows[Fila][1].ToString() + " " + tabla.Rows[Fila][2]);           //En esta seccion de codigo se cargan todos los hoteles del usuario logueado al combo box. Si sus hoteles asociados tienen un nombre, se carga el codigo del hotel, un guion, y dicho nombre; de no ser asi, se carga el codigo del hotel, un guion, la calle y altura.
                }
                else
                {
                    cboSeleccionarHotel.Items.Add(tabla.Rows[Fila][0].ToString() + "-" + tabla.Rows[Fila][3].ToString());
                }
                Fila++;
            }
            tabla.Clear();
        }

        private void lblHotelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptarHotel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboSeleccionarHotel.Text))
            {
                MessageBox.Show("Por favor, seleccione un hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                                                         //Se valida que se seleccione algun hotel.
            }
            else
            {
                hotelSeleccionado = cboSeleccionarHotel.Text;
                codigoHotel = Convert.ToDecimal(hotelSeleccionado.Split(guion)[0]);
                tabla2 = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT * FROM [GD1C2018].[FAGD].[Hotel] WHERE hotel_estado = " + 0 + "AND hotel_codigo = " + codigoHotel);
                if (tabla2.Rows.Count == 1)
                {
                    MessageBox.Show("El hotel está inhabilitado, tenga en cuenta que algunas funcionalidades se verán reducidas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Se obtiene el codigo del hotel seleccionado en el combo box. Si dicho hotel esta inhabilitado para la fecha actual del sistema, se le avisa al usuario que algunas funcionalidades estarán reducidas.
                }
                tabla3 = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT rol_nombre, FAGD.Rol.rol_codigo FROM FAGD.Rol JOIN FAGD.UsuarioXRolXHotel ON (FAGD.Rol.rol_codigo = FAGD.UsuarioXRolXHotel.rol_codigo) WHERE hotel_codigo = " + codigoHotel + " AND usuario_username = '" + usuarioIngresado + "'");
                if (tabla3.Rows.Count == 1)
                {
                    codigoRol = Convert.ToDecimal(tabla3.Rows[0][1]);
                    AbmRol.frmMenuEmpleado frmMenuEmpleado = new AbmRol.frmMenuEmpleado(codigoRol);                                                                                               //Se chequea la cantidad de roles asignados que tiene el usuario logueado para el hotel seleccionado con la BD. Si es uno solo, se entra a la aplicacion con dicho rol, de no ser asi, se abre el formulario que le permite seleccionar el rol deseado.
                    this.Close();
                    frmMenuEmpleado.Show();
                }
                else
                {
                    FrmSeleccionarRol frmSeleccionarRol = new FrmSeleccionarRol(codigoHotel, usuarioIngresado);
                    frmSeleccionarRol.Show();
                    this.Close();
                }
            }
        }

        private void BtnVolverHotel_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTipoUsuario frmTipoUsuario = new FrmTipoUsuario();
            frmTipoUsuario.Show();
        }

        private void checkearHoteles(){                                                                                                                                                              //Funcion que se encarga de actualizar los estados de todos los hoteles para la fecha actual.
                                                                                                                                                                                                     //Si en la fecha actual esta dado de baja, cambia su estado a 0, de no ser asi, lo popne en 1.
            string fecha = fechaArchivoConfiguracion.ToString("yyyy-MM-dd");

            tablaHotelesDeBaja = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT H.hotel_codigo FROM FAGD.Hotel H JOIN FAGD.BajaHotel B ON (H.hotel_codigo = B.hotel_codigo) WHERE H.hotel_estado = 1 AND (B.fecha_inicio <= '" + fecha + "' AND '" + fecha + "' <= B.fecha_fin)");    
            if (tablaHotelesDeBaja.Rows.Count >= 1)
            {
                int FilaHotelesBaja = 0;
                while (FilaHotelesBaja < tablaHotelesDeBaja.Rows.Count)
                {
                    codigoHotelBaja = Convert.ToDecimal(tablaHotelesDeBaja.Rows[FilaHotelesBaja][0]);
                    resultado2 = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("UPDATE FAGD.Hotel SET hotel_estado = 0 WHERE hotel_codigo = " + codigoHotelBaja);
                    resultado2.Read();
                    resultado2.Close();
                    FilaHotelesBaja++;
                }
            }

            tablaHotelesDeAlta = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta("SELECT H.hotel_codigo FROM FAGD.Hotel H JOIN FAGD.BajaHotel B ON (H.hotel_codigo = B.hotel_codigo) WHERE H.hotel_estado = 0 AND NOT (B.fecha_inicio <= '" + fecha + "') AND NOT ('" + fecha + "' <= B.fecha_fin)");
            if (tablaHotelesDeAlta.Rows.Count >= 1)
            {
                int FilaHotelesAlta = 0;
                Decimal codigoHotelAlta;
                while (FilaHotelesAlta < tablaHotelesDeAlta.Rows.Count)
                {
                    codigoHotelAlta = Convert.ToDecimal(tablaHotelesDeAlta.Rows[FilaHotelesAlta][0]);
                    resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando("UPDATE FAGD.Hotel SET hotel_estado = 1 WHERE hotel_codigo = " + codigoHotelAlta);
                    resultado.Read();
                    resultado.Close();
                    FilaHotelesAlta++;
                }
            }

        }
    }
}