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
        decimal facturaParaActualizar;
        BindingSource bindingSource;

        public FrmFacturarEstadia(string codigoEstadia)
        {
            InitializeComponent();
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
            txtFechaInicio.Text = fechaInicioEstadia.ToShortDateString();
            txtEgreso.Text = fechaInicioEstadia.AddDays(Convert.ToDouble(cantNoches + diasSobrantes)).ToShortDateString();
            txtCheckout.Text = fechaFinEstadia.ToShortDateString();
            infoQuery.Close();
            tablaInfoAlojamiento = new DataTable();
            tablaInfoAlojamiento.Columns.Add("Fecha");
            tablaInfoAlojamiento.Columns.Add("Precio");
            tablaInfoAlojamiento.Columns.Add("Descripcion del item");
            decimal auxCantNoches = cantNoches;
            decimal auxDiasSobrantes = diasSobrantes;
            DataRow row = tablaInfoAlojamiento.NewRow();
            while (cantNoches > 0) //Se registran cada uno de los dias que los clientes efectivamente usaron de la estadia
            {
                row = tablaInfoAlojamiento.NewRow();
                row["Fecha"] = fechaInicioEstadia;
                row["Precio"] = precioNoche;
                row["Descripcion del item"] = "Costo de Alojamiento";
                tablaInfoAlojamiento.Rows.Add(row);
                fechaInicioEstadia = fechaInicioEstadia.AddDays(1);
                cantNoches--;
            }
            while (diasSobrantes > 0) //Se registran cada uno de los dias que los clientes no utilizaran al retirarse tempranamente del hotel, de ser así el suceso
            {
                row = tablaInfoAlojamiento.NewRow();
                row["Fecha"] = fechaInicioEstadia;
                row["Precio"] = precioNoche;
                row["Descripcion"] = "Día no utilizado de la estadia";
                tablaInfoAlojamiento.Rows.Add(row);
                fechaInicioEstadia = fechaInicioEstadia.AddDays(1);
                diasSobrantes--;
            }
            bindingSource = new BindingSource();
            bindingSource.DataSource = tablaInfoAlojamiento;
            dgvAlojamiento.DataSource = bindingSource;
            txtMontoAloj.Text = (precioNoche * (auxDiasSobrantes + auxCantNoches)).ToString();
            //Se registran cada uno de los costos de consumibles almacenados en los item de Factura para luego revisar si se deducen en su totalidad por el regimen de estadía que el cliente contrató
            query = "SELECT item.itemFactura_cantidad Cantidad, item.itemFactura_descripcion Descripcion, item.itemFactura_itemMonto Monto FROM FAGD.ItemFactura item, FAGD.Factura fact WHERE item.itemFactura_nroFactura = fact.factura_nro AND item.itemFactura_descripcion != 'Estadia' AND fact.factura_codigoEstadia = " + codigoEstadia;
            SqlDataAdapter sAdapter = Login.FrmTipoUsuario.BD.dameDataAdapter(query);
            tablaInfoConsumibles = Login.FrmTipoUsuario.BD.dameDataTable(sAdapter);
            BindingSource BindingSource2 = new BindingSource();
            BindingSource2.DataSource = tablaInfoConsumibles;    
            dgvConsumibles.DataSource = BindingSource2;

            query = "select cons.consumible_precio FROM FAGD.ConsumibleXEstadia consXEst, FAGD.Consumible cons WHERE consXEst.consumible_codigo = cons.consumible_codigo AND consXEst.estadia_codigo = " + codigoEstadia;
            infoQuery = Login.FrmTipoUsuario.BD.comando(query);
            if (infoQuery.Read() == true)
            {
                infoQuery.Close();
                query = "SELECT SUM(con.consumible_precio) FROM FAGD.ConsumibleXEstadia consXEst, FAGD.Consumible cons WHERE consXEst.consumible_codigo = cons.consumible_codigo AND consXEst.estadia_codigo = " + codigoEstadia;
                infoQuery.Read();
                txtMontoConsu.Text = infoQuery.GetDecimal(0).ToString();
            }
            else
            {
                txtMontoConsu.Text = 0.ToString();
            }
            infoQuery.Close();

            query = "SELECT res.reserva_codigoRegimen FROM FAGD.Reserva res, FAGD.Estadia est WHERE est.estadia_codigoReserva = res.reserva_codigo AND est.estadia_codigo = " + codigoEstadia;
            infoQuery = Login.FrmTipoUsuario.BD.comando(query);
            infoQuery.Read();
            decimal regimen = infoQuery.GetDecimal(0);
            infoQuery.Close();
            if (regimen == 3)  //Tiene descuento total por régimen All-Inclusive
            {
                txtDescReg.Text = "-" + txtMontoConsu.Text;
                txtTotalpago.Text = txtMontoAloj.Text;
            }
            else //No tiene descuento
            {    
                txtDescReg.Text = 0.ToString();
                decimal totalAlojyConsum = Convert.ToDecimal(txtMontoAloj.Text) + Convert.ToDecimal(txtMontoConsu.Text);
                txtTotalpago.Text = (totalAlojyConsum).ToString();
            }



        }

        private void btnProceder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMode.Text))
            {
                MessageBox.Show("Para proceder al pago es necesario que primero seleccione la modalidad con la que el cliente va a efectuarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            query = "SELECT modalidadPago_codigo FROM FAGD.ModalidadPago WHERE modalidadPago_descripcion = '" + cboMode.Text + "'";
            infoQuery = Login.FrmTipoUsuario.BD.comando(query);
            infoQuery.Read();
            modalidadDePagoElegida = infoQuery.GetDecimal(0);
            infoQuery.Close();
            query = "EXEC FAGD.ActualizarFactura " + txtEst.Text + "," + modalidadDePagoElegida.ToString() + ",'" + Login.FrmTipoUsuario.fechaApp + "'";
            infoQuery = Login.FrmTipoUsuario.BD.comando(query);
            infoQuery.Read();
            facturaParaActualizar = infoQuery.GetDecimal(0);
            if (facturaParaActualizar == 0)
            {
                infoQuery.Close();
                MessageBox.Show("La factura ya está generada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            infoQuery.Close();
            if (modalidadDePagoElegida == 2)
            {
                //ver para pagar con la tarjeta de credito/debito
            }
            MessageBox.Show("Se ha actualizado la factura correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
