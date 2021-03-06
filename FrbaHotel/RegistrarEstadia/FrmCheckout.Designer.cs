﻿namespace FrbaHotel.RegistrarEstadia
{
    partial class FrmCheckout
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvFinalizar = new System.Windows.Forms.DataGridView();
            this.columna = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtEst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txthab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNrohab = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(344, 392);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 29);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(229, 392);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 29);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvFinalizar
            // 
            this.dgvFinalizar.AllowUserToAddRows = false;
            this.dgvFinalizar.AllowUserToDeleteRows = false;
            this.dgvFinalizar.AllowUserToOrderColumns = true;
            this.dgvFinalizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinalizar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna});
            this.dgvFinalizar.Location = new System.Drawing.Point(12, 166);
            this.dgvFinalizar.Name = "dgvFinalizar";
            this.dgvFinalizar.ReadOnly = true;
            this.dgvFinalizar.Size = new System.Drawing.Size(441, 214);
            this.dgvFinalizar.TabIndex = 6;
            this.dgvFinalizar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinalizar_CellContentClick);
            // 
            // columna
            // 
            this.columna.HeaderText = "EstadiaAFinalizar";
            this.columna.Name = "columna";
            this.columna.ReadOnly = true;
            this.columna.Text = "CheckOut";
            this.columna.UseColumnTextForButtonValue = true;
            // 
            // txtEst
            // 
            this.txtEst.Location = new System.Drawing.Point(119, 31);
            this.txtEst.Name = "txtEst";
            this.txtEst.Size = new System.Drawing.Size(131, 20);
            this.txtEst.TabIndex = 0;
            this.txtEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloNumeros_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código estadía:";
            // 
            // txthab
            // 
            this.txthab.Location = new System.Drawing.Point(135, 59);
            this.txthab.Name = "txthab";
            this.txthab.Size = new System.Drawing.Size(115, 20);
            this.txthab.TabIndex = 2;
            this.txthab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloNumeros_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código habitación:";
            // 
            // txtNrohab
            // 
            this.txtNrohab.Location = new System.Drawing.Point(312, 59);
            this.txtNrohab.Name = "txtNrohab";
            this.txtNrohab.Size = new System.Drawing.Size(101, 20);
            this.txtNrohab.TabIndex = 4;
            this.txtNrohab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloNumeros_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nro:";
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(312, 31);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(101, 20);
            this.txtPiso.TabIndex = 6;
            this.txtPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloNumeros_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Piso:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPiso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNrohab);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txthab);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEst);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 99);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 392);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(109, 29);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(444, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seleccione en la lista bajo la celda a la izquierda que corresponde a la estadia " +
    "que desea dar por concluida (se incluyen automaticamente todas las habitaciones " +
    "que la componen):";
            // 
            // FrmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 432);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvFinalizar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-out";
            this.Load += new System.EventHandler(this.FrmCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvFinalizar;
        private System.Windows.Forms.TextBox txtEst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNrohab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewButtonColumn columna;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label5;
    }
}