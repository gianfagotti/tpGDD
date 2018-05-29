namespace FrbaHotel.RegistrarConsumible
{
    partial class FrmAgregarConsumibles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmbDescripcion = new System.Windows.Forms.ComboBox();
            this.LblRegistrarConsumibles = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblPrecioIndividual = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtPrecioIndividual = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.BtnAgregarConsumible = new System.Windows.Forms.Button();
            this.BtnModificarConsumible = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodigoDeEstadia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDeConsumible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.LblCodigoConsumible = new System.Windows.Forms.Label();
            this.TxtCodigoConsumible = new System.Windows.Forms.TextBox();
            this.lblAllInclusive = new System.Windows.Forms.Label();
            this.cboInclusive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbDescripcion
            // 
            this.CmbDescripcion.AutoCompleteCustomSource.AddRange(new string[] {
            "Papas Fritas Lays 60 grs.",
            "Porrón cerveza Quilmes 340 ml.",
            "Botella de agua Villavicencio 500 ml.",
            "Champagne Chandon Extra Brut 500 ml.",
            "Alfajor Fantoche",
            ""});
            this.CmbDescripcion.FormattingEnabled = true;
            this.CmbDescripcion.Location = new System.Drawing.Point(166, 86);
            this.CmbDescripcion.Name = "CmbDescripcion";
            this.CmbDescripcion.Size = new System.Drawing.Size(121, 21);
            this.CmbDescripcion.TabIndex = 0;
            // 
            // LblRegistrarConsumibles
            // 
            this.LblRegistrarConsumibles.AutoSize = true;
            this.LblRegistrarConsumibles.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblRegistrarConsumibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRegistrarConsumibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrarConsumibles.Location = new System.Drawing.Point(279, 9);
            this.LblRegistrarConsumibles.Name = "LblRegistrarConsumibles";
            this.LblRegistrarConsumibles.Size = new System.Drawing.Size(219, 22);
            this.LblRegistrarConsumibles.TabIndex = 2;
            this.LblRegistrarConsumibles.Text = "Registro De Consumibles:";
            this.LblRegistrarConsumibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(22, 87);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(95, 16);
            this.LblDescripcion.TabIndex = 8;
            this.LblDescripcion.Text = "Descripción:";
            this.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(301, 133);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(48, 16);
            this.LblTotal.TabIndex = 9;
            this.LblTotal.Text = "Total:";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPrecioIndividual
            // 
            this.LblPrecioIndividual.AutoSize = true;
            this.LblPrecioIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioIndividual.Location = new System.Drawing.Point(22, 133);
            this.LblPrecioIndividual.Name = "LblPrecioIndividual";
            this.LblPrecioIndividual.Size = new System.Drawing.Size(128, 16);
            this.LblPrecioIndividual.TabIndex = 10;
            this.LblPrecioIndividual.Text = "Precio Individual:";
            this.LblPrecioIndividual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblPrecioIndividual.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(301, 92);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(74, 16);
            this.LblCantidad.TabIndex = 11;
            this.LblCantidad.Text = "Cantidad:";
            this.LblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPrecioIndividual
            // 
            this.TxtPrecioIndividual.Location = new System.Drawing.Point(166, 132);
            this.TxtPrecioIndividual.Name = "TxtPrecioIndividual";
            this.TxtPrecioIndividual.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecioIndividual.TabIndex = 12;
            this.TxtPrecioIndividual.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(394, 132);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 13;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(394, 91);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 14;
            // 
            // BtnAgregarConsumible
            // 
            this.BtnAgregarConsumible.Location = new System.Drawing.Point(511, 129);
            this.BtnAgregarConsumible.Name = "BtnAgregarConsumible";
            this.BtnAgregarConsumible.Size = new System.Drawing.Size(126, 23);
            this.BtnAgregarConsumible.TabIndex = 15;
            this.BtnAgregarConsumible.Text = "Agregar consumible";
            this.BtnAgregarConsumible.UseVisualStyleBackColor = true;
            // 
            // BtnModificarConsumible
            // 
            this.BtnModificarConsumible.Location = new System.Drawing.Point(643, 129);
            this.BtnModificarConsumible.Name = "BtnModificarConsumible";
            this.BtnModificarConsumible.Size = new System.Drawing.Size(126, 23);
            this.BtnModificarConsumible.TabIndex = 16;
            this.BtnModificarConsumible.Text = "Modificar consumible";
            this.BtnModificarConsumible.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDeEstadia,
            this.Descripción,
            this.Precio,
            this.CodigoDeConsumible,
            this.Cantidad,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(76, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // CodigoDeEstadia
            // 
            this.CodigoDeEstadia.HeaderText = "Codigo de estadia";
            this.CodigoDeEstadia.Name = "CodigoDeEstadia";
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // CodigoDeConsumible
            // 
            this.CodigoDeConsumible.HeaderText = "Código de consumible";
            this.CodigoDeConsumible.Name = "CodigoDeConsumible";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // BtnGuardarCambios
            // 
            this.BtnGuardarCambios.Location = new System.Drawing.Point(403, 343);
            this.BtnGuardarCambios.Name = "BtnGuardarCambios";
            this.BtnGuardarCambios.Size = new System.Drawing.Size(126, 23);
            this.BtnGuardarCambios.TabIndex = 18;
            this.BtnGuardarCambios.Text = "Guardar Cambios";
            this.BtnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(271, 343);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(126, 23);
            this.BtnVolver.TabIndex = 19;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // LblCodigoConsumible
            // 
            this.LblCodigoConsumible.AutoSize = true;
            this.LblCodigoConsumible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoConsumible.Location = new System.Drawing.Point(508, 92);
            this.LblCodigoConsumible.Name = "LblCodigoConsumible";
            this.LblCodigoConsumible.Size = new System.Drawing.Size(62, 16);
            this.LblCodigoConsumible.TabIndex = 20;
            this.LblCodigoConsumible.Text = "Código:";
            this.LblCodigoConsumible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigoConsumible
            // 
            this.TxtCodigoConsumible.Location = new System.Drawing.Point(589, 92);
            this.TxtCodigoConsumible.Name = "TxtCodigoConsumible";
            this.TxtCodigoConsumible.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoConsumible.TabIndex = 21;
            // 
            // lblAllInclusive
            // 
            this.lblAllInclusive.AutoSize = true;
            this.lblAllInclusive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllInclusive.Location = new System.Drawing.Point(22, 52);
            this.lblAllInclusive.Name = "lblAllInclusive";
            this.lblAllInclusive.Size = new System.Drawing.Size(130, 16);
            this.lblAllInclusive.TabIndex = 22;
            this.lblAllInclusive.Text = "¿Es All-Inclusive?";
            this.lblAllInclusive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboInclusive
            // 
            this.cboInclusive.AutoSize = true;
            this.cboInclusive.Location = new System.Drawing.Point(168, 51);
            this.cboInclusive.Name = "cboInclusive";
            this.cboInclusive.Size = new System.Drawing.Size(37, 17);
            this.cboInclusive.TabIndex = 23;
            this.cboInclusive.Text = "Sí";
            this.cboInclusive.UseVisualStyleBackColor = true;
            // 
            // FrmAgregarConsumibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 390);
            this.Controls.Add(this.cboInclusive);
            this.Controls.Add(this.lblAllInclusive);
            this.Controls.Add(this.TxtCodigoConsumible);
            this.Controls.Add(this.LblCodigoConsumible);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnGuardarCambios);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnModificarConsumible);
            this.Controls.Add(this.BtnAgregarConsumible);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtPrecioIndividual);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblPrecioIndividual);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblRegistrarConsumibles);
            this.Controls.Add(this.CmbDescripcion);
            this.Name = "FrmAgregarConsumibles";
            this.Text = "FrmAgregarConsumibles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbDescripcion;
        private System.Windows.Forms.Label LblRegistrarConsumibles;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblPrecioIndividual;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtPrecioIndividual;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button BtnAgregarConsumible;
        private System.Windows.Forms.Button BtnModificarConsumible;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeEstadia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeConsumible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label LblCodigoConsumible;
        private System.Windows.Forms.TextBox TxtCodigoConsumible;
        private System.Windows.Forms.Label lblAllInclusive;
        private System.Windows.Forms.CheckBox cboInclusive;
    }
}