namespace FrbaHotel.Login
{
    partial class FrmTipoUsuario
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
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblTiposDeUsuario = new System.Windows.Forms.Label();
            this.cmbTiposDeUsuario = new System.Windows.Forms.ComboBox();
            this.btnAceptarTipoUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(12, 20);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(255, 22);
            this.lblTipoUsuario.TabIndex = 1;
            this.lblTipoUsuario.Text = "Seleccione su tipo de Usuario:";
            this.lblTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiposDeUsuario
            // 
            this.lblTiposDeUsuario.AutoSize = true;
            this.lblTiposDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiposDeUsuario.Location = new System.Drawing.Point(71, 63);
            this.lblTiposDeUsuario.Name = "lblTiposDeUsuario";
            this.lblTiposDeUsuario.Size = new System.Drawing.Size(129, 16);
            this.lblTiposDeUsuario.TabIndex = 2;
            this.lblTiposDeUsuario.Text = "Tipos de usuario:";
            this.lblTiposDeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTiposDeUsuario
            // 
            this.cmbTiposDeUsuario.FormattingEnabled = true;
            this.cmbTiposDeUsuario.Items.AddRange(new object[] {
            "Cliente",
            "Empleado"});
            this.cmbTiposDeUsuario.Location = new System.Drawing.Point(51, 104);
            this.cmbTiposDeUsuario.Name = "cmbTiposDeUsuario";
            this.cmbTiposDeUsuario.Size = new System.Drawing.Size(171, 21);
            this.cmbTiposDeUsuario.TabIndex = 3;
            this.cmbTiposDeUsuario.Text = "Seleccione su tipo de usuario...";
            // 
            // btnAceptarTipoUsuario
            // 
            this.btnAceptarTipoUsuario.AccessibleName = "btnAceptarTipoUsuario";
            this.btnAceptarTipoUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAceptarTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarTipoUsuario.Location = new System.Drawing.Point(96, 169);
            this.btnAceptarTipoUsuario.Name = "btnAceptarTipoUsuario";
            this.btnAceptarTipoUsuario.Size = new System.Drawing.Size(75, 27);
            this.btnAceptarTipoUsuario.TabIndex = 6;
            this.btnAceptarTipoUsuario.Text = "Aceptar";
            this.btnAceptarTipoUsuario.UseVisualStyleBackColor = false;
            this.btnAceptarTipoUsuario.Click += new System.EventHandler(this.btnAceptarTipoUsuario_Click);
            // 
            // FrmTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAceptarTipoUsuario);
            this.Controls.Add(this.cmbTiposDeUsuario);
            this.Controls.Add(this.lblTiposDeUsuario);
            this.Controls.Add(this.lblTipoUsuario);
            this.Name = "FrmTipoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTipoUsuario_FormClosing);
            this.Load += new System.EventHandler(this.FrmTipoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblTiposDeUsuario;
        private System.Windows.Forms.ComboBox cmbTiposDeUsuario;
        private System.Windows.Forms.Button btnAceptarTipoUsuario;
    }
}