namespace FrbaHotel.AbmRegimen
{
    partial class FrmModificarRegimen
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
            this.lblCodigoMod = new System.Windows.Forms.Label();
            this.txtCodigoMod = new System.Windows.Forms.TextBox();
            this.lblPrecioMod = new System.Windows.Forms.Label();
            this.txtPrecioMod = new System.Windows.Forms.TextBox();
            this.lblDescripcionMod = new System.Windows.Forms.Label();
            this.txtDescripcionMod = new System.Windows.Forms.TextBox();
            this.lblEstadoMod = new System.Windows.Forms.Label();
            this.cboEstadoMod = new System.Windows.Forms.ComboBox();
            this.butLimpiarMod = new System.Windows.Forms.Button();
            this.butGuardarMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigoMod
            // 
            this.lblCodigoMod.AutoSize = true;
            this.lblCodigoMod.Location = new System.Drawing.Point(12, 9);
            this.lblCodigoMod.Name = "lblCodigoMod";
            this.lblCodigoMod.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoMod.TabIndex = 0;
            this.lblCodigoMod.Text = "Codigo";
            // 
            // txtCodigoMod
            // 
            this.txtCodigoMod.Location = new System.Drawing.Point(58, 6);
            this.txtCodigoMod.Name = "txtCodigoMod";
            this.txtCodigoMod.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoMod.TabIndex = 1;
            // 
            // lblPrecioMod
            // 
            this.lblPrecioMod.AutoSize = true;
            this.lblPrecioMod.Location = new System.Drawing.Point(12, 31);
            this.lblPrecioMod.Name = "lblPrecioMod";
            this.lblPrecioMod.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioMod.TabIndex = 2;
            this.lblPrecioMod.Text = "Precio";
            // 
            // txtPrecioMod
            // 
            this.txtPrecioMod.Location = new System.Drawing.Point(58, 28);
            this.txtPrecioMod.Name = "txtPrecioMod";
            this.txtPrecioMod.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioMod.TabIndex = 3;
            this.txtPrecioMod.Text = "U$";
            // 
            // lblDescripcionMod
            // 
            this.lblDescripcionMod.AutoSize = true;
            this.lblDescripcionMod.Location = new System.Drawing.Point(12, 56);
            this.lblDescripcionMod.Name = "lblDescripcionMod";
            this.lblDescripcionMod.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionMod.TabIndex = 4;
            this.lblDescripcionMod.Text = "Descripcion";
            // 
            // txtDescripcionMod
            // 
            this.txtDescripcionMod.Location = new System.Drawing.Point(81, 53);
            this.txtDescripcionMod.Multiline = true;
            this.txtDescripcionMod.Name = "txtDescripcionMod";
            this.txtDescripcionMod.Size = new System.Drawing.Size(191, 82);
            this.txtDescripcionMod.TabIndex = 5;
            // 
            // lblEstadoMod
            // 
            this.lblEstadoMod.AutoSize = true;
            this.lblEstadoMod.Location = new System.Drawing.Point(12, 144);
            this.lblEstadoMod.Name = "lblEstadoMod";
            this.lblEstadoMod.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoMod.TabIndex = 6;
            this.lblEstadoMod.Text = "Estado";
            // 
            // cboEstadoMod
            // 
            this.cboEstadoMod.FormattingEnabled = true;
            this.cboEstadoMod.Location = new System.Drawing.Point(58, 141);
            this.cboEstadoMod.Name = "cboEstadoMod";
            this.cboEstadoMod.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoMod.TabIndex = 7;
            // 
            // butLimpiarMod
            // 
            this.butLimpiarMod.Location = new System.Drawing.Point(12, 181);
            this.butLimpiarMod.Name = "butLimpiarMod";
            this.butLimpiarMod.Size = new System.Drawing.Size(75, 23);
            this.butLimpiarMod.TabIndex = 8;
            this.butLimpiarMod.Text = "Limpiar";
            this.butLimpiarMod.UseVisualStyleBackColor = true;
            // 
            // butGuardarMod
            // 
            this.butGuardarMod.Location = new System.Drawing.Point(216, 181);
            this.butGuardarMod.Name = "butGuardarMod";
            this.butGuardarMod.Size = new System.Drawing.Size(75, 23);
            this.butGuardarMod.TabIndex = 9;
            this.butGuardarMod.Text = "Guardar";
            this.butGuardarMod.UseVisualStyleBackColor = true;
            // 
            // FrmModificarRegimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 210);
            this.Controls.Add(this.butGuardarMod);
            this.Controls.Add(this.butLimpiarMod);
            this.Controls.Add(this.cboEstadoMod);
            this.Controls.Add(this.lblEstadoMod);
            this.Controls.Add(this.txtDescripcionMod);
            this.Controls.Add(this.lblDescripcionMod);
            this.Controls.Add(this.txtPrecioMod);
            this.Controls.Add(this.lblPrecioMod);
            this.Controls.Add(this.txtCodigoMod);
            this.Controls.Add(this.lblCodigoMod);
            this.Name = "FrmModificarRegimen";
            this.Text = "Modificar Regimen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoMod;
        private System.Windows.Forms.TextBox txtCodigoMod;
        private System.Windows.Forms.Label lblPrecioMod;
        private System.Windows.Forms.TextBox txtPrecioMod;
        private System.Windows.Forms.Label lblDescripcionMod;
        private System.Windows.Forms.TextBox txtDescripcionMod;
        private System.Windows.Forms.Label lblEstadoMod;
        private System.Windows.Forms.ComboBox cboEstadoMod;
        private System.Windows.Forms.Button butLimpiarMod;
        private System.Windows.Forms.Button butGuardarMod;
    }
}