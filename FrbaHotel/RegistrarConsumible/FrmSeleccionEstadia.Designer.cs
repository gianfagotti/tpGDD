namespace FrbaHotel.RegistrarConsumible
{
    partial class FrmSeleccionEstadia
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
            this.dgvEstadias = new System.Windows.Forms.DataGridView();
            this.columna = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpiso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnroha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoEst = new System.Windows.Forms.TextBox();
            this.LblCodigoEstadia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEstadias
            // 
            this.dgvEstadias.AllowUserToAddRows = false;
            this.dgvEstadias.AllowUserToDeleteRows = false;
            this.dgvEstadias.AllowUserToOrderColumns = true;
            this.dgvEstadias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna});
            this.dgvEstadias.Location = new System.Drawing.Point(29, 205);
            this.dgvEstadias.Name = "dgvEstadias";
            this.dgvEstadias.ReadOnly = true;
            this.dgvEstadias.Size = new System.Drawing.Size(554, 202);
            this.dgvEstadias.TabIndex = 9;
            this.dgvEstadias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstadias_CellContentClick);
            // 
            // columna
            // 
            this.columna.HeaderText = "Seleccionar";
            this.columna.Name = "columna";
            this.columna.ReadOnly = true;
            this.columna.Text = "Seleccionar";
            this.columna.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpiso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnroha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txthab);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigoEst);
            this.groupBox1.Controls.Add(this.LblCodigoEstadia);
            this.groupBox1.Location = new System.Drawing.Point(29, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 122);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // txtpiso
            // 
            this.txtpiso.Location = new System.Drawing.Point(360, 40);
            this.txtpiso.Name = "txtpiso";
            this.txtpiso.Size = new System.Drawing.Size(45, 20);
            this.txtpiso.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Piso:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnroha
            // 
            this.txtnroha.Location = new System.Drawing.Point(460, 73);
            this.txtnroha.Name = "txtnroha";
            this.txtnroha.Size = new System.Drawing.Size(45, 20);
            this.txtnroha.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Número habitación:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txthab
            // 
            this.txthab.Location = new System.Drawing.Point(183, 70);
            this.txthab.Name = "txthab";
            this.txthab.Size = new System.Drawing.Size(100, 20);
            this.txthab.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Código habitación:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigoEst
            // 
            this.txtCodigoEst.Location = new System.Drawing.Point(174, 40);
            this.txtCodigoEst.Name = "txtCodigoEst";
            this.txtCodigoEst.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEst.TabIndex = 39;
            // 
            // LblCodigoEstadia
            // 
            this.LblCodigoEstadia.AutoSize = true;
            this.LblCodigoEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoEstadia.Location = new System.Drawing.Point(39, 40);
            this.LblCodigoEstadia.Name = "LblCodigoEstadia";
            this.LblCodigoEstadia.Size = new System.Drawing.Size(118, 16);
            this.LblCodigoEstadia.TabIndex = 38;
            this.LblCodigoEstadia.Text = "Código estadía:";
            this.LblCodigoEstadia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(521, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Elija la estadía deseada haciendo clic en la celda a la izquierda de la fila:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 428);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(139, 36);
            this.btnVolver.TabIndex = 47;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(286, 428);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(139, 36);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(444, 428);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 36);
            this.btnBuscar.TabIndex = 49;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmSeleccionEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 476);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvEstadias);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSeleccionEstadia";
            this.Text = "Selección de la Estadia";
            this.Load += new System.EventHandler(this.FrmSeleccionEstadia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstadias;
        private System.Windows.Forms.DataGridViewButtonColumn columna;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpiso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnroha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoEst;
        private System.Windows.Forms.Label LblCodigoEstadia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
    }
}