namespace FrbaHotel.AbmHabitacion
{
    partial class FrmListadoMod
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
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.cboUbicacion = new System.Windows.Forms.ComboBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtNroHab = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFiltrado = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butLimpiar = new System.Windows.Forms.Button();
            this.butVolver = new System.Windows.Forms.Button();
            this.butBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkHabilitado);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.cboTipoHabitacion);
            this.groupBox1.Controls.Add(this.cboUbicacion);
            this.groupBox1.Controls.Add(this.txtPiso);
            this.groupBox1.Controls.Add(this.txtNroHab);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabilitado.Location = new System.Drawing.Point(182, 86);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(92, 22);
            this.chkHabilitado.TabIndex = 11;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(280, 26);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(208, 116);
            this.txtDescripcion.TabIndex = 10;
            // 
            // cboTipoHabitacion
            // 
            this.cboTipoHabitacion.FormattingEnabled = true;
            this.cboTipoHabitacion.Location = new System.Drawing.Point(49, 121);
            this.cboTipoHabitacion.Name = "cboTipoHabitacion";
            this.cboTipoHabitacion.Size = new System.Drawing.Size(122, 21);
            this.cboTipoHabitacion.TabIndex = 9;
            // 
            // cboUbicacion
            // 
            this.cboUbicacion.FormattingEnabled = true;
            this.cboUbicacion.Location = new System.Drawing.Point(87, 83);
            this.cboUbicacion.Name = "cboUbicacion";
            this.cboUbicacion.Size = new System.Drawing.Size(84, 21);
            this.cboUbicacion.TabIndex = 8;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(74, 54);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(51, 20);
            this.txtPiso.TabIndex = 7;
            this.txtPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPiso_KeyPress);
            // 
            // txtNroHab
            // 
            this.txtNroHab.Location = new System.Drawing.Point(74, 26);
            this.txtNroHab.Name = "txtNroHab";
            this.txtNroHab.Size = new System.Drawing.Size(51, 20);
            this.txtNroHab.TabIndex = 6;
            this.txtNroHab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroHab_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ubicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Piso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // dgvFiltrado
            // 
            this.dgvFiltrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar});
            this.dgvFiltrado.Location = new System.Drawing.Point(12, 212);
            this.dgvFiltrado.Name = "dgvFiltrado";
            this.dgvFiltrado.Size = new System.Drawing.Size(499, 226);
            this.dgvFiltrado.TabIndex = 1;
            this.dgvFiltrado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltrado_CellContentClick);
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            // 
            // butLimpiar
            // 
            this.butLimpiar.Location = new System.Drawing.Point(12, 172);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(75, 23);
            this.butLimpiar.TabIndex = 2;
            this.butLimpiar.Text = "Limpiar";
            this.butLimpiar.UseVisualStyleBackColor = true;
            this.butLimpiar.Click += new System.EventHandler(this.butLimpiar_Click);
            // 
            // butVolver
            // 
            this.butVolver.Location = new System.Drawing.Point(436, 461);
            this.butVolver.Name = "butVolver";
            this.butVolver.Size = new System.Drawing.Size(75, 23);
            this.butVolver.TabIndex = 3;
            this.butVolver.Text = "Volver";
            this.butVolver.UseVisualStyleBackColor = true;
            this.butVolver.Click += new System.EventHandler(this.butVolver_Click);
            // 
            // butBuscar
            // 
            this.butBuscar.Location = new System.Drawing.Point(433, 172);
            this.butBuscar.Name = "butBuscar";
            this.butBuscar.Size = new System.Drawing.Size(75, 23);
            this.butBuscar.TabIndex = 4;
            this.butBuscar.Text = "Buscar";
            this.butBuscar.UseVisualStyleBackColor = true;
            this.butBuscar.Click += new System.EventHandler(this.butBuscar_Click);
            // 
            // FrmListadoMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 488);
            this.Controls.Add(this.butBuscar);
            this.Controls.Add(this.butVolver);
            this.Controls.Add(this.dgvFiltrado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butLimpiar);
            this.Name = "FrmListadoMod";
            this.Text = "Listado Habitaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboTipoHabitacion;
        private System.Windows.Forms.ComboBox cboUbicacion;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtNroHab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFiltrado;
        private System.Windows.Forms.Button butBuscar;
        private System.Windows.Forms.Button butVolver;
        private System.Windows.Forms.Button butLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modificar;
    }
}