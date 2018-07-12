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
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.LblCodigoEstadia = new System.Windows.Forms.Label();
            this.txtCodigoEst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txthab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnroha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpiso = new System.Windows.Forms.TextBox();
            this.dgvCons = new System.Windows.Forms.DataGridView();
            this.dgvConsReg = new System.Windows.Forms.DataGridView();
            this.columna = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsReg)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRegistrarConsumibles
            // 
            this.LblRegistrarConsumibles.AutoSize = true;
            this.LblRegistrarConsumibles.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblRegistrarConsumibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRegistrarConsumibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrarConsumibles.Location = new System.Drawing.Point(169, 24);
            this.LblRegistrarConsumibles.Name = "LblRegistrarConsumibles";
            this.LblRegistrarConsumibles.Size = new System.Drawing.Size(219, 22);
            this.LblRegistrarConsumibles.TabIndex = 2;
            this.LblRegistrarConsumibles.Text = "Registro De Consumibles:";
            this.LblRegistrarConsumibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnGuardarCambios
            // 
            this.BtnGuardarCambios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCambios.Location = new System.Drawing.Point(385, 451);
            this.BtnGuardarCambios.Name = "BtnGuardarCambios";
            this.BtnGuardarCambios.Size = new System.Drawing.Size(143, 30);
            this.BtnGuardarCambios.TabIndex = 18;
            this.BtnGuardarCambios.Text = "Guardar Cambios";
            this.BtnGuardarCambios.UseVisualStyleBackColor = true;
            this.BtnGuardarCambios.Click += new System.EventHandler(this.BtnGuardarCambios_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(19, 451);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(74, 31);
            this.BtnVolver.TabIndex = 19;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // LblCodigoEstadia
            // 
            this.LblCodigoEstadia.AutoSize = true;
            this.LblCodigoEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoEstadia.Location = new System.Drawing.Point(33, 227);
            this.LblCodigoEstadia.Name = "LblCodigoEstadia";
            this.LblCodigoEstadia.Size = new System.Drawing.Size(97, 13);
            this.LblCodigoEstadia.TabIndex = 20;
            this.LblCodigoEstadia.Text = "Código estadía:";
            this.LblCodigoEstadia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigoEst
            // 
            this.txtCodigoEst.Location = new System.Drawing.Point(136, 224);
            this.txtCodigoEst.Name = "txtCodigoEst";
            this.txtCodigoEst.ReadOnly = true;
            this.txtCodigoEst.Size = new System.Drawing.Size(116, 20);
            this.txtCodigoEst.TabIndex = 25;
            this.txtCodigoEst.TextChanged += new System.EventHandler(this.txtCodigoEst_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Código habitación:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txthab
            // 
            this.txthab.Location = new System.Drawing.Point(136, 255);
            this.txthab.Name = "txthab";
            this.txthab.ReadOnly = true;
            this.txthab.Size = new System.Drawing.Size(116, 20);
            this.txthab.TabIndex = 32;
            this.txthab.TextChanged += new System.EventHandler(this.txthab_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "N° habitación:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnroha
            // 
            this.txtnroha.Location = new System.Drawing.Point(395, 255);
            this.txtnroha.Name = "txtnroha";
            this.txtnroha.ReadOnly = true;
            this.txtnroha.Size = new System.Drawing.Size(101, 20);
            this.txtnroha.TabIndex = 34;
            this.txtnroha.TextChanged += new System.EventHandler(this.txtnroha_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Piso:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpiso
            // 
            this.txtpiso.Location = new System.Drawing.Point(395, 224);
            this.txtpiso.Name = "txtpiso";
            this.txtpiso.ReadOnly = true;
            this.txtpiso.Size = new System.Drawing.Size(101, 20);
            this.txtpiso.TabIndex = 37;
            this.txtpiso.TextChanged += new System.EventHandler(this.txtpiso_TextChanged);
            // 
            // dgvCons
            // 
            this.dgvCons.AllowUserToAddRows = false;
            this.dgvCons.AllowUserToDeleteRows = false;
            this.dgvCons.AllowUserToOrderColumns = true;
            this.dgvCons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna});
            this.dgvCons.Location = new System.Drawing.Point(20, 75);
            this.dgvCons.Name = "dgvCons";
            this.dgvCons.ReadOnly = true;
            this.dgvCons.Size = new System.Drawing.Size(508, 118);
            this.dgvCons.TabIndex = 44;
            this.dgvCons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCons_CellContentClick);
            // 
            // dgvConsReg
            // 
            this.dgvConsReg.AllowUserToAddRows = false;
            this.dgvConsReg.AllowUserToDeleteRows = false;
            this.dgvConsReg.AllowUserToOrderColumns = true;
            this.dgvConsReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
            this.dgvConsReg.Location = new System.Drawing.Point(20, 298);
            this.dgvConsReg.Name = "dgvConsReg";
            this.dgvConsReg.ReadOnly = true;
            this.dgvConsReg.Size = new System.Drawing.Size(508, 127);
            this.dgvConsReg.TabIndex = 45;
            this.dgvConsReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsReg_CellContentClick_1);
            // 
            // columna
            // 
            this.columna.HeaderText = "Acción";
            this.columna.Name = "columna";
            this.columna.ReadOnly = true;
            this.columna.Text = "Agregar";
            this.columna.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Acción";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Quitar";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // FrmAgregarConsumibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 494);
            this.Controls.Add(this.dgvConsReg);
            this.Controls.Add(this.dgvCons);
            this.Controls.Add(this.txtpiso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnroha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoEst);
            this.Controls.Add(this.LblCodigoEstadia);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnGuardarCambios);
            this.Controls.Add(this.LblRegistrarConsumibles);
            this.Name = "FrmAgregarConsumibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar consumibles";
            this.Load += new System.EventHandler(this.FrmAgregarConsumibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegistrarConsumibles;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label LblCodigoEstadia;
        private System.Windows.Forms.TextBox txtCodigoEst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnroha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpiso;
        private System.Windows.Forms.DataGridView dgvCons;
        private System.Windows.Forms.DataGridView dgvConsReg;
        private System.Windows.Forms.DataGridViewButtonColumn columna;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}