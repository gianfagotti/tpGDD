namespace FrbaHotel.AbmHotel
{
    partial class SeleccionarAdministrador
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
            this.lblSeleccionarAdministrador = new System.Windows.Forms.Label();
            this.cboSeleccionarAdministrador = new System.Windows.Forms.ComboBox();
            this.btnAceptarAdministrador = new System.Windows.Forms.Button();
            this.lblUsuariosRegistrados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSeleccionarAdministrador
            // 
            this.lblSeleccionarAdministrador.AutoSize = true;
            this.lblSeleccionarAdministrador.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSeleccionarAdministrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeleccionarAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarAdministrador.Location = new System.Drawing.Point(10, 9);
            this.lblSeleccionarAdministrador.Name = "lblSeleccionarAdministrador";
            this.lblSeleccionarAdministrador.Size = new System.Drawing.Size(377, 22);
            this.lblSeleccionarAdministrador.TabIndex = 2;
            this.lblSeleccionarAdministrador.Text = "Seleccione un administrador del hotel creado:";
            this.lblSeleccionarAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboSeleccionarAdministrador
            // 
            this.cboSeleccionarAdministrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeleccionarAdministrador.FormattingEnabled = true;
            this.cboSeleccionarAdministrador.Location = new System.Drawing.Point(139, 91);
            this.cboSeleccionarAdministrador.Name = "cboSeleccionarAdministrador";
            this.cboSeleccionarAdministrador.Size = new System.Drawing.Size(121, 21);
            this.cboSeleccionarAdministrador.TabIndex = 3;
            // 
            // btnAceptarAdministrador
            // 
            this.btnAceptarAdministrador.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAceptarAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarAdministrador.Location = new System.Drawing.Point(161, 142);
            this.btnAceptarAdministrador.Name = "btnAceptarAdministrador";
            this.btnAceptarAdministrador.Size = new System.Drawing.Size(75, 27);
            this.btnAceptarAdministrador.TabIndex = 21;
            this.btnAceptarAdministrador.Text = "Aceptar";
            this.btnAceptarAdministrador.UseVisualStyleBackColor = false;
            this.btnAceptarAdministrador.Click += new System.EventHandler(this.btnAceptarAdministrador_Click);
            // 
            // lblUsuariosRegistrados
            // 
            this.lblUsuariosRegistrados.AutoSize = true;
            this.lblUsuariosRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosRegistrados.Location = new System.Drawing.Point(115, 48);
            this.lblUsuariosRegistrados.Name = "lblUsuariosRegistrados";
            this.lblUsuariosRegistrados.Size = new System.Drawing.Size(163, 16);
            this.lblUsuariosRegistrados.TabIndex = 22;
            this.lblUsuariosRegistrados.Text = "Usuarios Registrados:";
            this.lblUsuariosRegistrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeleccionarAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 181);
            this.Controls.Add(this.lblUsuariosRegistrados);
            this.Controls.Add(this.btnAceptarAdministrador);
            this.Controls.Add(this.cboSeleccionarAdministrador);
            this.Controls.Add(this.lblSeleccionarAdministrador);
            this.Name = "SeleccionarAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionarAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionarAdministrador;
        private System.Windows.Forms.ComboBox cboSeleccionarAdministrador;
        private System.Windows.Forms.Button btnAceptarAdministrador;
        private System.Windows.Forms.Label lblUsuariosRegistrados;
    }
}