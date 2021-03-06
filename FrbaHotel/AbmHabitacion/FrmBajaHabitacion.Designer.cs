﻿namespace FrbaHotel.AbmHabitacion
{
    partial class FrmBajaHabitacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboUbicacion = new System.Windows.Forms.ComboBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butLimpiar = new System.Windows.Forms.Button();
            this.butBuscar = new System.Windows.Forms.Button();
            this.butVolver = new System.Windows.Forms.Button();
            this.dgvFiltrado = new System.Windows.Forms.DataGridView();
            this.Elegir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkHabilitado);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.cboUbicacion);
            this.groupBox1.Controls.Add(this.txtPiso);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descripción";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabilitado.Location = new System.Drawing.Point(187, 102);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 1;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(253, 26);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(164, 70);
            this.txtDescripcion.TabIndex = 9;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(57, 113);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(103, 21);
            this.cboTipo.TabIndex = 8;
            // 
            // cboUbicacion
            // 
            this.cboUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUbicacion.FormattingEnabled = true;
            this.cboUbicacion.Location = new System.Drawing.Point(75, 82);
            this.cboUbicacion.Name = "cboUbicacion";
            this.cboUbicacion.Size = new System.Drawing.Size(85, 21);
            this.cboUbicacion.TabIndex = 7;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(64, 52);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(96, 20);
            this.txtPiso.TabIndex = 6;
            this.txtPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloNumeros_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(64, 23);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(96, 20);
            this.txtNumero.TabIndex = 5;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloNumeros_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ubicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Piso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // butLimpiar
            // 
            this.butLimpiar.Location = new System.Drawing.Point(12, 163);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(75, 23);
            this.butLimpiar.TabIndex = 1;
            this.butLimpiar.Text = "Limpiar";
            this.butLimpiar.UseVisualStyleBackColor = true;
            this.butLimpiar.Click += new System.EventHandler(this.butLimpiar_Click);
            // 
            // butBuscar
            // 
            this.butBuscar.Location = new System.Drawing.Point(371, 163);
            this.butBuscar.Name = "butBuscar";
            this.butBuscar.Size = new System.Drawing.Size(75, 23);
            this.butBuscar.TabIndex = 2;
            this.butBuscar.Text = "Buscar";
            this.butBuscar.UseVisualStyleBackColor = true;
            this.butBuscar.Click += new System.EventHandler(this.butBuscar_Click);
            // 
            // butVolver
            // 
            this.butVolver.Location = new System.Drawing.Point(371, 420);
            this.butVolver.Name = "butVolver";
            this.butVolver.Size = new System.Drawing.Size(75, 23);
            this.butVolver.TabIndex = 4;
            this.butVolver.Text = "Volver";
            this.butVolver.UseVisualStyleBackColor = true;
            this.butVolver.Click += new System.EventHandler(this.butVolver_Click);
            // 
            // dgvFiltrado
            // 
            this.dgvFiltrado.AllowUserToAddRows = false;
            this.dgvFiltrado.AllowUserToDeleteRows = false;
            this.dgvFiltrado.AllowUserToOrderColumns = true;
            this.dgvFiltrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir});
            this.dgvFiltrado.Location = new System.Drawing.Point(12, 192);
            this.dgvFiltrado.Name = "dgvFiltrado";
            this.dgvFiltrado.ReadOnly = true;
            this.dgvFiltrado.Size = new System.Drawing.Size(434, 222);
            this.dgvFiltrado.TabIndex = 18;
            this.dgvFiltrado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltrado_CellContentClick_1);
            // 
            // Elegir
            // 
            this.Elegir.HeaderText = "";
            this.Elegir.Name = "Elegir";
            this.Elegir.ReadOnly = true;
            this.Elegir.Text = "Inhabilitar";
            this.Elegir.UseColumnTextForButtonValue = true;
            // 
            // FrmBajaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.dgvFiltrado);
            this.Controls.Add(this.butVolver);
            this.Controls.Add(this.butBuscar);
            this.Controls.Add(this.butLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBajaHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar de baja habitación";
            this.Activated += new System.EventHandler(this.FrmBajaHabitacion_Activated);
            this.Load += new System.EventHandler(this.FrmBajaHabitacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboUbicacion;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button butLimpiar;
        private System.Windows.Forms.Button butBuscar;
        private System.Windows.Forms.Button butVolver;
        private System.Windows.Forms.DataGridView dgvFiltrado;
        private System.Windows.Forms.DataGridViewButtonColumn Elegir;
        private System.Windows.Forms.Label label5;
    }
}