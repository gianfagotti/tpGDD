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
    public partial class AltaRol : Form
    {
        Form ultimoFormulario;
        SqlDataReader resultado;
        SqlDataAdapter adapter;
        DataTable tabla;
       
        public AltaRol(Form form)
        {
            InitializeComponent();
            ultimoFormulario = form;

            /*carga de la DGV con todas las funcionalidades existentes*/
            String select = "SELECT * FROM FAGD.Funcionalidad";
            adapter = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataAdapter(select);
            tabla = Login.FrmTipoUsuario.conexionBaseDeDatos.dameDataTable(adapter);
            BindingSource bindSource = new BindingSource();
            bindSource.DataSource = tabla;
            dgvFuncionalidades.DataSource = bindSource;

            /*Imposibilito la posibilidad de alterar los campos*/
            dgvFuncionalidades.Columns[1].ReadOnly = true;
            dgvFuncionalidades.Columns[2].ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            ultimoFormulario.Show();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            /*CREACION DEL ROL*/
            /*----------------*/
            /*Verificacion de llenado del txtbox con el nombre del rol*/
            if (String.IsNullOrEmpty(txtNombreRol.Text))
            {
                MessageBox.Show("El Rol debe tener un nombre.");
            }
            else
            {
                /*Ejecuto el procedimiento para insertar un nuevo rol, enviando como parametros el nombre y el estado*/
                String exe = "EXEC FAGD.nuevoRol '" + txtNombreRol.Text + "', ";
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

                if (mensaje == 0)
                {
                    MessageBox.Show("Ya existe un rol con ese nombre.");
                }

                else if (mensaje == 2)
                {
                    MessageBox.Show("Error al guardar el Rol.");
                }


                /*LINKEO DE FUNCIONALIDADES CON EL ROL INGRESADO*/
                else
                {
                    foreach (DataGridViewRow row in dgvFuncionalidades.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[columnaHabilitar.Name].Value) == true)
                        {
                            String codigoFuncionalidad = row.Cells[1].Value.ToString();

                            /*Bloqueo la posibilidad de que el rol pueda administrar usuarios (solo disponible para administradores)*/
                            if (codigoFuncionalidad == "8")
                            {
                                MessageBox.Show("El manejo de usuarios solo puede llevarse a cabo por los Administradores. Se procederá a guardar el resto de las funcionalidades seleccionadas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                /*Inserto 1x1 las funcionalidades seleccionadas en el DGV en la tabla RolXFuncionalidad*/
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

                    /*En caso de éxito, reseteo el formulario y le aviso al usuario*/
                  
                    MessageBox.Show("Rol guardado correctamente!");
                    txtNombreRol.Clear();
                    chkRolActivo.Checked = false;
                    foreach (DataGridViewRow row in dgvFuncionalidades.Rows)
                    {
                        row.Cells[columnaHabilitar.Name].Value = false;
                    }

                }
            }
        }
    }
}