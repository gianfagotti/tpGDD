namespace FrbaHotel.AbmHotel
{
    partial class FrmBajaHotel
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
            this.lblBajaHotel = new System.Windows.Forms.Label();
            this.dtpFechaIncicioBajaHotel = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinBajaHotel = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.btnVolverBajaHotel = new System.Windows.Forms.Button();
            this.btnDarDeBajaHotel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBajaHotel
            // 
            this.lblBajaHotel.AutoSize = true;
            this.lblBajaHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBajaHotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBajaHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajaHotel.Location = new System.Drawing.Point(30, 9);
            this.lblBajaHotel.Name = "lblBajaHotel";
            this.lblBajaHotel.Size = new System.Drawing.Size(355, 22);
            this.lblBajaHotel.TabIndex = 2;
            this.lblBajaHotel.Text = "Ingrese los datos para dar de baja el hotel:";
            this.lblBajaHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechaIncicioBajaHotel
            // 
            this.dtpFechaIncicioBajaHotel.Location = new System.Drawing.Point(174, 75);
            this.dtpFechaIncicioBajaHotel.Name = "dtpFechaIncicioBajaHotel";
            this.dtpFechaIncicioBajaHotel.Size = new System.Drawing.Size(211, 20);
            this.dtpFechaIncicioBajaHotel.TabIndex = 19;
            // 
            // dtpFechaFinBajaHotel
            // 
            this.dtpFechaFinBajaHotel.Location = new System.Drawing.Point(174, 117);
            this.dtpFechaFinBajaHotel.Name = "dtpFechaFinBajaHotel";
            this.dtpFechaFinBajaHotel.Size = new System.Drawing.Size(211, 20);
            this.dtpFechaFinBajaHotel.TabIndex = 20;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(12, 75);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(153, 16);
            this.lblFechaInicio.TabIndex = 21;
            this.lblFechaInicio.Text = "Fecha inicio de baja:";
            this.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(12, 121);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(132, 16);
            this.lblFechaFin.TabIndex = 22;
            this.lblFechaFin.Text = "Fecha fin de baja:";
            this.lblFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolverBajaHotel
            // 
            this.btnVolverBajaHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVolverBajaHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverBajaHotel.Location = new System.Drawing.Point(234, 201);
            this.btnVolverBajaHotel.Name = "btnVolverBajaHotel";
            this.btnVolverBajaHotel.Size = new System.Drawing.Size(75, 27);
            this.btnVolverBajaHotel.TabIndex = 24;
            this.btnVolverBajaHotel.Text = "Volver";
            this.btnVolverBajaHotel.UseVisualStyleBackColor = false;
            this.btnVolverBajaHotel.Click += new System.EventHandler(this.btnVolverHotel_Click);
            // 
            // btnDarDeBajaHotel
            // 
            this.btnDarDeBajaHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDarDeBajaHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarDeBajaHotel.Location = new System.Drawing.Point(98, 201);
            this.btnDarDeBajaHotel.Name = "btnDarDeBajaHotel";
            this.btnDarDeBajaHotel.Size = new System.Drawing.Size(104, 27);
            this.btnDarDeBajaHotel.TabIndex = 23;
            this.btnDarDeBajaHotel.Text = "Dar de baja";
            this.btnDarDeBajaHotel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Motivo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 26;
            // 
            // FrmBajaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 256);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverBajaHotel);
            this.Controls.Add(this.btnDarDeBajaHotel);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaFinBajaHotel);
            this.Controls.Add(this.dtpFechaIncicioBajaHotel);
            this.Controls.Add(this.lblBajaHotel);
            this.Name = "FrmBajaHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBajaHotel;
        private System.Windows.Forms.DateTimePicker dtpFechaIncicioBajaHotel;
        private System.Windows.Forms.DateTimePicker dtpFechaFinBajaHotel;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Button btnVolverBajaHotel;
        private System.Windows.Forms.Button btnDarDeBajaHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}