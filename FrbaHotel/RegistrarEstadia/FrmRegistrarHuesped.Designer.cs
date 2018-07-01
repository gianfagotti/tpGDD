namespace FrbaHotel.RegistrarEstadia
{
    partial class FrmRegistrarHuesped
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
            this.LblAgregarHuésped = new System.Windows.Forms.Label();
            this.btnRegiCliente = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.btnSeleCliente = new System.Windows.Forms.Button();
            this.LblRegistrarEstadia = new System.Windows.Forms.Label();
            this.lblalgo = new System.Windows.Forms.Label();
            this.dgvHuesped = new System.Windows.Forms.DataGridView();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReserv = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.txtRest = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuesped)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAgregarHuésped
            // 
            this.LblAgregarHuésped.AutoSize = true;
            this.LblAgregarHuésped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgregarHuésped.Location = new System.Drawing.Point(9, 229);
            this.LblAgregarHuésped.Name = "LblAgregarHuésped";
            this.LblAgregarHuésped.Size = new System.Drawing.Size(158, 16);
            this.LblAgregarHuésped.TabIndex = 16;
            this.LblAgregarHuésped.Text = "Agregar Un Huésped:";
            this.LblAgregarHuésped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegiCliente
            // 
            this.btnRegiCliente.Location = new System.Drawing.Point(306, 229);
            this.btnRegiCliente.Name = "btnRegiCliente";
            this.btnRegiCliente.Size = new System.Drawing.Size(159, 31);
            this.btnRegiCliente.TabIndex = 18;
            this.btnRegiCliente.Text = "Registrar nuevo cliente";
            this.btnRegiCliente.UseVisualStyleBackColor = true;
            this.btnRegiCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(349, 475);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(103, 33);
            this.BtnRegistrar.TabIndex = 19;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // btnSeleCliente
            // 
            this.btnSeleCliente.Location = new System.Drawing.Point(190, 229);
            this.btnSeleCliente.Name = "btnSeleCliente";
            this.btnSeleCliente.Size = new System.Drawing.Size(110, 31);
            this.btnSeleCliente.TabIndex = 17;
            this.btnSeleCliente.Text = "Seleccionar Cliente";
            this.btnSeleCliente.UseVisualStyleBackColor = true;
            this.btnSeleCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblRegistrarEstadia
            // 
            this.LblRegistrarEstadia.AutoSize = true;
            this.LblRegistrarEstadia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblRegistrarEstadia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRegistrarEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrarEstadia.Location = new System.Drawing.Point(123, 19);
            this.LblRegistrarEstadia.Name = "LblRegistrarEstadia";
            this.LblRegistrarEstadia.Size = new System.Drawing.Size(265, 22);
            this.LblRegistrarEstadia.TabIndex = 1;
            this.LblRegistrarEstadia.Text = "Ingrese los datos de la Estadia:";
            this.LblRegistrarEstadia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblalgo
            // 
            this.lblalgo.AutoSize = true;
            this.lblalgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalgo.Location = new System.Drawing.Point(9, 71);
            this.lblalgo.Name = "lblalgo";
            this.lblalgo.Size = new System.Drawing.Size(187, 16);
            this.lblalgo.TabIndex = 2;
            this.lblalgo.Text = "Clientes para reserva nro:";
            this.lblalgo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvHuesped
            // 
            this.dgvHuesped.AllowUserToAddRows = false;
            this.dgvHuesped.AllowUserToDeleteRows = false;
            this.dgvHuesped.AllowUserToOrderColumns = true;
            this.dgvHuesped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuesped.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrar});
            this.dgvHuesped.Location = new System.Drawing.Point(44, 287);
            this.dgvHuesped.Name = "dgvHuesped";
            this.dgvHuesped.ReadOnly = true;
            this.dgvHuesped.Size = new System.Drawing.Size(408, 160);
            this.dgvHuesped.TabIndex = 24;
            // 
            // borrar
            // 
            this.borrar.HeaderText = "borrar";
            this.borrar.Name = "borrar";
            this.borrar.ReadOnly = true;
            this.borrar.Text = "borrar";
            this.borrar.UseColumnTextForButtonValue = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(64, 475);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 33);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Límite de huéspedes:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Huéspedes para agregar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Titular:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReserv
            // 
            this.txtReserv.Location = new System.Drawing.Point(220, 70);
            this.txtReserv.Name = "txtReserv";
            this.txtReserv.Size = new System.Drawing.Size(150, 20);
            this.txtReserv.TabIndex = 32;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(220, 105);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(150, 20);
            this.txtLimit.TabIndex = 33;
            // 
            // txtRest
            // 
            this.txtRest.Location = new System.Drawing.Point(220, 140);
            this.txtRest.Name = "txtRest";
            this.txtRest.Size = new System.Drawing.Size(150, 20);
            this.txtRest.TabIndex = 34;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(220, 173);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(150, 20);
            this.txtTitular.TabIndex = 35;
            // 
            // FrmRegistrarHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 529);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.txtRest);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtReserv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvHuesped);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.btnRegiCliente);
            this.Controls.Add(this.btnSeleCliente);
            this.Controls.Add(this.LblAgregarHuésped);
            this.Controls.Add(this.lblalgo);
            this.Controls.Add(this.LblRegistrarEstadia);
            this.Name = "FrmRegistrarHuesped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar huéspedes";
            this.Load += new System.EventHandler(this.FrmRegistrarEstadia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuesped)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAgregarHuésped;
        private System.Windows.Forms.Button btnRegiCliente;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label LblHuéspedes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSeleCliente;
        private System.Windows.Forms.Label LblRegistrarEstadia;
        private System.Windows.Forms.Label lblalgo;
        private System.Windows.Forms.DataGridView dgvHuesped;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReserv;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.TextBox txtRest;
        private System.Windows.Forms.TextBox txtTitular;
    }
}