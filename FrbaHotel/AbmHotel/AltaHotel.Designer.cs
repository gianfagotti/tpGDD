namespace FrbaHotel.AbmHotel
{
    partial class FrmAltaHotel
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
            this.lblDatosHotel = new System.Windows.Forms.Label();
            this.lblNombreHotel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCantidadDeEstrellas = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblRegimenes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreHotel = new System.Windows.Forms.TextBox();
            this.txtMailHotel = new System.Windows.Forms.TextBox();
            this.txtTelefonoHotel = new System.Windows.Forms.TextBox();
            this.txtDireccionHotel = new System.Windows.Forms.TextBox();
            this.txtCantidadDeEstrellasHotel = new System.Windows.Forms.TextBox();
            this.txtCiudadHotel = new System.Windows.Forms.TextBox();
            this.txtPaisHotel = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.clbRegimenesHotel = new System.Windows.Forms.CheckedListBox();
            this.btnCrearHotel = new System.Windows.Forms.Button();
            this.btnBorrarTextosHotel = new System.Windows.Forms.Button();
            this.btnVolverHotel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatosHotel
            // 
            this.lblDatosHotel.AutoSize = true;
            this.lblDatosHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDatosHotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDatosHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosHotel.Location = new System.Drawing.Point(166, 20);
            this.lblDatosHotel.Name = "lblDatosHotel";
            this.lblDatosHotel.Size = new System.Drawing.Size(229, 22);
            this.lblDatosHotel.TabIndex = 1;
            this.lblDatosHotel.Text = "Ingrese los datos del hotel:";
            this.lblDatosHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDatosHotel.Click += new System.EventHandler(this.lblDatosHotel_Click);
            // 
            // lblNombreHotel
            // 
            this.lblNombreHotel.AutoSize = true;
            this.lblNombreHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreHotel.Location = new System.Drawing.Point(46, 81);
            this.lblNombreHotel.Name = "lblNombreHotel";
            this.lblNombreHotel.Size = new System.Drawing.Size(67, 16);
            this.lblNombreHotel.TabIndex = 2;
            this.lblNombreHotel.Text = "Nombre:";
            this.lblNombreHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(46, 131);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 16);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail:";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMail.Click += new System.EventHandler(this.lblMail_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(46, 176);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 16);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(46, 223);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(78, 16);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadDeEstrellas
            // 
            this.lblCantidadDeEstrellas.AutoSize = true;
            this.lblCantidadDeEstrellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeEstrellas.Location = new System.Drawing.Point(46, 274);
            this.lblCantidadDeEstrellas.Name = "lblCantidadDeEstrellas";
            this.lblCantidadDeEstrellas.Size = new System.Drawing.Size(161, 16);
            this.lblCantidadDeEstrellas.TabIndex = 6;
            this.lblCantidadDeEstrellas.Text = "Cantidad de Estrellas:";
            this.lblCantidadDeEstrellas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCantidadDeEstrellas.Click += new System.EventHandler(this.lblCantidadDeEstrellas_Click);
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(46, 319);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(57, 16);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "Ciudad";
            this.lblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(46, 366);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(43, 16);
            this.lblPais.TabIndex = 8;
            this.lblPais.Text = "País:";
            this.lblPais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegimenes
            // 
            this.lblRegimenes.AutoSize = true;
            this.lblRegimenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegimenes.Location = new System.Drawing.Point(46, 404);
            this.lblRegimenes.Name = "lblRegimenes";
            this.lblRegimenes.Size = new System.Drawing.Size(91, 16);
            this.lblRegimenes.TabIndex = 9;
            this.lblRegimenes.Text = "Regímenes:";
            this.lblRegimenes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha de Creación:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreHotel
            // 
            this.txtNombreHotel.Location = new System.Drawing.Point(312, 77);
            this.txtNombreHotel.Name = "txtNombreHotel";
            this.txtNombreHotel.Size = new System.Drawing.Size(211, 20);
            this.txtNombreHotel.TabIndex = 11;
            // 
            // txtMailHotel
            // 
            this.txtMailHotel.Location = new System.Drawing.Point(312, 127);
            this.txtMailHotel.Name = "txtMailHotel";
            this.txtMailHotel.Size = new System.Drawing.Size(211, 20);
            this.txtMailHotel.TabIndex = 12;
            // 
            // txtTelefonoHotel
            // 
            this.txtTelefonoHotel.Location = new System.Drawing.Point(312, 176);
            this.txtTelefonoHotel.Name = "txtTelefonoHotel";
            this.txtTelefonoHotel.Size = new System.Drawing.Size(211, 20);
            this.txtTelefonoHotel.TabIndex = 13;
            // 
            // txtDireccionHotel
            // 
            this.txtDireccionHotel.Location = new System.Drawing.Point(312, 223);
            this.txtDireccionHotel.Name = "txtDireccionHotel";
            this.txtDireccionHotel.Size = new System.Drawing.Size(211, 20);
            this.txtDireccionHotel.TabIndex = 14;
            // 
            // txtCantidadDeEstrellasHotel
            // 
            this.txtCantidadDeEstrellasHotel.Location = new System.Drawing.Point(312, 270);
            this.txtCantidadDeEstrellasHotel.Name = "txtCantidadDeEstrellasHotel";
            this.txtCantidadDeEstrellasHotel.Size = new System.Drawing.Size(211, 20);
            this.txtCantidadDeEstrellasHotel.TabIndex = 15;
            // 
            // txtCiudadHotel
            // 
            this.txtCiudadHotel.Location = new System.Drawing.Point(312, 319);
            this.txtCiudadHotel.Name = "txtCiudadHotel";
            this.txtCiudadHotel.Size = new System.Drawing.Size(211, 20);
            this.txtCiudadHotel.TabIndex = 16;
            // 
            // txtPaisHotel
            // 
            this.txtPaisHotel.Location = new System.Drawing.Point(312, 362);
            this.txtPaisHotel.Name = "txtPaisHotel";
            this.txtPaisHotel.Size = new System.Drawing.Size(211, 20);
            this.txtPaisHotel.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 516);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // clbRegimenesHotel
            // 
            this.clbRegimenesHotel.FormattingEnabled = true;
            this.clbRegimenesHotel.Location = new System.Drawing.Point(312, 404);
            this.clbRegimenesHotel.Name = "clbRegimenesHotel";
            this.clbRegimenesHotel.Size = new System.Drawing.Size(211, 94);
            this.clbRegimenesHotel.TabIndex = 19;
            this.clbRegimenesHotel.Tag = "";
            // 
            // btnCrearHotel
            // 
            this.btnCrearHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCrearHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearHotel.Location = new System.Drawing.Point(132, 552);
            this.btnCrearHotel.Name = "btnCrearHotel";
            this.btnCrearHotel.Size = new System.Drawing.Size(75, 27);
            this.btnCrearHotel.TabIndex = 20;
            this.btnCrearHotel.Text = "Crear";
            this.btnCrearHotel.UseVisualStyleBackColor = false;
            this.btnCrearHotel.Click += new System.EventHandler(this.btnCrearHotel_Click);
            // 
            // btnBorrarTextosHotel
            // 
            this.btnBorrarTextosHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBorrarTextosHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTextosHotel.Location = new System.Drawing.Point(242, 552);
            this.btnBorrarTextosHotel.Name = "btnBorrarTextosHotel";
            this.btnBorrarTextosHotel.Size = new System.Drawing.Size(75, 27);
            this.btnBorrarTextosHotel.TabIndex = 21;
            this.btnBorrarTextosHotel.Text = "Borrar";
            this.btnBorrarTextosHotel.UseVisualStyleBackColor = false;
            this.btnBorrarTextosHotel.Click += new System.EventHandler(this.btnBorrarTextosHotel_Click);
            // 
            // btnVolverHotel
            // 
            this.btnVolverHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVolverHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverHotel.Location = new System.Drawing.Point(352, 552);
            this.btnVolverHotel.Name = "btnVolverHotel";
            this.btnVolverHotel.Size = new System.Drawing.Size(75, 27);
            this.btnVolverHotel.TabIndex = 22;
            this.btnVolverHotel.Text = "Volver";
            this.btnVolverHotel.UseVisualStyleBackColor = false;
            this.btnVolverHotel.Click += new System.EventHandler(this.btnVolverHotel_Click);
            // 
            // FrmAltaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 591);
            this.Controls.Add(this.btnVolverHotel);
            this.Controls.Add(this.btnBorrarTextosHotel);
            this.Controls.Add(this.btnCrearHotel);
            this.Controls.Add(this.clbRegimenesHotel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPaisHotel);
            this.Controls.Add(this.txtCiudadHotel);
            this.Controls.Add(this.txtCantidadDeEstrellasHotel);
            this.Controls.Add(this.txtDireccionHotel);
            this.Controls.Add(this.txtTelefonoHotel);
            this.Controls.Add(this.txtMailHotel);
            this.Controls.Add(this.txtNombreHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegimenes);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblCantidadDeEstrellas);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblNombreHotel);
            this.Controls.Add(this.lblDatosHotel);
            this.Name = "FrmAltaHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de hotel";
            this.Load += new System.EventHandler(this.FrmAltaHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosHotel;
        private System.Windows.Forms.Label lblNombreHotel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCantidadDeEstrellas;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblRegimenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreHotel;
        private System.Windows.Forms.TextBox txtMailHotel;
        private System.Windows.Forms.TextBox txtTelefonoHotel;
        private System.Windows.Forms.TextBox txtDireccionHotel;
        private System.Windows.Forms.TextBox txtCantidadDeEstrellasHotel;
        private System.Windows.Forms.TextBox txtCiudadHotel;
        private System.Windows.Forms.TextBox txtPaisHotel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckedListBox clbRegimenesHotel;
        private System.Windows.Forms.Button btnCrearHotel;
        private System.Windows.Forms.Button btnBorrarTextosHotel;
        private System.Windows.Forms.Button btnVolverHotel;
    }
}