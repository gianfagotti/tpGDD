namespace FrbaHotel.RegistrarEstadia
{
    partial class DistribClientes
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
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pisp = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnroHab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvDistri = new System.Windows.Forms.DataGridView();
            this.Elegir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbohab = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistri)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Cant huéspedes:";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(179, 128);
            this.txtCant.Name = "txtCant";
            this.txtCant.ReadOnly = true;
            this.txtCant.Size = new System.Drawing.Size(29, 20);
            this.txtCant.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Seleccione un cliente para la habitación:";
            // 
            // pisp
            // 
            this.pisp.AutoSize = true;
            this.pisp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pisp.Location = new System.Drawing.Point(253, 56);
            this.pisp.Name = "pisp";
            this.pisp.Size = new System.Drawing.Size(39, 16);
            this.pisp.TabIndex = 36;
            this.pisp.Text = "Piso:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(131, 93);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(145, 20);
            this.txtTipo.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tipo:";
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(306, 55);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.ReadOnly = true;
            this.txtPiso.Size = new System.Drawing.Size(30, 20);
            this.txtPiso.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nro:";
            // 
            // txtnroHab
            // 
            this.txtnroHab.Location = new System.Drawing.Point(131, 56);
            this.txtnroHab.Name = "txtnroHab";
            this.txtnroHab.ReadOnly = true;
            this.txtnroHab.Size = new System.Drawing.Size(43, 20);
            this.txtnroHab.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Habitación:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(308, 377);
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
            this.dgvDistri.Location = new System.Drawing.Point(53, 196);
            this.dgvDistri.Name = "dgvDistri";
            this.dgvDistri.ReadOnly = true;
            this.dgvDistri.Size = new System.Drawing.Size(328, 168);
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
            this.cbohab.FormattingEnabled = true;
            this.cbohab.Location = new System.Drawing.Point(137, 19);
            this.cbohab.Name = "cbohab";
            this.cbohab.Size = new System.Drawing.Size(121, 21);
            this.cbohab.TabIndex = 27;
            this.cbohab.SelectedIndexChanged += new System.EventHandler(this.cbohab_SelectedIndexChanged);
            // 
            // DistribClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 414);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pisp);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnroHab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvDistri);
            this.Controls.Add(this.cbohab);
            this.Name = "DistribClientes";
            this.Text = "DistribClientes";
            this.Load += new System.EventHandler(this.DistribClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pisp;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnroHab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvDistri;
        private System.Windows.Forms.DataGridViewButtonColumn Elegir;
        private System.Windows.Forms.ComboBox cbohab;
    }
}