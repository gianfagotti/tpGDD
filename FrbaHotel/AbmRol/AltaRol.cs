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
        //public static Conector2 BD1 = new Conector2();


        public AltaRol(Form form)
        {
            InitializeComponent();
            ultimoFormulario = form;

            /*carga de la DGV*/
            String select = "SELECT * FROM FAGD.Funcionalidad";
            adapter = Login.FrmTipoUsuario.BD.dameDataAdapter(select);
            tabla = Login.FrmTipoUsuario.BD.dameDataTable(adapter);
            BindingSource bindSource = new BindingSource();
            bindSource.DataSource = tabla;
            dgvFuncionalidades.DataSource = bindSource;
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
            if (String.IsNullOrEmpty(txtNombreRol.Text))
            {
                MessageBox.Show("El Rol debe tener un nombre.");
            }
            else
            {
                String exe = "EXEC FAGD.nuevoRol '" + txtNombreRol.Text + "', ";
                if (chkRolActivo.Checked)
                     exe = exe + "1";
                else exe = exe + "0";

                decimal mensaje = 0;
                resultado = Login.FrmTipoUsuario.BD.comando(exe);
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


                /*LINKEO DE FUNCIONALIDADES*/
                else
                {
                    foreach (DataGridViewRow row in dgvFuncionalidades.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[columnaHabilitar.Name].Value) == true)
                        {

                            String codigoFuncionalidad = row.Cells[1].Value.ToString();
                            exe = "EXEC FAGD.funcionalidadesDelRol '" + txtNombreRol.Text + "', '" + codigoFuncionalidad + "'";
                            resultado = Login.FrmTipoUsuario.BD.comando(exe);
                            
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