namespace FrbaHotel.Login
{
    partial class FrmLoginContraseña
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
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseñaUsuario = new System.Windows.Forms.Label();
            this.btnIngresarContraseña = new System.Windows.Forms.Button();
            this.BtnVolverContraseña = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(34, 98);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(91, 16);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(164, 98);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(172, 20);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblContraseñaUsuario
            // 
            this.lblContraseñaUsuario.AutoSize = true;
            this.lblContraseñaUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblContraseñaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContraseñaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaUsuario.Location = new System.Drawing.Point(89, 23);
            this.lblContraseñaUsuario.Name = "lblContraseñaUsuario";
            this.lblContraseñaUsuario.Size = new System.Drawing.Size(196, 22);
            this.lblContraseñaUsuario.TabIndex = 7;
            this.lblContraseñaUsuario.Text = "Ingrese su contraseña:";
            this.lblContraseñaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIngresarContraseña
            // 
            this.btnIngresarContraseña.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnIngresarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarContraseña.Location = new System.Drawing.Point(101, 171);
            this.btnIngresarContraseña.Name = "btnIngresarContraseña";
            this.btnIngresarContraseña.Size = new System.Drawing.Size(75, 27);
            this.btnIngresarContraseña.TabIndex = 8;
            this.btnIngresarContraseña.Text = "Ingresar";
            this.btnIngresarContraseña.UseVisualStyleBackColor = false;
            this.btnIngresarContraseña.Click += new System.EventHandler(this.btnIngresarContraseña_Click);
            // 
            // BtnVolverContraseña
            // 
            this.BtnVolverContraseña.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnVolverContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverContraseña.Location = new System.Drawing.Point(20, 171);
            this.BtnVolverContraseña.Name = "BtnVolverContraseña";
            this.BtnVolverContraseña.Size = new System.Drawing.Size(75, 27);
            this.BtnVolverContraseña.TabIndex = 9;
            this.BtnVolverContraseña.Text = "Volver";
            this.BtnVolverContraseña.UseVisualStyleBackColor = false;
            this.BtnVolverContraseña.Click += new System.EventHandler(this.BtnVolverContraseña_Click);
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.Location = new System.Drawing.Point(182, 171);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(172, 27);
            this.btnPass.TabIndex = 10;
            this.btnPass.Text = "Cambiar contraseña";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click_1);
            // 
            // FrmLoginContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 210);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.BtnVolverContraseña);
            this.Controls.Add(this.btnIngresarContraseña);
            this.Controls.Add(this.lblContraseñaUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Name = "FrmLoginContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseñaUsuario;
        private System.Windows.Forms.Button btnIngresarContraseña;
        private System.Windows.Forms.Button BtnVolverContraseña;
        private System.Windows.Forms.Button btnPass;
    }
}