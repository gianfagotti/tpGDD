namespace FrbaHotel.RegistrarConsumible
{
    partial class FrmSeleccionarEstadia
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
            this.LblSeleccionarEstadia = new System.Windows.Forms.Label();
            this.LblCodigoDeEstadia = new System.Windows.Forms.Label();
            this.TxtSeleccionCodigoEstadia = new System.Windows.Forms.TextBox();
            this.BtnAceptarSeleccionEstadia = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSeleccionarEstadia
            // 
            this.LblSeleccionarEstadia.AutoSize = true;
            this.LblSeleccionarEstadia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblSeleccionarEstadia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSeleccionarEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeleccionarEstadia.Location = new System.Drawing.Point(69, 9);
            this.LblSeleccionarEstadia.Name = "LblSeleccionarEstadia";
            this.LblSeleccionarEstadia.Size = new System.Drawing.Size(205, 22);
            this.LblSeleccionarEstadia.TabIndex = 1;
            this.LblSeleccionarEstadia.Text = "Seleccione una Estadia:";
            this.LblSeleccionarEstadia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblSeleccionarEstadia.Click += new System.EventHandler(this.LblSeleccionarEstadia_Click);
            // 
            // LblCodigoDeEstadia
            // 
            this.LblCodigoDeEstadia.AutoSize = true;
            this.LblCodigoDeEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoDeEstadia.Location = new System.Drawing.Point(31, 68);
            this.LblCodigoDeEstadia.Name = "LblCodigoDeEstadia";
            this.LblCodigoDeEstadia.Size = new System.Drawing.Size(141, 16);
            this.LblCodigoDeEstadia.TabIndex = 7;
            this.LblCodigoDeEstadia.Text = "Codigo de Estadia:";
            this.LblCodigoDeEstadia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSeleccionCodigoEstadia
            // 
            this.TxtSeleccionCodigoEstadia.Location = new System.Drawing.Point(208, 68);
            this.TxtSeleccionCodigoEstadia.Name = "TxtSeleccionCodigoEstadia";
            this.TxtSeleccionCodigoEstadia.Size = new System.Drawing.Size(100, 20);
            this.TxtSeleccionCodigoEstadia.TabIndex = 8;
            // 
            // BtnAceptarSeleccionEstadia
            // 
            this.BtnAceptarSeleccionEstadia.Location = new System.Drawing.Point(184, 127);
            this.BtnAceptarSeleccionEstadia.Name = "BtnAceptarSeleccionEstadia";
            this.BtnAceptarSeleccionEstadia.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptarSeleccionEstadia.TabIndex = 9;
            this.BtnAceptarSeleccionEstadia.Text = "Aceptar";
            this.BtnAceptarSeleccionEstadia.UseVisualStyleBackColor = true;
            this.BtnAceptarSeleccionEstadia.Click += new System.EventHandler(this.BtnAceptarSeleccionEstadia_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(97, 127);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmSeleccionarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 171);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.BtnAceptarSeleccionEstadia);
            this.Controls.Add(this.TxtSeleccionCodigoEstadia);
            this.Controls.Add(this.LblCodigoDeEstadia);
            this.Controls.Add(this.LblSeleccionarEstadia);
            this.Name = "FrmSeleccionarEstadia";
            this.Text = "FrmSeleccionEstadia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSeleccionarEstadia;
        private System.Windows.Forms.Label LblCodigoDeEstadia;
        private System.Windows.Forms.TextBox TxtSeleccionCodigoEstadia;
        private System.Windows.Forms.Button BtnAceptarSeleccionEstadia;
        private System.Windows.Forms.Button btnVolver;
    }
}