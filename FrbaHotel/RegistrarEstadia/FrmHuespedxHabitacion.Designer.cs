namespace FrbaHotel.RegistrarEstadia
{
    partial class FrmHuespedxHabitacion
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantHab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnroHab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvDistri = new System.Windows.Forms.DataGridView();
            this.Elegir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbohab = new System.Windows.Forms.ComboBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistri)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Cantidad de huéspedes permitidos:";
            // 
            // txtCantHab
            // 
            this.txtCantHab.Location = new System.Drawing.Point(356, 113);
            this.txtCantHab.Name = "txtCantHab";
            this.txtCantHab.ReadOnly = true;
            this.txtCantHab.Size = new System.Drawing.Size(32, 20);
            this.txtCantHab.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Elija los huéspedes para la habitación:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(56, 145);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(89, 20);
            this.txtTipo.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nro:";
            // 
            // txtnroHab
            // 
            this.txtnroHab.Location = new System.Drawing.Point(56, 113);
            this.txtnroHab.Name = "txtnroHab";
            this.txtnroHab.ReadOnly = true;
            this.txtnroHab.Size = new System.Drawing.Size(55, 20);
            this.txtnroHab.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Habitación:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(149, 400);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 29);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvDistri
            // 
            this.dgvDistri.AllowUserToAddRows = false;
            this.dgvDistri.AllowUserToDeleteRows = false;
            this.dgvDistri.AllowUserToOrderColumns = true;
            this.dgvDistri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir});
            this.dgvDistri.Location = new System.Drawing.Point(18, 214);
            this.dgvDistri.Name = "dgvDistri";
            this.dgvDistri.ReadOnly = true;
            this.dgvDistri.Size = new System.Drawing.Size(372, 168);
            this.dgvDistri.TabIndex = 28;
            this.dgvDistri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDistri_CellContentClick);
            // 
            // Elegir
            // 
            this.Elegir.HeaderText = "Elegir";
            this.Elegir.Name = "Elegir";
            this.Elegir.ReadOnly = true;
            this.Elegir.Text = "Seleccionar";
            this.Elegir.UseColumnTextForButtonValue = true;
            // 
            // cbohab
            // 
            this.cbohab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbohab.FormattingEnabled = true;
            this.cbohab.Location = new System.Drawing.Point(105, 79);
            this.cbohab.Name = "cbohab";
            this.cbohab.Size = new System.Drawing.Size(191, 21);
            this.cbohab.TabIndex = 27;
            this.cbohab.SelectedIndexChanged += new System.EventHandler(this.cbohab_SelectedIndexChanged);
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(204, 145);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.ReadOnly = true;
            this.txtPiso.Size = new System.Drawing.Size(54, 20);
            this.txtPiso.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Piso:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 38);
            this.label7.TabIndex = 42;
            this.label7.Text = "Organice a los huéspedes en las habitaciones reservadas:";
            // 
            // FrmHuespedxHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 441);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantHab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnroHab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvDistri);
            this.Controls.Add(this.cbohab);
            this.Name = "FrmHuespedxHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organización de clientes";
            this.Load += new System.EventHandler(this.DistribClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantHab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnroHab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvDistri;
        private System.Windows.Forms.DataGridViewButtonColumn Elegir;
        private System.Windows.Forms.ComboBox cbohab;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}