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

namespace FrbaHotel.AbmRol
{
    public partial class ModificarRol : Form
    {
        Form ultimoFormulario;
        SqlDataReader resultado;
        SqlDataAdapter adapter;
        DataTable tabla, tabla2;
        DataTable tablaChk;
        String rolAModificar;

        public ModificarRol(Form form, String rolSeleccionado)
        {
            rolAModificar = rolSeleccionado;
            ultimoFormulario = form;

            InitializeComponent();

            txtNombreRol.Text = rolSeleccionado;
            cargarDGV(rolSeleccionado); /*Carga la DGV con todas las funcionalidades disponibles*/
            ckeckearEstado(rolSeleccionado); /*tilda el checkbox segun si el usuario se encuentra activo o no*/

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /****************************************************************************************************************************/

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            ultimoFormulario.Show();
        }

        /****************************************************************************************************************************/
        
        private void cargarDGV(String rolSeleccionado)
        {
            String select = "SELECT * FROM FAGD.Funcionalidad ORDER BY funcionalidad_codigo ASC";
            adapter = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataAdapter(select);
            tabla = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataTable(adapter);
            BindingSource bindSource = new BindingSource();
            bindSource.DataSource = tabla;
            dgvFuncionalidades.DataSource = bindSource;
            dgvFuncionalidades.Columns[1].ReadOnly = true;
            dgvFuncionalidades.Columns[2].ReadOnly = true;
        }

        /*Checkea los checkboxes de la DGV según las funcionalidades registradas en el rol*/
        private void checkearDGV(String rolSeleccionado)
        {
            String select = "SELECT funcionalidad_codigo FROM FAGD.RolXFuncionalidad WHERE rol_codigo = (SELECT rol_codigo FROM "
                           + "FAGD.Rol WHERE rol_nombre = '" + rolSeleccionado + "')";
            tabla2 = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta(select);

            if (tabla2.Rows.Count > 0)
            {
                Decimal cod_funcionalidad = 0;
                foreach (DataRow row in tabla2.Rows)
                {
                    cod_funcionalidad = (Decimal)row["funcionalidad_codigo"];
                    dgvFuncionalidades.Rows[(int)cod_funcionalidad - 1].Cells[columnaHabilitar.Name].Value = true;
                }
            }
        }



        /****************************************************************************************************************************/
        private void ckeckearEstado(String rolSeleccionado)
        {
            String select = "SELECT rol_estado FROM FAGD.Rol WHERE rol_nombre = '" + rolSeleccionado + "'";
            tablaChk = Login.FrmTipoUsuario.conexionBaseDeDatos.consulta(select);
            if (tablaChk.Rows.Count == 1)
            {
                if ((bool)tablaChk.Rows[0][0]) chkRolActivo.Checked = true;
            }

        }

        /*****************************************************************************************************************************/

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombreRol.Text))
            {
                MessageBox.Show("El Rol debe tener un nombre.");
            }
            /*Ejecuto la funcion para modificar el rol, enviando su nombre anterior y el ingresado actualmente como parámetros, además del estado del rol*/
            String nombreNuevo = txtNombreRol.Text;
            String exe = "EXEC FAGD.updatearRol '" + rolAModificar + "', '" + nombreNuevo + "', ";
            if (chkRolActivo.Checked)
                exe = exe + "1";
            else exe = exe + "0";

            decimal mensaje = 0;
            resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(exe);
            if (resultado.Read())
            {
                mensaje = resultado.GetDecimal(0);
            }

            resultado.Close();
            /*verifico posibles errores*/
            if (mensaje == 2) { MessageBox.Show("Ya existe un rol con ese nombre."); }
            else if (mensaje == 0) { MessageBox.Show("Error al modificar el Rol."); }
            /*De no mediar inconvenientes, continúo a modificar la tabla RolXFuncionalidad*/
            else
            {
                /*Primero se borran las relaciones del rol anteriores a la modificación*/
                exe = "EXEC FAGD.limpiarFuncionalidades '" + rolAModificar + "'";
                mensaje = 0;
                resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(exe);
                if (resultado.Read())
                {
                    mensaje = resultado.GetDecimal(0);
                }

                resultado.Close();

                if (mensaje == 0) { MessageBox.Show("Error al limpiar funcionalidades."); }

                
                else
                {
                    foreach (DataGridViewRow row in dgvFuncionalidades.Rows)
                    {

                        if (Convert.ToBoolean(row.Cells[columnaHabilitar.Name].Value) == true)
                        {
                            /*Verifico que el abmUsuarios sea solo utilizable por los administradores*/
                            String codigoFuncionalidad = row.Cells[1].Value.ToString();
                            if (codigoFuncionalidad == "8" && rolAModificar != "Administrador")
                            {
                                MessageBox.Show("El manejo de usuarios solo puede llevarse a cabo por los Administradores. Se procederá a guardar el resto de las funcionalidades seleccionadas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                /*Y luego se insertan las relaciones seleccionadas*/
                                exe = "EXEC FAGD.funcionalidadesDelRol '" + txtNombreRol.Text + "', '" + codigoFuncionalidad + "'";
                                resultado = Login.FrmTipoUsuario.conexionBaseDeDatos.comando(exe);

                                if (resultado.Read())
                                {
                                    mensaje = resultado.GetDecimal(0);
                                }
                                resultado.Close();

                                if (mensaje == 0)
                                {
                                    MessageBox.Show("Error al linkear el rol con las funcionalidades.");
                                }
                            }
                        }
                    }

                    MessageBox.Show("Rol guardado correctamente!");
                    limpiarCampos();
                    this.Close();
                    ultimoFormulario.Show();
                }
            }
        }
        /*****************************************************************************************************************************/


        private void limpiarCampos()
        {
            txtNombreRol.Clear();
            chkRolActivo.Checked = false;
            foreach (DataGridViewRow row in dgvFuncionalidades.Rows)
            {
                row.Cells[columnaHabilitar.Name].Value = false;
            }

        }

        private void ModificarRol_Load(object sender, EventArgs e){
            checkearDGV(rolAModificar); /*El checkeo de la DGV debe realizarse en la carga del formulario debido a que de otra manera, el procedimiento no cumple su trabajo debidamente*/
        }

    }
            

}
