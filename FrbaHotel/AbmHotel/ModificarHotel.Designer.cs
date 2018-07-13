namespace FrbaHotel.AbmHotel
{
    partial class FrmModificarHotel
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
            this.txtRecargaPorEstrellasHotel = new System.Windows.Forms.TextBox();
            this.lblRecargaPorEstrellas = new System.Windows.Forms.Label();
            this.txtAlturaHotel = new System.Windows.Forms.TextBox();
            this.lblAlturaHotel = new System.Windows.Forms.Label();
            this.clbRegimenes = new System.Windows.Forms.CheckedListBox();
            this.btnVolverHotel = new System.Windows.Forms.Button();
            this.btnBorrarTextosHotel = new System.Windows.Forms.Button();
            this.btnModificarHotel = new System.Windows.Forms.Button();
            this.dtpFechaCreacionHotel = new System.Windows.Forms.DateTimePicker();
            this.txtPaisHotel = new System.Windows.Forms.TextBox();
            this.txtCiudadHotel = new System.Windows.Forms.TextBox();
            this.txtCalleHotel = new System.Windows.Forms.TextBox();
            this.txtTelefonoHotel = new System.Windows.Forms.TextBox();
            this.txtMailHotel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegimenes = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblCantidadDeEstrellas = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDatosHotel = new System.Windows.Forms.Label();
            this.lblNombreHotel = new System.Windows.Forms.Label();
            this.txtNombreHotel = new System.Windows.Forms.TextBox();
            this.cboCantidadDeEstrellas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtRecargaPorEstrellasHotel
            // 
            this.txtRecargaPorEstrellasHotel.Location = new System.Drawing.Point(309, 329);
            this.txtRecargaPorEstrellasHotel.Name = "txtRecargaPorEstrellasHotel";
            this.txtRecargaPorEstrellasHotel.Size = new System.Drawing.Size(211, 20);
            this.txtRecargaPorEstrellasHotel.TabIndex = 53;
            this.txtRecargaPorEstrellasHotel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloNumeros_KeyPress);
            // 
            // lblRecargaPorEstrellas
            // 
            this.lblRecargaPorEstrellas.AutoSize = true;
            this.lblRecargaPorEstrellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecargaPorEstrellas.Location = new System.Drawing.Point(43, 333);
            this.lblRecargaPorEstrellas.Name = "lblRecargaPorEstrellas";
            this.lblRecargaPorEstrellas.Size = new System.Drawing.Size(164, 16);
            this.lblRecargaPorEstrellas.TabIndex = 52;
            this.lblRecargaPorEstrellas.Text = "Recarga por Estrellas:";
            this.lblRecargaPorEstrellas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlturaHotel
            // 
            this.txtAlturaHotel.Location = new System.Drawing.Point(309, 243);
            this.txtAlturaHotel.Name = "txtAlturaHotel";
            this.txtAlturaHotel.Size = new System.Drawing.Size(211, 20);
            this.txtAlturaHotel.TabIndex = 51;
            this.txtAlturaHotel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloNumeros_KeyPress);
            // 
            // lblAlturaHotel
            // 
            this.lblAlturaHotel.AutoSize = true;
            this.lblAlturaHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlturaHotel.Location = new System.Drawing.Point(43, 247);
            this.lblAlturaHotel.Name = "lblAlturaHotel";
            this.lblAlturaHotel.Size = new System.Drawing.Size(52, 16);
            this.lblAlturaHotel.TabIndex = 50;
            this.lblAlturaHotel.Text = "Altura:";
            this.lblAlturaHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clbRegimenes
            // 
            this.clbRegimenes.FormattingEnabled = true;
            this.clbRegimenes.Location = new System.Drawing.Point(309, 451);
            this.clbRegimenes.Name = "clbRegimenes";
            this.clbRegimenes.Size = new System.Drawing.Size(211, 94);
            this.clbRegimenes.TabIndex = 49;
            // 
            // btnVolverHotel
            // 
            this.btnVolverHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVolverHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverHotel.Location = new System.Drawing.Point(344, 613);
            this.btnVolverHotel.Name = "btnVolverHotel";
            this.btnVolverHotel.Size = new System.Drawing.Size(75, 27);
            this.btnVolverHotel.TabIndex = 48;
            this.btnVolverHotel.Text = "Volver";
            this.btnVolverHotel.UseVisualStyleBackColor = false;
            this.btnVolverHotel.Click += new System.EventHandler(this.btnVolverHotel_Click_1);
            // 
            // btnBorrarTextosHotel
            // 
            this.btnBorrarTextosHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBorrarTextosHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTextosHotel.Location = new System.Drawing.Point(234, 613);
            this.btnBorrarTextosHotel.Name = "btnBorrarTextosHotel";
            this.btnBorrarTextosHotel.Size = new System.Drawing.Size(75, 27);
            this.btnBorrarTextosHotel.TabIndex = 47;
            this.btnBorrarTextosHotel.Text = "Limpiar";
            this.btnBorrarTextosHotel.UseVisualStyleBackColor = false;
            this.btnBorrarTextosHotel.Click += new System.EventHandler(this.btnBorrarTextosHotel_Click_1);
            // 
            // btnModificarHotel
            // 
            this.btnModificarHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnModificarHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarHotel.Location = new System.Drawing.Point(124, 613);
            this.btnModificarHotel.Name = "btnModificarHotel";
            this.btnModificarHotel.Size = new System.Drawing.Size(80, 27);
            this.btnModificarHotel.TabIndex = 46;
            this.btnModificarHotel.Text = "Modificar";
            this.btnModificarHotel.UseVisualStyleBackColor = false;
            this.btnModificarHotel.Click += new System.EventHandler(this.btnModificarHotel_Click);
            // 
            // dtpFechaCreacionHotel
            // 
            this.dtpFechaCreacionHotel.Location = new System.Drawing.Point(309, 562);
            this.dtpFechaCreacionHotel.Name = "dtpFechaCreacionHotel";
            this.dtpFechaCreacionHotel.Size = new System.Drawing.Size(211, 20);
            this.dtpFechaCreacionHotel.TabIndex = 45;
            // 
            // txtPaisHotel
            // 
            this.txtPaisHotel.Location = new System.Drawing.Point(309, 410);
            this.txtPaisHotel.Name = "txtPaisHotel";
            this.txtPaisHotel.Size = new System.Drawing.Size(211, 20);
            this.txtPaisHotel.TabIndex = 44;
            this.txtPaisHotel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloLetras_KeyPress);
            // 
            // txtCiudadHotel
            // 
            this.txtCiudadHotel.Location = new System.Drawing.Point(309, 368);
            this.txtCiudadHotel.Name = "txtCiudadHotel";
            this.txtCiudadHotel.Size = new System.Drawing.Size(211, 20);
            this.txtCiudadHotel.TabIndex = 43;
            this.txtCiudadHotel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloLetras_KeyPress);
            // 
            // txtCalleHotel
            // 
            this.txtCalleHotel.Location = new System.Drawing.Point(309, 202);
            this.txtCalleHotel.Name = "txtCalleHotel";
            this.txtCalleHotel.Size = new System.Drawing.Size(211, 20);
            this.txtCalleHotel.TabIndex = 41;
            this.txtCalleHotel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloLetras_KeyPress);
            // 
            // txtTelefonoHotel
            // 
            this.txtTelefonoHotel.Location = new System.Drawing.Point(309, 155);
            this.txtTelefonoHotel.Name = "txtTelefonoHotel";
            this.txtTelefonoHotel.Size = new System.Drawing.Size(211, 20);
            this.txtTelefonoHotel.TabIndex = 40;
            this.txtTelefonoHotel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloNumeros_KeyPress);
            // 
            // txtMailHotel
            // 
            this.txtMailHotel.Location = new System.Drawing.Point(309, 106);
            this.txtMailHotel.Name = "txtMailHotel";
            this.txtMailHotel.Size = new System.Drawing.Size(211, 20);
            this.txtMailHotel.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fecha de Creación:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegimenes
            // 
            this.lblRegimenes.AutoSize = true;
            this.lblRegimenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegimenes.Location = new System.Drawing.Point(43, 451);
            this.lblRegimenes.Name = "lblRegimenes";
            this.lblRegimenes.Size = new System.Drawing.Size(91, 16);
            this.lblRegimenes.TabIndex = 36;
            this.lblRegimenes.Text = "Regímenes:";
            this.lblRegimenes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(43, 410);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(43, 16);
            this.lblPais.TabIndex = 35;
            this.lblPais.Text = "País:";
            this.lblPais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(43, 368);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(61, 16);
            this.lblCiudad.TabIndex = 34;
            this.lblCiudad.Text = "Ciudad:";
            this.lblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadDeEstrellas
            // 
            this.lblCantidadDeEstrellas.AutoSize = true;
            this.lblCantidadDeEstrellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeEstrellas.Location = new System.Drawing.Point(43, 293);
            this.lblCantidadDeEstrellas.Name = "lblCantidadDeEstrellas";
            this.lblCantidadDeEstrellas.Size = new System.Drawing.Size(161, 16);
            this.lblCantidadDeEstrellas.TabIndex = 33;
            this.lblCantidadDeEstrellas.Text = "Cantidad de Estrellas:";
            this.lblCantidadDeEstrellas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(43, 202);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(48, 16);
            this.lblCalle.TabIndex = 32;
            this.lblCalle.Text = "Calle:";
            this.lblCalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(43, 155);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 16);
            this.lblTelefono.TabIndex = 31;
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(43, 110);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 16);
            this.lblMail.TabIndex = 30;
            this.lblMail.Text = "Mail:";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatosHotel
            // 
            this.lblDatosHotel.AutoSize = true;
            this.lblDatosHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDatosHotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDatosHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosHotel.Location = new System.Drawing.Point(128, 9);
            this.lblDatosHotel.Name = "lblDatosHotel";
            this.lblDatosHotel.Size = new System.Drawing.Size(291, 22);
            this.lblDatosHotel.TabIndex = 28;
            this.lblDatosHotel.Text = "Ingrese los nuevos datos del hotel:";
            this.lblDatosHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDatosHotel.Click += new System.EventHandler(this.lblDatosHotel_Click);
            // 
            // lblNombreHotel
            // 
            this.lblNombreHotel.AutoSize = true;
            this.lblNombreHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreHotel.Location = new System.Drawing.Point(43, 70);
            this.lblNombreHotel.Name = "lblNombreHotel";
            this.lblNombreHotel.Size = new System.Drawing.Size(67, 16);
            this.lblNombreHotel.TabIndex = 54;
            this.lblNombreHotel.Text = "Nombre:";
            this.lblNombreHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombreHotel.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombreHotel
            // 
            this.txtNombreHotel.Location = new System.Drawing.Point(309, 66);
            this.txtNombreHotel.Name = "txtNombreHotel";
            this.txtNombreHotel.Size = new System.Drawing.Size(211, 20);
            this.txtNombreHotel.TabIndex = 55;
            this.txtNombreHotel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloLetras_KeyPress);
            // 
            // cboCantidadDeEstrellas
            // 
            this.cboCantidadDeEstrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCantidadDeEstrellas.FormattingEnabled = true;
            this.cboCantidadDeEstrellas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cboCantidadDeEstrellas.Location = new System.Drawing.Point(307, 288);
            this.cboCantidadDeEstrellas.Name = "cboCantidadDeEstrellas";
            this.cboCantidadDeEstrellas.Size = new System.Drawing.Size(213, 21);
            this.cboCantidadDeEstrellas.TabIndex = 56;
            // 
            // FrmModificarHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 665);
            this.Controls.Add(this.cboCantidadDeEstrellas);
            this.Controls.Add(this.txtNombreHotel);
            this.Controls.Add(this.lblNombreHotel);
            this.Controls.Add(this.txtRecargaPorEstrellasHotel);
            this.Controls.Add(this.lblRecargaPorEstrellas);
            this.Controls.Add(this.txtAlturaHotel);
            this.Controls.Add(this.lblAlturaHotel);
            this.Controls.Add(this.clbRegimenes);
            this.Controls.Add(this.btnVolverHotel);
            this.Controls.Add(this.btnBorrarTextosHotel);
            this.Controls.Add(this.btnModificarHotel);
            this.Controls.Add(this.dtpFechaCreacionHotel);
            this.Controls.Add(this.txtPaisHotel);
            this.Controls.Add(this.txtCiudadHotel);
            this.Controls.Add(this.txtCalleHotel);
            this.Controls.Add(this.txtTelefonoHotel);
            this.Controls.Add(this.txtMailHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegimenes);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblCantidadDeEstrellas);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblDatosHotel);
            this.Name = "FrmModificarHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecargaPorEstrellasHotel;
        private System.Windows.Forms.Label lblRecargaPorEstrellas;
        private System.Windows.Forms.TextBox txtAlturaHotel;
        private System.Windows.Forms.Label lblAlturaHotel;
        private System.Windows.Forms.CheckedListBox clbRegimenes;
        private System.Windows.Forms.Button btnVolverHotel;
        private System.Windows.Forms.Button btnBorrarTextosHotel;
        private System.Windows.Forms.Button btnModificarHotel;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacionHotel;
        private System.Windows.Forms.TextBox txtPaisHotel;
        private System.Windows.Forms.TextBox txtCiudadHotel;
        private System.Windows.Forms.TextBox txtCalleHotel;
        private System.Windows.Forms.TextBox txtTelefonoHotel;
        private System.Windows.Forms.TextBox txtMailHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegimenes;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblCantidadDeEstrellas;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDatosHotel;
        private System.Windows.Forms.Label lblNombreHotel;
        private System.Windows.Forms.TextBox txtNombreHotel;
        private System.Windows.Forms.ComboBox cboCantidadDeEstrellas;
    }
}