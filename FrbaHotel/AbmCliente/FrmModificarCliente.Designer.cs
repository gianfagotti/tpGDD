﻿namespace FrbaHotel.AbmCliente
{
    partial class FrmModificarCliente
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
            this.lblNombreMod = new System.Windows.Forms.Label();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.lblApellidoMod = new System.Windows.Forms.Label();
            this.txtApellidoMod = new System.Windows.Forms.TextBox();
            this.lblTipoDocumentoMod = new System.Windows.Forms.Label();
            this.lblNroDocumentoMod = new System.Windows.Forms.Label();
            this.txtNroDocumentoMod = new System.Windows.Forms.TextBox();
            this.lblMailMod = new System.Windows.Forms.Label();
            this.txtMailMod = new System.Windows.Forms.TextBox();
            this.lblTelefonoMod = new System.Windows.Forms.Label();
            this.txtTelefonoMod = new System.Windows.Forms.TextBox();
            this.lblCalleMod = new System.Windows.Forms.Label();
            this.txtCalleMod = new System.Windows.Forms.TextBox();
            this.lblNumeroMod = new System.Windows.Forms.Label();
            this.txtNumeroMod = new System.Windows.Forms.TextBox();
            this.lblLocalidadMod = new System.Windows.Forms.Label();
            this.txtLocalidadMod = new System.Windows.Forms.TextBox();
            this.lblNacionalidadMod = new System.Windows.Forms.Label();
            this.lblFechaNacimientoMod = new System.Windows.Forms.Label();
            this.dtpFechaNacimientoMod = new System.Windows.Forms.DateTimePicker();
            this.chkHabilitadoMod = new System.Windows.Forms.CheckBox();
            this.butLimpiarMod = new System.Windows.Forms.Button();
            this.butGuardarMod = new System.Windows.Forms.Button();
            this.btnVolverMod = new System.Windows.Forms.Button();
            this.txtNacionalidadMod = new System.Windows.Forms.TextBox();
            this.lblPisoMod = new System.Windows.Forms.Label();
            this.lblDptoMod = new System.Windows.Forms.Label();
            this.txtPisoMod = new System.Windows.Forms.TextBox();
            this.txtDptoMod = new System.Windows.Forms.TextBox();
            this.cboTipoDocMod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombreMod
            // 
            this.lblNombreMod.AutoSize = true;
            this.lblNombreMod.Location = new System.Drawing.Point(40, 9);
            this.lblNombreMod.Name = "lblNombreMod";
            this.lblNombreMod.Size = new System.Drawing.Size(44, 13);
            this.lblNombreMod.TabIndex = 0;
            this.lblNombreMod.Text = "Nombre";
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(91, 6);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(353, 20);
            this.txtNombreMod.TabIndex = 1;
            this.txtNombreMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloLetras_KeyPress);
            // 
            // lblApellidoMod
            // 
            this.lblApellidoMod.AutoSize = true;
            this.lblApellidoMod.Location = new System.Drawing.Point(40, 35);
            this.lblApellidoMod.Name = "lblApellidoMod";
            this.lblApellidoMod.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoMod.TabIndex = 2;
            this.lblApellidoMod.Text = "Apellido";
            // 
            // txtApellidoMod
            // 
            this.txtApellidoMod.Location = new System.Drawing.Point(91, 32);
            this.txtApellidoMod.Name = "txtApellidoMod";
            this.txtApellidoMod.Size = new System.Drawing.Size(353, 20);
            this.txtApellidoMod.TabIndex = 3;
            this.txtApellidoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloLetras_KeyPress);
            // 
            // lblTipoDocumentoMod
            // 
            this.lblTipoDocumentoMod.AutoSize = true;
            this.lblTipoDocumentoMod.Location = new System.Drawing.Point(1, 64);
            this.lblTipoDocumentoMod.Name = "lblTipoDocumentoMod";
            this.lblTipoDocumentoMod.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDocumentoMod.TabIndex = 4;
            this.lblTipoDocumentoMod.Text = "Tipo Documento";
            // 
            // lblNroDocumentoMod
            // 
            this.lblNroDocumentoMod.AutoSize = true;
            this.lblNroDocumentoMod.Location = new System.Drawing.Point(210, 64);
            this.lblNroDocumentoMod.Name = "lblNroDocumentoMod";
            this.lblNroDocumentoMod.Size = new System.Drawing.Size(102, 13);
            this.lblNroDocumentoMod.TabIndex = 6;
            this.lblNroDocumentoMod.Text = "Numero Documento";
            // 
            // txtNroDocumentoMod
            // 
            this.txtNroDocumentoMod.Location = new System.Drawing.Point(315, 61);
            this.txtNroDocumentoMod.Name = "txtNroDocumentoMod";
            this.txtNroDocumentoMod.Size = new System.Drawing.Size(129, 20);
            this.txtNroDocumentoMod.TabIndex = 7;
            this.txtNroDocumentoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloNumeros_KeyPress);
            // 
            // lblMailMod
            // 
            this.lblMailMod.AutoSize = true;
            this.lblMailMod.Location = new System.Drawing.Point(58, 91);
            this.lblMailMod.Name = "lblMailMod";
            this.lblMailMod.Size = new System.Drawing.Size(26, 13);
            this.lblMailMod.TabIndex = 8;
            this.lblMailMod.Text = "Mail";
            // 
            // txtMailMod
            // 
            this.txtMailMod.Location = new System.Drawing.Point(91, 88);
            this.txtMailMod.Name = "txtMailMod";
            this.txtMailMod.Size = new System.Drawing.Size(353, 20);
            this.txtMailMod.TabIndex = 9;
            // 
            // lblTelefonoMod
            // 
            this.lblTelefonoMod.AutoSize = true;
            this.lblTelefonoMod.Location = new System.Drawing.Point(35, 120);
            this.lblTelefonoMod.Name = "lblTelefonoMod";
            this.lblTelefonoMod.Size = new System.Drawing.Size(49, 13);
            this.lblTelefonoMod.TabIndex = 10;
            this.lblTelefonoMod.Text = "Telefono";
            // 
            // txtTelefonoMod
            // 
            this.txtTelefonoMod.Location = new System.Drawing.Point(90, 117);
            this.txtTelefonoMod.Name = "txtTelefonoMod";
            this.txtTelefonoMod.Size = new System.Drawing.Size(354, 20);
            this.txtTelefonoMod.TabIndex = 11;
            this.txtTelefonoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloNumeros_KeyPress);
            // 
            // lblCalleMod
            // 
            this.lblCalleMod.AutoSize = true;
            this.lblCalleMod.Location = new System.Drawing.Point(54, 146);
            this.lblCalleMod.Name = "lblCalleMod";
            this.lblCalleMod.Size = new System.Drawing.Size(30, 13);
            this.lblCalleMod.TabIndex = 12;
            this.lblCalleMod.Text = "Calle";
            // 
            // txtCalleMod
            // 
            this.txtCalleMod.Location = new System.Drawing.Point(90, 143);
            this.txtCalleMod.Name = "txtCalleMod";
            this.txtCalleMod.Size = new System.Drawing.Size(100, 20);
            this.txtCalleMod.TabIndex = 13;
            this.txtCalleMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloLetras_KeyPress);
            // 
            // lblNumeroMod
            // 
            this.lblNumeroMod.AutoSize = true;
            this.lblNumeroMod.Location = new System.Drawing.Point(196, 146);
            this.lblNumeroMod.Name = "lblNumeroMod";
            this.lblNumeroMod.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroMod.TabIndex = 14;
            this.lblNumeroMod.Text = "Numero";
            // 
            // txtNumeroMod
            // 
            this.txtNumeroMod.Location = new System.Drawing.Point(239, 143);
            this.txtNumeroMod.Name = "txtNumeroMod";
            this.txtNumeroMod.Size = new System.Drawing.Size(53, 20);
            this.txtNumeroMod.TabIndex = 15;
            this.txtNumeroMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloNumeros_KeyPress);
            // 
            // lblLocalidadMod
            // 
            this.lblLocalidadMod.AutoSize = true;
            this.lblLocalidadMod.Location = new System.Drawing.Point(31, 174);
            this.lblLocalidadMod.Name = "lblLocalidadMod";
            this.lblLocalidadMod.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidadMod.TabIndex = 16;
            this.lblLocalidadMod.Text = "Localidad";
            // 
            // txtLocalidadMod
            // 
            this.txtLocalidadMod.Location = new System.Drawing.Point(90, 171);
            this.txtLocalidadMod.Name = "txtLocalidadMod";
            this.txtLocalidadMod.Size = new System.Drawing.Size(354, 20);
            this.txtLocalidadMod.TabIndex = 17;
            this.txtLocalidadMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloLetras_KeyPress);
            // 
            // lblNacionalidadMod
            // 
            this.lblNacionalidadMod.AutoSize = true;
            this.lblNacionalidadMod.Location = new System.Drawing.Point(15, 205);
            this.lblNacionalidadMod.Name = "lblNacionalidadMod";
            this.lblNacionalidadMod.Size = new System.Drawing.Size(69, 13);
            this.lblNacionalidadMod.TabIndex = 20;
            this.lblNacionalidadMod.Text = "Nacionalidad";
            // 
            // lblFechaNacimientoMod
            // 
            this.lblFechaNacimientoMod.AutoSize = true;
            this.lblFechaNacimientoMod.Location = new System.Drawing.Point(12, 235);
            this.lblFechaNacimientoMod.Name = "lblFechaNacimientoMod";
            this.lblFechaNacimientoMod.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNacimientoMod.TabIndex = 22;
            this.lblFechaNacimientoMod.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimientoMod
            // 
            this.dtpFechaNacimientoMod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimientoMod.Location = new System.Drawing.Point(124, 229);
            this.dtpFechaNacimientoMod.Name = "dtpFechaNacimientoMod";
            this.dtpFechaNacimientoMod.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaNacimientoMod.TabIndex = 23;
            // 
            // chkHabilitadoMod
            // 
            this.chkHabilitadoMod.AutoSize = true;
            this.chkHabilitadoMod.Location = new System.Drawing.Point(371, 235);
            this.chkHabilitadoMod.Name = "chkHabilitadoMod";
            this.chkHabilitadoMod.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitadoMod.TabIndex = 24;
            this.chkHabilitadoMod.Text = "Habilitado";
            this.chkHabilitadoMod.UseVisualStyleBackColor = true;
            // 
            // butLimpiarMod
            // 
            this.butLimpiarMod.Location = new System.Drawing.Point(12, 258);
            this.butLimpiarMod.Name = "butLimpiarMod";
            this.butLimpiarMod.Size = new System.Drawing.Size(75, 23);
            this.butLimpiarMod.TabIndex = 25;
            this.butLimpiarMod.Text = "Limpiar";
            this.butLimpiarMod.UseVisualStyleBackColor = true;
            this.butLimpiarMod.Click += new System.EventHandler(this.butLimpiarMod_Click);
            // 
            // butGuardarMod
            // 
            this.butGuardarMod.Location = new System.Drawing.Point(369, 258);
            this.butGuardarMod.Name = "butGuardarMod";
            this.butGuardarMod.Size = new System.Drawing.Size(75, 23);
            this.butGuardarMod.TabIndex = 26;
            this.butGuardarMod.Text = "Guardar";
            this.butGuardarMod.UseVisualStyleBackColor = true;
            this.butGuardarMod.Click += new System.EventHandler(this.butGuardarMod_Click);
            // 
            // btnVolverMod
            // 
            this.btnVolverMod.Location = new System.Drawing.Point(288, 258);
            this.btnVolverMod.Name = "btnVolverMod";
            this.btnVolverMod.Size = new System.Drawing.Size(75, 23);
            this.btnVolverMod.TabIndex = 27;
            this.btnVolverMod.Text = "Volver";
            this.btnVolverMod.UseVisualStyleBackColor = true;
            this.btnVolverMod.Click += new System.EventHandler(this.btnVolverMod_Click);
            // 
            // txtNacionalidadMod
            // 
            this.txtNacionalidadMod.Location = new System.Drawing.Point(90, 202);
            this.txtNacionalidadMod.Name = "txtNacionalidadMod";
            this.txtNacionalidadMod.Size = new System.Drawing.Size(354, 20);
            this.txtNacionalidadMod.TabIndex = 21;
            this.txtNacionalidadMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloLetras_KeyPress);
            // 
            // lblPisoMod
            // 
            this.lblPisoMod.AutoSize = true;
            this.lblPisoMod.Location = new System.Drawing.Point(298, 146);
            this.lblPisoMod.Name = "lblPisoMod";
            this.lblPisoMod.Size = new System.Drawing.Size(27, 13);
            this.lblPisoMod.TabIndex = 28;
            this.lblPisoMod.Text = "Piso";
            // 
            // lblDptoMod
            // 
            this.lblDptoMod.AutoSize = true;
            this.lblDptoMod.Location = new System.Drawing.Point(369, 146);
            this.lblDptoMod.Name = "lblDptoMod";
            this.lblDptoMod.Size = new System.Drawing.Size(30, 13);
            this.lblDptoMod.TabIndex = 29;
            this.lblDptoMod.Text = "Dpto";
            // 
            // txtPisoMod
            // 
            this.txtPisoMod.Location = new System.Drawing.Point(331, 143);
            this.txtPisoMod.Name = "txtPisoMod";
            this.txtPisoMod.Size = new System.Drawing.Size(32, 20);
            this.txtPisoMod.TabIndex = 30;
            this.txtPisoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloNumeros_KeyPress);
            // 
            // txtDptoMod
            // 
            this.txtDptoMod.Location = new System.Drawing.Point(405, 143);
            this.txtDptoMod.Name = "txtDptoMod";
            this.txtDptoMod.Size = new System.Drawing.Size(39, 20);
            this.txtDptoMod.TabIndex = 31;
            this.txtDptoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSoloLetras_KeyPress);
            // 
            // cboTipoDocMod
            // 
            this.cboTipoDocMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocMod.FormattingEnabled = true;
            this.cboTipoDocMod.Items.AddRange(new object[] {
            "DNI",
            "PASAPORTE",
            "CARNET EXT.",
            "RUC",
            "P. NACI.",
            "OTROS"});
            this.cboTipoDocMod.Location = new System.Drawing.Point(91, 61);
            this.cboTipoDocMod.Name = "cboTipoDocMod";
            this.cboTipoDocMod.Size = new System.Drawing.Size(113, 21);
            this.cboTipoDocMod.TabIndex = 32;
            // 
            // FrmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 293);
            this.Controls.Add(this.cboTipoDocMod);
            this.Controls.Add(this.txtDptoMod);
            this.Controls.Add(this.txtPisoMod);
            this.Controls.Add(this.lblDptoMod);
            this.Controls.Add(this.lblPisoMod);
            this.Controls.Add(this.btnVolverMod);
            this.Controls.Add(this.butGuardarMod);
            this.Controls.Add(this.butLimpiarMod);
            this.Controls.Add(this.chkHabilitadoMod);
            this.Controls.Add(this.dtpFechaNacimientoMod);
            this.Controls.Add(this.lblFechaNacimientoMod);
            this.Controls.Add(this.txtNacionalidadMod);
            this.Controls.Add(this.lblNacionalidadMod);
            this.Controls.Add(this.txtLocalidadMod);
            this.Controls.Add(this.lblLocalidadMod);
            this.Controls.Add(this.txtNumeroMod);
            this.Controls.Add(this.lblNumeroMod);
            this.Controls.Add(this.txtCalleMod);
            this.Controls.Add(this.lblCalleMod);
            this.Controls.Add(this.txtTelefonoMod);
            this.Controls.Add(this.lblTelefonoMod);
            this.Controls.Add(this.txtMailMod);
            this.Controls.Add(this.lblMailMod);
            this.Controls.Add(this.txtNroDocumentoMod);
            this.Controls.Add(this.lblNroDocumentoMod);
            this.Controls.Add(this.lblTipoDocumentoMod);
            this.Controls.Add(this.txtApellidoMod);
            this.Controls.Add(this.lblApellidoMod);
            this.Controls.Add(this.txtNombreMod);
            this.Controls.Add(this.lblNombreMod);
            this.Name = "FrmModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreMod;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.Label lblApellidoMod;
        private System.Windows.Forms.TextBox txtApellidoMod;
        private System.Windows.Forms.Label lblTipoDocumentoMod;
        private System.Windows.Forms.Label lblNroDocumentoMod;
        private System.Windows.Forms.TextBox txtNroDocumentoMod;
        private System.Windows.Forms.Label lblMailMod;
        private System.Windows.Forms.TextBox txtMailMod;
        private System.Windows.Forms.Label lblTelefonoMod;
        private System.Windows.Forms.TextBox txtTelefonoMod;
        private System.Windows.Forms.Label lblCalleMod;
        private System.Windows.Forms.TextBox txtCalleMod;
        private System.Windows.Forms.Label lblNumeroMod;
        private System.Windows.Forms.TextBox txtNumeroMod;
        private System.Windows.Forms.Label lblLocalidadMod;
        private System.Windows.Forms.TextBox txtLocalidadMod;
        private System.Windows.Forms.Label lblNacionalidadMod;
        private System.Windows.Forms.Label lblFechaNacimientoMod;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoMod;
        private System.Windows.Forms.CheckBox chkHabilitadoMod;
        private System.Windows.Forms.Button butLimpiarMod;
        private System.Windows.Forms.Button butGuardarMod;
        private System.Windows.Forms.Button btnVolverMod;
        private System.Windows.Forms.TextBox txtNacionalidadMod;
        private System.Windows.Forms.Label lblPisoMod;
        private System.Windows.Forms.Label lblDptoMod;
        private System.Windows.Forms.TextBox txtPisoMod;
        private System.Windows.Forms.TextBox txtDptoMod;
        private System.Windows.Forms.ComboBox cboTipoDocMod;
    }
}