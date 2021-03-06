﻿namespace FrbaHotel.ListadoEstadistico
{
    partial class ListadoEstadistico
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCateg = new System.Windows.Forms.Label();
            this.cboCateg = new System.Windows.Forms.ComboBox();
            this.btnMostrarEstadist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTrim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAnio = new System.Windows.Forms.DateTimePicker();
            this.dgvEstadistico = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadistico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(9, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(535, 40);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Elija según el tipo de resultados sobre los cuales desea filtrar los primeros 5 r" +
    "egistros:";
            // 
            // lblCateg
            // 
            this.lblCateg.AutoSize = true;
            this.lblCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateg.Location = new System.Drawing.Point(27, 67);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(67, 13);
            this.lblCateg.TabIndex = 3;
            this.lblCateg.Text = "Categoría:";
            // 
            // cboCateg
            // 
            this.cboCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCateg.FormattingEnabled = true;
            this.cboCateg.Location = new System.Drawing.Point(100, 64);
            this.cboCateg.Name = "cboCateg";
            this.cboCateg.Size = new System.Drawing.Size(419, 21);
            this.cboCateg.TabIndex = 4;
            // 
            // btnMostrarEstadist
            // 
            this.btnMostrarEstadist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMostrarEstadist.Location = new System.Drawing.Point(313, 108);
            this.btnMostrarEstadist.Name = "btnMostrarEstadist";
            this.btnMostrarEstadist.Size = new System.Drawing.Size(231, 42);
            this.btnMostrarEstadist.TabIndex = 8;
            this.btnMostrarEstadist.Text = "Mostrar";
            this.btnMostrarEstadist.UseVisualStyleBackColor = true;
            this.btnMostrarEstadist.Click += new System.EventHandler(this.btnMostrarEstadist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Trimestre:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cboTrim
            // 
            this.cboTrim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrim.FormattingEnabled = true;
            this.cboTrim.Location = new System.Drawing.Point(100, 98);
            this.cboTrim.Name = "cboTrim";
            this.cboTrim.Size = new System.Drawing.Size(132, 21);
            this.cboTrim.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Año:";
            // 
            // dtpAnio
            // 
            this.dtpAnio.CustomFormat = "yyyy";
            this.dtpAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnio.Location = new System.Drawing.Point(100, 130);
            this.dtpAnio.Name = "dtpAnio";
            this.dtpAnio.Size = new System.Drawing.Size(59, 20);
            this.dtpAnio.TabIndex = 14;
            // 
            // dgvEstadistico
            // 
            this.dgvEstadistico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadistico.Location = new System.Drawing.Point(12, 167);
            this.dgvEstadistico.Name = "dgvEstadistico";
            this.dgvEstadistico.ReadOnly = true;
            this.dgvEstadistico.Size = new System.Drawing.Size(558, 293);
            this.dgvEstadistico.TabIndex = 15;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(224, 472);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(145, 42);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 526);
            this.Controls.Add(this.dgvEstadistico);
            this.Controls.Add(this.dtpAnio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTrim);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarEstadist);
            this.Controls.Add(this.cboCateg);
            this.Controls.Add(this.lblCateg);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ListadoEstadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado estadístico";
            this.Load += new System.EventHandler(this.frmListadoEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadistico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCateg;
        private System.Windows.Forms.ComboBox cboCateg;
        private System.Windows.Forms.Button btnMostrarEstadist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTrim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAnio;
        private System.Windows.Forms.DataGridView dgvEstadistico;
        private System.Windows.Forms.Button btnVolver;
    }
}