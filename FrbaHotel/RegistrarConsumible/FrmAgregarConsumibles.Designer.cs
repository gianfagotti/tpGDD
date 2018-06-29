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
            this.LblRegistrarConsumibles = new System.Windows.Forms.Label();
            this.LblPrecioIndividual = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtPrecioIndividual = new System.Windows.Forms.TextBox();
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
            this.lblAllInclusive = new System.Windows.Forms.Label();
            this.cboInclusive = new System.Windows.Forms.CheckBox();
            this.LblCodigoEstadia = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtCodigoEst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoConsu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            // LblPrecioIndividual
            // 
            this.LblPrecioIndividual.AutoSize = true;
            this.LblPrecioIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioIndividual.Location = new System.Drawing.Point(22, 301);
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
            this.LblCantidad.Location = new System.Drawing.Point(22, 270);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(74, 16);
            this.LblCantidad.TabIndex = 11;
            this.LblCantidad.Text = "Cantidad:";
            this.LblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPrecioIndividual
            // 
            this.TxtPrecioIndividual.Location = new System.Drawing.Point(168, 266);
            this.TxtPrecioIndividual.Name = "TxtPrecioIndividual";
            this.TxtPrecioIndividual.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecioIndividual.TabIndex = 12;
            this.TxtPrecioIndividual.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(168, 300);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 14;
            // 
            // BtnAgregarConsumible
            // 
            this.BtnAgregarConsumible.Location = new System.Drawing.Point(599, 270);
            this.BtnAgregarConsumible.Name = "BtnAgregarConsumible";
            this.BtnAgregarConsumible.Size = new System.Drawing.Size(126, 40);
            this.BtnAgregarConsumible.TabIndex = 15;
            this.BtnAgregarConsumible.Text = "Agregar consumible";
            this.BtnAgregarConsumible.UseVisualStyleBackColor = true;
            this.BtnAgregarConsumible.Click += new System.EventHandler(this.BtnAgregarConsumible_Click);
            // 
            // BtnModificarConsumible
            // 
            this.BtnModificarConsumible.Location = new System.Drawing.Point(599, 316);
            this.BtnModificarConsumible.Name = "BtnModificarConsumible";
            this.BtnModificarConsumible.Size = new System.Drawing.Size(126, 39);
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
            this.dataGridView1.Location = new System.Drawing.Point(82, 374);
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
            this.BtnGuardarCambios.Location = new System.Drawing.Point(411, 539);
            this.BtnGuardarCambios.Name = "BtnGuardarCambios";
            this.BtnGuardarCambios.Size = new System.Drawing.Size(126, 23);
            this.BtnGuardarCambios.TabIndex = 18;
            this.BtnGuardarCambios.Text = "Guardar Cambios";
            this.BtnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(270, 539);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(126, 23);
            this.BtnVolver.TabIndex = 19;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
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
            // LblCodigoEstadia
            // 
            this.LblCodigoEstadia.AutoSize = true;
            this.LblCodigoEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoEstadia.Location = new System.Drawing.Point(296, 282);
            this.LblCodigoEstadia.Name = "LblCodigoEstadia";
            this.LblCodigoEstadia.Size = new System.Drawing.Size(118, 16);
            this.LblCodigoEstadia.TabIndex = 20;
            this.LblCodigoEstadia.Text = "Código estadía:";
            this.LblCodigoEstadia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(82, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 150);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txtCodigoEst
            // 
            this.txtCodigoEst.Location = new System.Drawing.Point(458, 281);
            this.txtCodigoEst.Name = "txtCodigoEst";
            this.txtCodigoEst.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEst.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Código consumible:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigoConsu
            // 
            this.txtCodigoConsu.Location = new System.Drawing.Point(458, 316);
            this.txtCodigoConsu.Name = "txtCodigoConsu";
            this.txtCodigoConsu.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoConsu.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Descripción:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(168, 335);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 29;
            // 
            // FrmAgregarConsumibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 587);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoConsu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoEst);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cboInclusive);
            this.Controls.Add(this.lblAllInclusive);
            this.Controls.Add(this.LblCodigoEstadia);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnGuardarCambios);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnModificarConsumible);
            this.Controls.Add(this.BtnAgregarConsumible);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtPrecioIndividual);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblPrecioIndividual);
            this.Controls.Add(this.LblRegistrarConsumibles);
            this.Name = "FrmAgregarConsumibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarConsumibles";
            this.Load += new System.EventHandler(this.FrmAgregarConsumibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegistrarConsumibles;
        private System.Windows.Forms.Label LblPrecioIndividual;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtPrecioIndividual;
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
        private System.Windows.Forms.Label lblAllInclusive;
        private System.Windows.Forms.CheckBox cboInclusive;
        private System.Windows.Forms.Label LblCodigoEstadia;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtCodigoEst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoConsu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}