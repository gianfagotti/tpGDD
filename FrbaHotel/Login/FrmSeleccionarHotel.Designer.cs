namespace FrbaHotel.Login
{
    partial class FrmSeleccionarHotel
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
            this.lblHotelUsuario = new System.Windows.Forms.Label();
            this.cboSeleccionarHotel = new System.Windows.Forms.ComboBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnAceptarHotel = new System.Windows.Forms.Button();
            this.BtnVolverHotel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHotelUsuario
            // 
            this.lblHotelUsuario.AutoSize = true;
            this.lblHotelUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHotelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHotelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelUsuario.Location = new System.Drawing.Point(57, 19);
            this.lblHotelUsuario.Name = "lblHotelUsuario";
            this.lblHotelUsuario.Size = new System.Drawing.Size(168, 22);
            this.lblHotelUsuario.TabIndex = 8;
            this.lblHotelUsuario.Text = "Seleccione el hotel:";
            this.lblHotelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHotelUsuario.Click += new System.EventHandler(this.lblHotelUsuario_Click);
            // 
            // cboSeleccionarHotel
            // 
            this.cboSeleccionarHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeleccionarHotel.FormattingEnabled = true;
            this.cboSeleccionarHotel.Location = new System.Drawing.Point(25, 121);
            this.cboSeleccionarHotel.Name = "cboSeleccionarHotel";
            this.cboSeleccionarHotel.Size = new System.Drawing.Size(236, 21);
            this.cboSeleccionarHotel.TabIndex = 9;
            this.cboSeleccionarHotel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(64, 78);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(151, 16);
            this.lblContraseña.TabIndex = 10;
            this.lblContraseña.Text = "Hoteles disponibles:";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptarHotel
            // 
            this.btnAceptarHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAceptarHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarHotel.Location = new System.Drawing.Point(57, 170);
            this.btnAceptarHotel.Name = "btnAceptarHotel";
            this.btnAceptarHotel.Size = new System.Drawing.Size(75, 27);
            this.btnAceptarHotel.TabIndex = 11;
            this.btnAceptarHotel.Text = "Aceptar";
            this.btnAceptarHotel.UseVisualStyleBackColor = false;
            this.btnAceptarHotel.Click += new System.EventHandler(this.btnAceptarHotel_Click);
            // 
            // BtnVolverHotel
            // 
            this.BtnVolverHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnVolverHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverHotel.Location = new System.Drawing.Point(138, 170);
            this.BtnVolverHotel.Name = "BtnVolverHotel";
            this.BtnVolverHotel.Size = new System.Drawing.Size(75, 27);
            this.BtnVolverHotel.TabIndex = 12;
            this.BtnVolverHotel.Text = "Volver";
            this.BtnVolverHotel.UseVisualStyleBackColor = false;
            this.BtnVolverHotel.Click += new System.EventHandler(this.BtnVolverHotel_Click);
            // 
            // FrmSeleccionarHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.BtnVolverHotel);
            this.Controls.Add(this.btnAceptarHotel);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.cboSeleccionarHotel);
            this.Controls.Add(this.lblHotelUsuario);
            this.Name = "FrmSeleccionarHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSeleccionarHotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHotelUsuario;
        private System.Windows.Forms.ComboBox cboSeleccionarHotel;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnAceptarHotel;
        private System.Windows.Forms.Button BtnVolverHotel;
    }
}