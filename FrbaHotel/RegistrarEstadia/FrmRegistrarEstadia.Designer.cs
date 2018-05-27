namespace FrbaHotel.RegistrarEstadia
{
    partial class FrmRegistrarEstadia
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
            this.LblRegistrarEstadia = new System.Windows.Forms.Label();
            this.LblNumeroDeReserva = new System.Windows.Forms.Label();
            this.TxtNumeroDeRerserva = new System.Windows.Forms.TextBox();
            this.LblCheckIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSeleccioneHotel = new System.Windows.Forms.ComboBox();
            this.TxtCheckOut = new System.Windows.Forms.TextBox();
            this.TxtCheckIn = new System.Windows.Forms.TextBox();
            this.BtnFechaCheckInYOut = new System.Windows.Forms.Button();
            this.PnlCheckInYOut = new System.Windows.Forms.Panel();
            this.BtnAceptarCheckInYOut = new System.Windows.Forms.Button();
            this.McrCheckInYOut = new System.Windows.Forms.MonthCalendar();
            this.lblDiasEfectivos = new System.Windows.Forms.Label();
            this.TxtDiasEfectivos = new System.Windows.Forms.TextBox();
            this.LblAgregarHuésped = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblAl = new System.Windows.Forms.Label();
            this.LblHuéspedes = new System.Windows.Forms.Label();
            this.PnlCheckInYOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRegistrarEstadia
            // 
            this.LblRegistrarEstadia.AutoSize = true;
            this.LblRegistrarEstadia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblRegistrarEstadia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRegistrarEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrarEstadia.Location = new System.Drawing.Point(275, 3);
            this.LblRegistrarEstadia.Name = "LblRegistrarEstadia";
            this.LblRegistrarEstadia.Size = new System.Drawing.Size(265, 22);
            this.LblRegistrarEstadia.TabIndex = 1;
            this.LblRegistrarEstadia.Text = "Ingrese los datos de la Estadia:";
            this.LblRegistrarEstadia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNumeroDeReserva
            // 
            this.LblNumeroDeReserva.AutoSize = true;
            this.LblNumeroDeReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroDeReserva.Location = new System.Drawing.Point(9, 85);
            this.LblNumeroDeReserva.Name = "LblNumeroDeReserva";
            this.LblNumeroDeReserva.Size = new System.Drawing.Size(145, 16);
            this.LblNumeroDeReserva.TabIndex = 2;
            this.LblNumeroDeReserva.Text = "Numero de reserva:";
            this.LblNumeroDeReserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNumeroDeRerserva
            // 
            this.TxtNumeroDeRerserva.Location = new System.Drawing.Point(247, 81);
            this.TxtNumeroDeRerserva.Name = "TxtNumeroDeRerserva";
            this.TxtNumeroDeRerserva.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroDeRerserva.TabIndex = 3;
            // 
            // LblCheckIn
            // 
            this.LblCheckIn.AutoSize = true;
            this.LblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCheckIn.Location = new System.Drawing.Point(9, 133);
            this.LblCheckIn.Name = "LblCheckIn";
            this.LblCheckIn.Size = new System.Drawing.Size(157, 16);
            this.LblCheckIn.TabIndex = 4;
            this.LblCheckIn.Text = "Check-In y Check-out:";
            this.LblCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione un hotel:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmbSeleccioneHotel
            // 
            this.CmbSeleccioneHotel.FormattingEnabled = true;
            this.CmbSeleccioneHotel.Location = new System.Drawing.Point(247, 47);
            this.CmbSeleccioneHotel.Name = "CmbSeleccioneHotel";
            this.CmbSeleccioneHotel.Size = new System.Drawing.Size(121, 21);
            this.CmbSeleccioneHotel.TabIndex = 9;
            // 
            // TxtCheckOut
            // 
            this.TxtCheckOut.Location = new System.Drawing.Point(290, 156);
            this.TxtCheckOut.Name = "TxtCheckOut";
            this.TxtCheckOut.ReadOnly = true;
            this.TxtCheckOut.Size = new System.Drawing.Size(100, 20);
            this.TxtCheckOut.TabIndex = 8;
            this.TxtCheckOut.TextChanged += new System.EventHandler(this.TxtCheckOut_TextChanged);
            // 
            // TxtCheckIn
            // 
            this.TxtCheckIn.Location = new System.Drawing.Point(290, 114);
            this.TxtCheckIn.Name = "TxtCheckIn";
            this.TxtCheckIn.ReadOnly = true;
            this.TxtCheckIn.Size = new System.Drawing.Size(100, 20);
            this.TxtCheckIn.TabIndex = 7;
            this.TxtCheckIn.TextChanged += new System.EventHandler(this.TxtCheckIn_TextChanged);
            // 
            // BtnFechaCheckInYOut
            // 
            this.BtnFechaCheckInYOut.Location = new System.Drawing.Point(190, 130);
            this.BtnFechaCheckInYOut.Name = "BtnFechaCheckInYOut";
            this.BtnFechaCheckInYOut.Size = new System.Drawing.Size(75, 23);
            this.BtnFechaCheckInYOut.TabIndex = 10;
            this.BtnFechaCheckInYOut.Text = "Seleccionar";
            this.BtnFechaCheckInYOut.UseVisualStyleBackColor = true;
            this.BtnFechaCheckInYOut.Click += new System.EventHandler(this.BtnFechaCheckIn_Click);
            // 
            // PnlCheckInYOut
            // 
            this.PnlCheckInYOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCheckInYOut.Controls.Add(this.BtnAceptarCheckInYOut);
            this.PnlCheckInYOut.Controls.Add(this.McrCheckInYOut);
            this.PnlCheckInYOut.Location = new System.Drawing.Point(459, 47);
            this.PnlCheckInYOut.Name = "PnlCheckInYOut";
            this.PnlCheckInYOut.Size = new System.Drawing.Size(300, 213);
            this.PnlCheckInYOut.TabIndex = 13;
            this.PnlCheckInYOut.Visible = false;
            // 
            // BtnAceptarCheckInYOut
            // 
            this.BtnAceptarCheckInYOut.Location = new System.Drawing.Point(109, 183);
            this.BtnAceptarCheckInYOut.Name = "BtnAceptarCheckInYOut";
            this.BtnAceptarCheckInYOut.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptarCheckInYOut.TabIndex = 1;
            this.BtnAceptarCheckInYOut.Text = "Aceptar";
            this.BtnAceptarCheckInYOut.UseVisualStyleBackColor = true;
            this.BtnAceptarCheckInYOut.Click += new System.EventHandler(this.BtnAceptarCheckInYOut_Click);
            // 
            // McrCheckInYOut
            // 
            this.McrCheckInYOut.Location = new System.Drawing.Point(27, 9);
            this.McrCheckInYOut.Name = "McrCheckInYOut";
            this.McrCheckInYOut.TabIndex = 0;
            // 
            // lblDiasEfectivos
            // 
            this.lblDiasEfectivos.AutoSize = true;
            this.lblDiasEfectivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasEfectivos.Location = new System.Drawing.Point(9, 191);
            this.lblDiasEfectivos.Name = "lblDiasEfectivos";
            this.lblDiasEfectivos.Size = new System.Drawing.Size(111, 16);
            this.lblDiasEfectivos.TabIndex = 14;
            this.lblDiasEfectivos.Text = "Días efectivos:";
            this.lblDiasEfectivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtDiasEfectivos
            // 
            this.TxtDiasEfectivos.Location = new System.Drawing.Point(247, 191);
            this.TxtDiasEfectivos.Name = "TxtDiasEfectivos";
            this.TxtDiasEfectivos.Size = new System.Drawing.Size(100, 20);
            this.TxtDiasEfectivos.TabIndex = 15;
            // 
            // LblAgregarHuésped
            // 
            this.LblAgregarHuésped.AutoSize = true;
            this.LblAgregarHuésped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgregarHuésped.Location = new System.Drawing.Point(9, 229);
            this.LblAgregarHuésped.Name = "LblAgregarHuésped";
            this.LblAgregarHuésped.Size = new System.Drawing.Size(158, 16);
            this.LblAgregarHuésped.TabIndex = 16;
            this.LblAgregarHuésped.Text = "Agregar Un Huésped:";
            this.LblAgregarHuésped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Seleccionar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Registrar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(339, 475);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 19;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.Tel,
            this.Nacionalidad,
            this.Mail});
            this.dataGridView1.Location = new System.Drawing.Point(73, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            // 
            // LblAl
            // 
            this.LblAl.AutoSize = true;
            this.LblAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAl.Location = new System.Drawing.Point(326, 137);
            this.LblAl.Name = "LblAl";
            this.LblAl.Size = new System.Drawing.Size(19, 16);
            this.LblAl.TabIndex = 21;
            this.LblAl.Text = "al";
            this.LblAl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHuéspedes
            // 
            this.LblHuéspedes.AutoSize = true;
            this.LblHuéspedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHuéspedes.Location = new System.Drawing.Point(336, 284);
            this.LblHuéspedes.Name = "LblHuéspedes";
            this.LblHuéspedes.Size = new System.Drawing.Size(92, 16);
            this.LblHuéspedes.TabIndex = 22;
            this.LblHuéspedes.Text = "Huéspedes:";
            this.LblHuéspedes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRegistrarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 510);
            this.Controls.Add(this.LblHuéspedes);
            this.Controls.Add(this.LblAl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblAgregarHuésped);
            this.Controls.Add(this.TxtDiasEfectivos);
            this.Controls.Add(this.lblDiasEfectivos);
            this.Controls.Add(this.PnlCheckInYOut);
            this.Controls.Add(this.BtnFechaCheckInYOut);
            this.Controls.Add(this.CmbSeleccioneHotel);
            this.Controls.Add(this.TxtCheckOut);
            this.Controls.Add(this.TxtCheckIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblCheckIn);
            this.Controls.Add(this.TxtNumeroDeRerserva);
            this.Controls.Add(this.LblNumeroDeReserva);
            this.Controls.Add(this.LblRegistrarEstadia);
            this.Name = "FrmRegistrarEstadia";
            this.Text = "Registrar Estadia";
            this.Load += new System.EventHandler(this.FrmRegistrarEstadia_Load);
            this.PnlCheckInYOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegistrarEstadia;
        private System.Windows.Forms.Label LblNumeroDeReserva;
        private System.Windows.Forms.TextBox TxtNumeroDeRerserva;
        private System.Windows.Forms.Label LblCheckIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSeleccioneHotel;
        private System.Windows.Forms.TextBox TxtCheckOut;
        private System.Windows.Forms.TextBox TxtCheckIn;
        private System.Windows.Forms.Button BtnFechaCheckInYOut;
        private System.Windows.Forms.Panel PnlCheckInYOut;
        private System.Windows.Forms.Button BtnAceptarCheckInYOut;
        private System.Windows.Forms.MonthCalendar McrCheckInYOut;
        private System.Windows.Forms.Label lblDiasEfectivos;
        private System.Windows.Forms.TextBox TxtDiasEfectivos;
        private System.Windows.Forms.Label LblAgregarHuésped;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.Label LblHuéspedes;
    }
}