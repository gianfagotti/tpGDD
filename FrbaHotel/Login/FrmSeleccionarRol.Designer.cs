namespace FrbaHotel.Login
{
    partial class FrmSeleccionarRol
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
            this.btnAceptarRol = new System.Windows.Forms.Button();
            this.cmbRolesRegistrados = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.btnVolverATipoUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptarRol
            // 
            this.btnAceptarRol.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAceptarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarRol.Location = new System.Drawing.Point(58, 185);
            this.btnAceptarRol.Name = "btnAceptarRol";
            this.btnAceptarRol.Size = new System.Drawing.Size(75, 27);
            this.btnAceptarRol.TabIndex = 8;
            this.btnAceptarRol.Text = "Aceptar";
            this.btnAceptarRol.UseVisualStyleBackColor = false;
            this.btnAceptarRol.Click += new System.EventHandler(this.btnAceptarRol_Click);
            // 
            // cmbRolesRegistrados
            // 
            this.cmbRolesRegistrados.FormattingEnabled = true;
            this.cmbRolesRegistrados.Items.AddRange(new object[] {
            "Administrador",
            "Recepcionista"});
            this.cmbRolesRegistrados.Location = new System.Drawing.Point(48, 103);
            this.cmbRolesRegistrados.Name = "cmbRolesRegistrados";
            this.cmbRolesRegistrados.Size = new System.Drawing.Size(184, 21);
            this.cmbRolesRegistrados.TabIndex = 7;
            this.cmbRolesRegistrados.Text = "Elija uno de sus roles registrados...";
            this.cmbRolesRegistrados.SelectedIndexChanged += new System.EventHandler(this.cmbRolesRegistrados_SelectedIndexChanged);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(58, 23);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(161, 22);
            this.lblTipoUsuario.TabIndex = 9;
            this.lblTipoUsuario.Text = "Seleccione un Rol:";
            this.lblTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTipoUsuario.Click += new System.EventHandler(this.lblSeleccionarRol_Click);
            // 
            // btnVolverATipoUsuario
            // 
            this.btnVolverATipoUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVolverATipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverATipoUsuario.Location = new System.Drawing.Point(144, 185);
            this.btnVolverATipoUsuario.Name = "btnVolverATipoUsuario";
            this.btnVolverATipoUsuario.Size = new System.Drawing.Size(75, 27);
            this.btnVolverATipoUsuario.TabIndex = 10;
            this.btnVolverATipoUsuario.Text = "Volver";
            this.btnVolverATipoUsuario.UseVisualStyleBackColor = false;
            this.btnVolverATipoUsuario.Click += new System.EventHandler(this.btnVolverATipoUsuario_Click);
            // 
            // FrmSeleccionarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnVolverATipoUsuario);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.btnAceptarRol);
            this.Controls.Add(this.cmbRolesRegistrados);
            this.Name = "FrmSeleccionarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar un Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarRol;
        private System.Windows.Forms.ComboBox cmbRolesRegistrados;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Button btnVolverATipoUsuario;
    }
}