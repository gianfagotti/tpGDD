namespace FrbaHotel.FacturarEstadia
{
    partial class FrmFacturarEstadia
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblRegistrarConsumibles = new System.Windows.Forms.Label();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCheckout = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEgreso = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMontoConsu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescReg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMontoAloj = new System.Windows.Forms.TextBox();
            this.dgvAlojamiento = new System.Windows.Forms.DataGridView();
            this.dgvConsumibles = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalpago = new System.Windows.Forms.TextBox();
            this.btnProceder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compruebe que la información de facturación es correcta:";
            // 
            // LblRegistrarConsumibles
            // 
            this.LblRegistrarConsumibles.AutoSize = true;
            this.LblRegistrarConsumibles.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblRegistrarConsumibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRegistrarConsumibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrarConsumibles.Location = new System.Drawing.Point(280, 9);
            this.LblRegistrarConsumibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRegistrarConsumibles.Name = "LblRegistrarConsumibles";
            this.LblRegistrarConsumibles.Size = new System.Drawing.Size(195, 22);
            this.LblRegistrarConsumibles.TabIndex = 3;
            this.LblRegistrarConsumibles.Text = "Facturación de estadía";
            this.LblRegistrarConsumibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboMode
            // 
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Location = new System.Drawing.Point(463, 88);
            this.cboMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(221, 23);
            this.cboMode.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Modalidad de pago:";
            // 
            // txtEst
            // 
            this.txtEst.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEst.Location = new System.Drawing.Point(101, 88);
            this.txtEst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEst.Name = "txtEst";
            this.txtEst.ReadOnly = true;
            this.txtEst.Size = new System.Drawing.Size(193, 21);
            this.txtEst.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estadía:";
            // 
            // txtCheckout
            // 
            this.txtCheckout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckout.Location = new System.Drawing.Point(526, 121);
            this.txtCheckout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCheckout.Name = "txtCheckout";
            this.txtCheckout.ReadOnly = true;
            this.txtCheckout.Size = new System.Drawing.Size(158, 21);
            this.txtCheckout.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(380, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha de Check-out:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInicio.Location = new System.Drawing.Point(188, 121);
            this.txtFechaInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = true;
            this.txtFechaInicio.Size = new System.Drawing.Size(169, 21);
            this.txtFechaInicio.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fecha de admisión:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha de egreso:";
            // 
            // txtEgreso
            // 
            this.txtEgreso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEgreso.Location = new System.Drawing.Point(188, 153);
            this.txtEgreso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEgreso.Name = "txtEgreso";
            this.txtEgreso.ReadOnly = true;
            this.txtEgreso.Size = new System.Drawing.Size(156, 21);
            this.txtEgreso.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(387, 685);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 15);
            this.label13.TabIndex = 35;
            this.label13.Text = "Monto por consumiciones:";
            // 
            // txtMontoConsu
            // 
            this.txtMontoConsu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoConsu.Location = new System.Drawing.Point(609, 681);
            this.txtMontoConsu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMontoConsu.Name = "txtMontoConsu";
            this.txtMontoConsu.ReadOnly = true;
            this.txtMontoConsu.Size = new System.Drawing.Size(75, 21);
            this.txtMontoConsu.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 685);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Descuento por régimen de estadia:";
            // 
            // txtDescReg
            // 
            this.txtDescReg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescReg.Location = new System.Drawing.Point(297, 681);
            this.txtDescReg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescReg.Name = "txtDescReg";
            this.txtDescReg.ReadOnly = true;
            this.txtDescReg.Size = new System.Drawing.Size(75, 21);
            this.txtDescReg.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(365, 423);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "Monto por alojamiento:";
            // 
            // txtMontoAloj
            // 
            this.txtMontoAloj.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoAloj.Location = new System.Drawing.Point(552, 419);
            this.txtMontoAloj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMontoAloj.Name = "txtMontoAloj";
            this.txtMontoAloj.ReadOnly = true;
            this.txtMontoAloj.Size = new System.Drawing.Size(132, 21);
            this.txtMontoAloj.TabIndex = 30;
            // 
            // dgvAlojamiento
            // 
            this.dgvAlojamiento.AllowUserToAddRows = false;
            this.dgvAlojamiento.AllowUserToDeleteRows = false;
            this.dgvAlojamiento.AllowUserToOrderColumns = true;
            this.dgvAlojamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlojamiento.Location = new System.Drawing.Point(32, 202);
            this.dgvAlojamiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvAlojamiento.Name = "dgvAlojamiento";
            this.dgvAlojamiento.ReadOnly = true;
            this.dgvAlojamiento.Size = new System.Drawing.Size(653, 204);
            this.dgvAlojamiento.TabIndex = 27;
            // 
            // dgvConsumibles
            // 
            this.dgvConsumibles.AllowUserToAddRows = false;
            this.dgvConsumibles.AllowUserToDeleteRows = false;
            this.dgvConsumibles.AllowUserToOrderColumns = true;
            this.dgvConsumibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumibles.Location = new System.Drawing.Point(32, 458);
            this.dgvConsumibles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvConsumibles.Name = "dgvConsumibles";
            this.dgvConsumibles.ReadOnly = true;
            this.dgvConsumibles.Size = new System.Drawing.Size(653, 204);
            this.dgvConsumibles.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 723);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Total a pagar:";
            // 
            // txtTotalpago
            // 
            this.txtTotalpago.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalpago.Location = new System.Drawing.Point(501, 722);
            this.txtTotalpago.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalpago.Name = "txtTotalpago";
            this.txtTotalpago.ReadOnly = true;
            this.txtTotalpago.Size = new System.Drawing.Size(183, 21);
            this.txtTotalpago.TabIndex = 37;
            // 
            // btnProceder
            // 
            this.btnProceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceder.Location = new System.Drawing.Point(539, 760);
            this.btnProceder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProceder.Name = "btnProceder";
            this.btnProceder.Size = new System.Drawing.Size(147, 42);
            this.btnProceder.TabIndex = 40;
            this.btnProceder.Text = "Proceder al pago";
            this.btnProceder.UseVisualStyleBackColor = true;
            this.btnProceder.Click += new System.EventHandler(this.btnProceder_Click);
            // 
            // FrmFacturarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 812);
            this.Controls.Add(this.btnProceder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalpago);
            this.Controls.Add(this.dgvConsumibles);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMontoConsu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDescReg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMontoAloj);
            this.Controls.Add(this.dgvAlojamiento);
            this.Controls.Add(this.txtEgreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCheckout);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboMode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRegistrarConsumibles);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmFacturarEstadia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación de Estadia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblRegistrarConsumibles;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCheckout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEgreso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMontoConsu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDescReg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMontoAloj;
        private System.Windows.Forms.DataGridView dgvAlojamiento;
        private System.Windows.Forms.DataGridView dgvConsumibles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalpago;
        private System.Windows.Forms.Button btnProceder;
    }
}