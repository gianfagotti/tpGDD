namespace FrbaHotel.AbmHabitacion
{
    partial class FrmModificarHabitacion
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
            this.lblNroHabitacionMod = new System.Windows.Forms.Label();
            this.lblPisoMod = new System.Windows.Forms.Label();
            this.lblUbicacionMod = new System.Windows.Forms.Label();
            this.cboUbicacion = new System.Windows.Forms.ComboBox();
            this.lblTipoHabitacionMod = new System.Windows.Forms.Label();
            this.cboTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.lblDescripcionMod = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.butLimpiar = new System.Windows.Forms.Button();
            this.butGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtNroHab = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNroHabitacionMod
            // 
            this.lblNroHabitacionMod.AutoSize = true;
            this.lblNroHabitacionMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroHabitacionMod.Location = new System.Drawing.Point(12, 18);
            this.lblNroHabitacionMod.Name = "lblNroHabitacionMod";
            this.lblNroHabitacionMod.Size = new System.Drawing.Size(153, 18);
            this.lblNroHabitacionMod.TabIndex = 0;
            this.lblNroHabitacionMod.Text = "Numero de habitacion";
            // 
            // lblPisoMod
            // 
            this.lblPisoMod.AutoSize = true;
            this.lblPisoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPisoMod.Location = new System.Drawing.Point(12, 49);
            this.lblPisoMod.Name = "lblPisoMod";
            this.lblPisoMod.Size = new System.Drawing.Size(38, 18);
            this.lblPisoMod.TabIndex = 2;
            this.lblPisoMod.Text = "Piso";
            // 
            // lblUbicacionMod
            // 
            this.lblUbicacionMod.AutoSize = true;
            this.lblUbicacionMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacionMod.Location = new System.Drawing.Point(12, 83);
            this.lblUbicacionMod.Name = "lblUbicacionMod";
            this.lblUbicacionMod.Size = new System.Drawing.Size(74, 18);
            this.lblUbicacionMod.TabIndex = 4;
            this.lblUbicacionMod.Text = "Ubicacion";
            // 
            // cboUbicacion
            // 
            this.cboUbicacion.FormattingEnabled = true;
            this.cboUbicacion.Items.AddRange(new object[] {
            "Exterior",
            "Interior"});
            this.cboUbicacion.Location = new System.Drawing.Point(92, 84);
            this.cboUbicacion.Name = "cboUbicacion";
            this.cboUbicacion.Size = new System.Drawing.Size(121, 21);
            this.cboUbicacion.TabIndex = 5;
            // 
            // lblTipoHabitacionMod
            // 
            this.lblTipoHabitacionMod.AutoSize = true;
            this.lblTipoHabitacionMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoHabitacionMod.Location = new System.Drawing.Point(12, 116);
            this.lblTipoHabitacionMod.Name = "lblTipoHabitacionMod";
            this.lblTipoHabitacionMod.Size = new System.Drawing.Size(108, 18);
            this.lblTipoHabitacionMod.TabIndex = 6;
            this.lblTipoHabitacionMod.Text = "Tipo habitacion";
            // 
            // cboTipoHabitacion
            // 
            this.cboTipoHabitacion.FormattingEnabled = true;
            this.cboTipoHabitacion.Items.AddRange(new object[] {
            "Simple",
            "Doble",
            "Doble twin",
            "Triple",
            "Cuadruple"});
            this.cboTipoHabitacion.Location = new System.Drawing.Point(126, 117);
            this.cboTipoHabitacion.Name = "cboTipoHabitacion";
            this.cboTipoHabitacion.Size = new System.Drawing.Size(121, 21);
            this.cboTipoHabitacion.TabIndex = 7;
            // 
            // lblDescripcionMod
            // 
            this.lblDescripcionMod.AutoSize = true;
            this.lblDescripcionMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionMod.Location = new System.Drawing.Point(12, 152);
            this.lblDescripcionMod.Name = "lblDescripcionMod";
            this.lblDescripcionMod.Size = new System.Drawing.Size(87, 18);
            this.lblDescripcionMod.TabIndex = 8;
            this.lblDescripcionMod.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(105, 153);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(214, 91);
            this.txtDescripcion.TabIndex = 9;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabilitado.Location = new System.Drawing.Point(12, 265);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(92, 22);
            this.chkHabilitado.TabIndex = 10;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // butLimpiar
            // 
            this.butLimpiar.Location = new System.Drawing.Point(11, 307);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(75, 23);
            this.butLimpiar.TabIndex = 11;
            this.butLimpiar.Text = "Limpiar";
            this.butLimpiar.UseVisualStyleBackColor = true;
            this.butLimpiar.Click += new System.EventHandler(this.butLimpiar_Click);
            // 
            // butGuardar
            // 
            this.butGuardar.Location = new System.Drawing.Point(244, 307);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(75, 23);
            this.butGuardar.TabIndex = 12;
            this.butGuardar.Text = "Guardar";
            this.butGuardar.UseVisualStyleBackColor = true;
            this.butGuardar.Click += new System.EventHandler(this.butGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(163, 307);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtNroHab
            // 
            this.txtNroHab.Location = new System.Drawing.Point(171, 16);
            this.txtNroHab.Name = "txtNroHab";
            this.txtNroHab.Size = new System.Drawing.Size(45, 20);
            this.txtNroHab.TabIndex = 14;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(56, 50);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(45, 20);
            this.txtPiso.TabIndex = 15;
            // 
            // FrmModificarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 344);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtNroHab);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.butGuardar);
            this.Controls.Add(this.butLimpiar);
            this.Controls.Add(this.chkHabilitado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcionMod);
            this.Controls.Add(this.cboTipoHabitacion);
            this.Controls.Add(this.lblTipoHabitacionMod);
            this.Controls.Add(this.cboUbicacion);
            this.Controls.Add(this.lblUbicacionMod);
            this.Controls.Add(this.lblPisoMod);
            this.Controls.Add(this.lblNroHabitacionMod);
            this.Name = "FrmModificarHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Habitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroHabitacionMod;
        private System.Windows.Forms.Label lblPisoMod;
        private System.Windows.Forms.Label lblUbicacionMod;
        private System.Windows.Forms.ComboBox cboUbicacion;
        private System.Windows.Forms.Label lblTipoHabitacionMod;
        private System.Windows.Forms.ComboBox cboTipoHabitacion;
        private System.Windows.Forms.Label lblDescripcionMod;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Button butLimpiar;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtNroHab;
        private System.Windows.Forms.TextBox txtPiso;
    }
}