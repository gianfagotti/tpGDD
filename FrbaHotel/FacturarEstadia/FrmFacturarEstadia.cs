using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.FacturarEstadia
{
    public partial class FrmFacturarEstadia : Form
    {
        string query;
        SqlDataReader infoQuery;
        DataTable tablaInfoAlojamiento;
        DataTable tablaInfoConsumibles;
        decimal modalidadDePagoElegida;
        decimal facturaEmitida;
        BindingSource bindingSource;
        AbmRol.frmMenuEmpleado menuAVolver;

        public FrmFacturarEstadia(string codigoEstadia, AbmRol.frmMenuEmpleado menu)
        {
            InitializeComponent();
            menuAVolver = menu;
            txtEst.Text = codigoEstadia;
            query = "SELECT DISTINCT modalidadPago_descripcion FROM FAGD.ModalidadPago";
            infoQuery = Login.FrmTipoUsuario.BD.comando(query);
            while (infoQuery.Read() == true)
            {
                cboMode.Items.Add(infoQuery.GetSqlString(0));
            }
            infoQuery.Close();
            query = "SELECT estadia_fechaInicio, estadia_fechaFin, estadia_diasSobrantes, estadia_cantNoches, estadia_precioNoche FROM FAGD.Estadia WHERE estadia_codigo = " + codigoEstadia;
            infoQuery = Login.FrmTipoUsuario.BD.comando(query);
            infoQuery.Read();
            DateTime fechaInicioEstadia = infoQuery.GetDateTime(0);
            DateTime fechaFinEstadia = infoQuery.GetDateTime(1);
            decimal diasSobrantes = infoQuery.GetDecimal(2);
            decimal cantNoches = infoQuery.GetDecimal(3);
            decimal precioNoche = infoQuery.GetDecimal(4);
            txtFechaInicio.Text = fechaInicioEstadia.ToString("yyyy-MM-dd HH:mm:ss");
            txtEgreso.Text = fechaInicioEstadia.AddDays(Convert.ToDouble(cantNoches + diasSobrantes)).ToString("yyyy-MM-dd HH:mm:ss");
            txtCheckout.Text = Login.FrmTipoUsuario.fechaAppConvertida;
            infoQuery.Close();
            tablaInfoAlojamiento = new DataTable();
            tablaInfoAlojamiento.Columns.Add("Fecha");
            tablaInfoAlojamiento.Columns.Add("Precio");
            tablaInfoAlojamiento.Columns.Add("Descripción del item");
            decimal contadorCantNoches = cantNoches;
            decimal contadorDiasSobrantes = diasSobrantes;
            DataRow fila = tablaInfoAlojamiento.NewRow();
            while (cantNoches > 0) //Se registran cada uno de los dias que los huéspedes efectivamente usaron de la estadia
            {
                fila = tablaInfoAlojamiento.NewRow();
                fila["Fecha"] = fechaInicioEstadia;
                fila["Precio"] = precioNoche;
                fila["Descripción del item"] = "Costo de Alojamiento";
                tablaInfoAlojamiento.Rows.Add(fila);
                fechaInicioEstadia = fechaInicioEstadia.AddDays(1);
                cantNoches--;
            }
            while (diasSobrantes > 0) //Se registran cada uno de los dias que los clientes no utilizaran al retirarse tempranamente del hotel, de ser así el suceso
            {
                fila = tablaInfoAlojamiento.NewRow();
                fila["Fecha"] = fechaInicioEstadia;
                fila["Precio"] = precioNoche;
                fila["Descripción del item"] = "Día no utilizado de la estadia";
                tablaInfoAlojamiento.Rows.Add(fila);
                fechaInicioEstadia = fechaInicioEstadia.AddDays(1);
                diasSobrantes--;
            }
            bindingSource = new BindingSource();
            bindingSource.DataSource = tablaInfoAlojamiento;
            dgvAlojamiento.DataSource = bindingSource;
            dgvAlojamiento.Columns[0].ReadOnly = true;
            dgvAlojamiento.Columns[1].ReadOnly = true;
            dgvAlojamiento.Columns[2].ReadOnly = true;
            txtMontoAloj.Text = (precioNoche * (contadorDiasSobrantes + contadorCantNoches)).ToString();
            //Se registran cada uno de los costos de consumibles almacenados en los item de Factura para luego revisar si se deducen en su totalidad por el regimen de estadía que el cliente contrató
            query = "SELECT item.itemFactura_cantidad Cantidad, item.itemFactura_descripcion Descripcion, item.itemFactura_itemMonto Monto FROM FAGD.ItemFactura item, FAGD.Factura fact WHERE item.itemFactura_nroFactura = fact.factura_nro AND item.itemFactura_descripcion != 'Estadia' AND fact.factura_codigoEstadia = " + codigoEstadia;
            SqlDataAdapter sAdapter = Login.FrmTipoUsuario.BD.dameDataAdapter(query);
            tablaInfoConsumibles = Login.FrmTipoUsuario.BD.dameDataTable(sAdapter);
            BindingSource BindingSource2 = new BindingSource();
            BindingSource2.DataSource = tablaInfoConsumibles;    
            dgvConsumibles.DataSource = BindingSource2;
            dgvConsumibles.Columns[0].ReadOnly = true;
            dgvConsumibles.Columns[1].ReadOnly = true;
            dgvConsumibles.Columns[2].ReadOnly = true;
            int montoAux = 0;
            foreach (DataRow otraFila in tablaInfoConsumibles.Rows)
            {
                int montoDelConsDeLaFila = Convert.ToInt32(otraFila["Monto"]);
                montoAux = montoAux + montoDelConsDeLaFila;
            }
            txtMontoConsu.Text = montoAux.ToString();


            //Se revisa el regimen de la estadia
            query = "SELECT R.reserva_codigoRegimen FROM FAGD.Reserva R, FAGD.Estadia est WHERE est.estadia_codigoReserva = R.reserva_codigo AND est.estadia_codigo = " + codigoEstadia;
            infoQuery = Login.FrmTipoUsuario.BD.comando(query);
            infoQuery.Read();
            decimal regimen = infoQuery.GetDecimal(0);
            infoQuery.Close();
            if (regimen == 3)  //Tiene descuento total por régimen All-Inclusive
            {
                txtDescReg.Text = "-" + txtMontoConsu.Text;
                txtTotalpago.Text = txtMontoAloj.Text;
            }
            else //No tiene descuento total
            {    
                txtDescReg.Text = "0";
                decimal totalAlojyConsum = Convert.ToDecimal(txtMontoAloj.Text) + Convert.ToDecimal(txtMontoConsu.Text);
                txtTotalpago.Text = (totalAlojyConsum).ToString();
            }



        }

        private void btnProceder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMode.Text))
            {
                MessageBox.Show("Para concretar la facturación es necesario que seleccione la modalidad con la que el cliente va a pagar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            query = "SELECT modalidadPago_codigo FROM FAGD.ModalidadPago WHERE modalidadPago_descripcion = '" + cboMode.Text + "'";
            infoQuery = Login.FrmTipoUsuario.BD.comando(query);
            infoQuery.Read();
            modalidadDePagoElegida = infoQuery.GetDecimal(0);
            infoQuery.Close();
            query = "EXEC FAGD.EmitirFacturaActualizada '" + txtEst.Text + "','" + modalidadDePagoElegida.ToString() + "','" + Login.FrmTipoUsuario.fechaAppConvertida + "'";
            infoQuery = Login.FrmTipoUsuario.BD.comando(query);
            infoQuery.Read();
            facturaEmitida = infoQuery.GetDecimal(0);
            if (facturaEmitida == 0)
            {
                infoQuery.Close();
                MessageBox.Show("La factura no pudo ser emitida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            infoQuery.Close();
            if (modalidadDePagoElegida == 2)
            {
                FrmPagoTarjeta pagoTarjeta = new FrmPagoTarjeta(facturaEmitida.ToString(), menuAVolver);
                pagoTarjeta.Show();
            }
            MessageBox.Show("Se ha emitido la factura correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
