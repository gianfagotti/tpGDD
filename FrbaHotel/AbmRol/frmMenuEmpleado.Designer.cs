﻿namespace FrbaHotel.AbmRol
{
    partial class frmMenuEmpleado
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
            this.grbHuespedes = new System.Windows.Forms.GroupBox();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.butBajaCliente = new System.Windows.Forms.Button();
            this.butAltaCliente = new System.Windows.Forms.Button();
            this.grbHabitaciones = new System.Windows.Forms.GroupBox();
            this.butBajaHab = new System.Windows.Forms.Button();
            this.butModHab = new System.Windows.Forms.Button();
            this.butCrearHabitacion = new System.Windows.Forms.Button();
            this.grbRegimenes = new System.Windows.Forms.GroupBox();
            this.butBajaReg = new System.Windows.Forms.Button();
            this.butModReg = new System.Windows.Forms.Button();
            this.butCrearRegimen = new System.Windows.Forms.Button();
            this.grbRoles = new System.Windows.Forms.GroupBox();
            this.btnModificarRol = new System.Windows.Forms.Button();
            this.btnAltaRol = new System.Windows.Forms.Button();
            this.grbReservas = new System.Windows.Forms.GroupBox();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnModificarReserva = new System.Windows.Forms.Button();
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            this.grbConsumibles = new System.Windows.Forms.GroupBox();
            this.btnRegistrarConsumible = new System.Windows.Forms.Button();
            this.grbEstadias = new System.Windows.Forms.GroupBox();
            this.btnRegistrarEstadiabtnRegistrarEstadia = new System.Windows.Forms.Button();
            this.grbListado = new System.Windows.Forms.GroupBox();
            this.btnListadoEst = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.grbUsuarios = new System.Windows.Forms.GroupBox();
            this.btnRetocarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.grbHoteles = new System.Windows.Forms.GroupBox();
            this.btnModificarHotel = new System.Windows.Forms.Button();
            this.btnBajaHotel = new System.Windows.Forms.Button();
            this.btnNuevoHotel = new System.Windows.Forms.Button();
            this.btnCambiarRol = new System.Windows.Forms.Button();
            this.btnCambiarHotel = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfechinia = new System.Windows.Forms.TextBox();
            this.grbHuespedes.SuspendLayout();
            this.grbHabitaciones.SuspendLayout();
            this.grbRegimenes.SuspendLayout();
            this.grbRoles.SuspendLayout();
            this.grbReservas.SuspendLayout();
            this.grbConsumibles.SuspendLayout();
            this.grbEstadias.SuspendLayout();
            this.grbListado.SuspendLayout();
            this.grbUsuarios.SuspendLayout();
            this.grbHoteles.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHuespedes
            // 
            this.grbHuespedes.Controls.Add(this.btnModificarUsuario);
            this.grbHuespedes.Controls.Add(this.butBajaCliente);
            this.grbHuespedes.Controls.Add(this.butAltaCliente);
            this.grbHuespedes.Enabled = false;
            this.grbHuespedes.Location = new System.Drawing.Point(514, 203);
            this.grbHuespedes.Name = "grbHuespedes";
            this.grbHuespedes.Size = new System.Drawing.Size(200, 111);
            this.grbHuespedes.TabIndex = 0;
            this.grbHuespedes.TabStop = false;
            this.grbHuespedes.Text = "Administración de huespedes";
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(27, 77);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(149, 23);
            this.btnModificarUsuario.TabIndex = 0;
            this.btnModificarUsuario.Text = "Modificar cliente";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // butBajaCliente
            // 
            this.butBajaCliente.Location = new System.Drawing.Point(27, 48);
            this.butBajaCliente.Name = "butBajaCliente";
            this.butBajaCliente.Size = new System.Drawing.Size(149, 23);
            this.butBajaCliente.TabIndex = 1;
            this.butBajaCliente.Text = "Dar de baja cliente";
            this.butBajaCliente.UseVisualStyleBackColor = true;
            this.butBajaCliente.Click += new System.EventHandler(this.butBajaCliente_Click);
            // 
            // butAltaCliente
            // 
            this.butAltaCliente.Location = new System.Drawing.Point(27, 19);
            this.butAltaCliente.Name = "butAltaCliente";
            this.butAltaCliente.Size = new System.Drawing.Size(149, 23);
            this.butAltaCliente.TabIndex = 0;
            this.butAltaCliente.Text = "Ingresar nuevo cliente";
            this.butAltaCliente.UseVisualStyleBackColor = true;
            this.butAltaCliente.Click += new System.EventHandler(this.butAltaCliente_Click);
            // 
            // grbHabitaciones
            // 
            this.grbHabitaciones.Controls.Add(this.butBajaHab);
            this.grbHabitaciones.Controls.Add(this.butModHab);
            this.grbHabitaciones.Controls.Add(this.butCrearHabitacion);
            this.grbHabitaciones.Enabled = false;
            this.grbHabitaciones.Location = new System.Drawing.Point(271, 203);
            this.grbHabitaciones.Name = "grbHabitaciones";
            this.grbHabitaciones.Size = new System.Drawing.Size(218, 111);
            this.grbHabitaciones.TabIndex = 1;
            this.grbHabitaciones.TabStop = false;
            this.grbHabitaciones.Text = "Administración de habitaciones";
            // 
            // butBajaHab
            // 
            this.butBajaHab.Location = new System.Drawing.Point(30, 77);
            this.butBajaHab.Name = "butBajaHab";
            this.butBajaHab.Size = new System.Drawing.Size(161, 23);
            this.butBajaHab.TabIndex = 2;
            this.butBajaHab.Text = "Inhabilitar habitación";
            this.butBajaHab.UseVisualStyleBackColor = true;
            this.butBajaHab.Click += new System.EventHandler(this.butBajaHab_Click);
            // 
            // butModHab
            // 
            this.butModHab.Location = new System.Drawing.Point(30, 48);
            this.butModHab.Name = "butModHab";
            this.butModHab.Size = new System.Drawing.Size(161, 23);
            this.butModHab.TabIndex = 1;
            this.butModHab.Text = "Modificar habitación";
            this.butModHab.UseVisualStyleBackColor = true;
            this.butModHab.Click += new System.EventHandler(this.butModHab_Click);
            // 
            // butCrearHabitacion
            // 
            this.butCrearHabitacion.Location = new System.Drawing.Point(30, 19);
            this.butCrearHabitacion.Name = "butCrearHabitacion";
            this.butCrearHabitacion.Size = new System.Drawing.Size(161, 23);
            this.butCrearHabitacion.TabIndex = 0;
            this.butCrearHabitacion.Text = "Ingresar nueva habitacion";
            this.butCrearHabitacion.UseVisualStyleBackColor = true;
            this.butCrearHabitacion.Click += new System.EventHandler(this.butCrearHabitacion_Click);
            // 
            // grbRegimenes
            // 
            this.grbRegimenes.Controls.Add(this.butBajaReg);
            this.grbRegimenes.Controls.Add(this.butModReg);
            this.grbRegimenes.Controls.Add(this.butCrearRegimen);
            this.grbRegimenes.Enabled = false;
            this.grbRegimenes.Location = new System.Drawing.Point(514, 84);
            this.grbRegimenes.Name = "grbRegimenes";
            this.grbRegimenes.Size = new System.Drawing.Size(200, 102);
            this.grbRegimenes.TabIndex = 2;
            this.grbRegimenes.TabStop = false;
            this.grbRegimenes.Text = "Administración de regímenes";
            // 
            // butBajaReg
            // 
            this.butBajaReg.Location = new System.Drawing.Point(33, 73);
            this.butBajaReg.Name = "butBajaReg";
            this.butBajaReg.Size = new System.Drawing.Size(149, 23);
            this.butBajaReg.TabIndex = 17;
            this.butBajaReg.Text = "Inhabilitar régimen";
            this.butBajaReg.UseVisualStyleBackColor = true;
            this.butBajaReg.Click += new System.EventHandler(this.butBajaReg_Click);
            // 
            // butModReg
            // 
            this.butModReg.Location = new System.Drawing.Point(33, 48);
            this.butModReg.Name = "butModReg";
            this.butModReg.Size = new System.Drawing.Size(149, 23);
            this.butModReg.TabIndex = 16;
            this.butModReg.Text = "Modificar régimen existente";
            this.butModReg.UseVisualStyleBackColor = true;
            this.butModReg.Click += new System.EventHandler(this.butModReg_Click);
            // 
            // butCrearRegimen
            // 
            this.butCrearRegimen.Location = new System.Drawing.Point(33, 19);
            this.butCrearRegimen.Name = "butCrearRegimen";
            this.butCrearRegimen.Size = new System.Drawing.Size(149, 23);
            this.butCrearRegimen.TabIndex = 0;
            this.butCrearRegimen.Text = "Crear nuevo regimen";
            this.butCrearRegimen.UseVisualStyleBackColor = true;
            this.butCrearRegimen.Click += new System.EventHandler(this.butCrearRegimen_Click);
            // 
            // grbRoles
            // 
            this.grbRoles.Controls.Add(this.btnModificarRol);
            this.grbRoles.Controls.Add(this.btnAltaRol);
            this.grbRoles.Enabled = false;
            this.grbRoles.Location = new System.Drawing.Point(271, 75);
            this.grbRoles.Name = "grbRoles";
            this.grbRoles.Size = new System.Drawing.Size(218, 111);
            this.grbRoles.TabIndex = 3;
            this.grbRoles.TabStop = false;
            this.grbRoles.Text = "Administración de roles";
            // 
            // btnModificarRol
            // 
            this.btnModificarRol.Location = new System.Drawing.Point(30, 51);
            this.btnModificarRol.Name = "btnModificarRol";
            this.btnModificarRol.Size = new System.Drawing.Size(161, 23);
            this.btnModificarRol.TabIndex = 10;
            this.btnModificarRol.Text = "Gestionar rol existente";
            this.btnModificarRol.UseVisualStyleBackColor = true;
            this.btnModificarRol.Click += new System.EventHandler(this.btnModificarRol_Click);
            // 
            // btnAltaRol
            // 
            this.btnAltaRol.Location = new System.Drawing.Point(30, 22);
            this.btnAltaRol.Name = "btnAltaRol";
            this.btnAltaRol.Size = new System.Drawing.Size(161, 23);
            this.btnAltaRol.TabIndex = 9;
            this.btnAltaRol.Text = "Habilitar nuevo rol";
            this.btnAltaRol.UseVisualStyleBackColor = true;
            this.btnAltaRol.Click += new System.EventHandler(this.btnAltaRol_Click);
            // 
            // grbReservas
            // 
            this.grbReservas.Controls.Add(this.btnCancelarReserva);
            this.grbReservas.Controls.Add(this.btnModificarReserva);
            this.grbReservas.Controls.Add(this.btnNuevaReserva);
            this.grbReservas.Enabled = false;
            this.grbReservas.Location = new System.Drawing.Point(19, 75);
            this.grbReservas.Name = "grbReservas";
            this.grbReservas.Size = new System.Drawing.Size(221, 111);
            this.grbReservas.TabIndex = 4;
            this.grbReservas.TabStop = false;
            this.grbReservas.Text = "Administración de reservas";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(33, 80);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(161, 23);
            this.btnCancelarReserva.TabIndex = 9;
            this.btnCancelarReserva.Text = "Cancelar reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnModificarReserva
            // 
            this.btnModificarReserva.Location = new System.Drawing.Point(33, 51);
            this.btnModificarReserva.Name = "btnModificarReserva";
            this.btnModificarReserva.Size = new System.Drawing.Size(161, 23);
            this.btnModificarReserva.TabIndex = 8;
            this.btnModificarReserva.Text = "Modificar reserva existente";
            this.btnModificarReserva.UseVisualStyleBackColor = true;
            this.btnModificarReserva.Click += new System.EventHandler(this.btnModificarReserva_Click);
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.Location = new System.Drawing.Point(33, 22);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.Size = new System.Drawing.Size(161, 23);
            this.btnNuevaReserva.TabIndex = 7;
            this.btnNuevaReserva.Text = "Generar nueva reserva";
            this.btnNuevaReserva.UseVisualStyleBackColor = true;
            this.btnNuevaReserva.Click += new System.EventHandler(this.btnNuevaReserva_Click);
            // 
            // grbConsumibles
            // 
            this.grbConsumibles.Controls.Add(this.btnRegistrarConsumible);
            this.grbConsumibles.Enabled = false;
            this.grbConsumibles.Location = new System.Drawing.Point(19, 262);
            this.grbConsumibles.Name = "grbConsumibles";
            this.grbConsumibles.Size = new System.Drawing.Size(221, 52);
            this.grbConsumibles.TabIndex = 5;
            this.grbConsumibles.TabStop = false;
            this.grbConsumibles.Text = "Administración de consumibles";
            // 
            // btnRegistrarConsumible
            // 
            this.btnRegistrarConsumible.Location = new System.Drawing.Point(33, 19);
            this.btnRegistrarConsumible.Name = "btnRegistrarConsumible";
            this.btnRegistrarConsumible.Size = new System.Drawing.Size(158, 23);
            this.btnRegistrarConsumible.TabIndex = 11;
            this.btnRegistrarConsumible.Text = "Registrar consumición";
            this.btnRegistrarConsumible.UseVisualStyleBackColor = true;
            this.btnRegistrarConsumible.Click += new System.EventHandler(this.btnRegistrarConsumible_Click);
            // 
            // grbEstadias
            // 
            this.grbEstadias.Controls.Add(this.btnRegistrarEstadiabtnRegistrarEstadia);
            this.grbEstadias.Enabled = false;
            this.grbEstadias.Location = new System.Drawing.Point(20, 203);
            this.grbEstadias.Name = "grbEstadias";
            this.grbEstadias.Size = new System.Drawing.Size(220, 53);
            this.grbEstadias.TabIndex = 6;
            this.grbEstadias.TabStop = false;
            this.grbEstadias.Text = "Administración de estadías";
            // 
            // btnRegistrarEstadiabtnRegistrarEstadia
            // 
            this.btnRegistrarEstadiabtnRegistrarEstadia.Location = new System.Drawing.Point(32, 21);
            this.btnRegistrarEstadiabtnRegistrarEstadia.Name = "btnRegistrarEstadiabtnRegistrarEstadia";
            this.btnRegistrarEstadiabtnRegistrarEstadia.Size = new System.Drawing.Size(161, 23);
            this.btnRegistrarEstadiabtnRegistrarEstadia.TabIndex = 10;
            this.btnRegistrarEstadiabtnRegistrarEstadia.Text = "Menú de estadía";
            this.btnRegistrarEstadiabtnRegistrarEstadia.UseVisualStyleBackColor = true;
            this.btnRegistrarEstadiabtnRegistrarEstadia.Click += new System.EventHandler(this.btnRegistrarEstadiabtnRegistrarEstadia_Click);
            // 
            // grbListado
            // 
            this.grbListado.Controls.Add(this.btnListadoEst);
            this.grbListado.Enabled = false;
            this.grbListado.Location = new System.Drawing.Point(514, 320);
            this.grbListado.Name = "grbListado";
            this.grbListado.Size = new System.Drawing.Size(200, 108);
            this.grbListado.TabIndex = 7;
            this.grbListado.TabStop = false;
            this.grbListado.Text = "Estadísticas";
            // 
            // btnListadoEst
            // 
            this.btnListadoEst.Location = new System.Drawing.Point(27, 19);
            this.btnListadoEst.Name = "btnListadoEst";
            this.btnListadoEst.Size = new System.Drawing.Size(149, 23);
            this.btnListadoEst.TabIndex = 1;
            this.btnListadoEst.Text = "Ver listado ";
            this.btnListadoEst.UseVisualStyleBackColor = true;
            this.btnListadoEst.Click += new System.EventHandler(this.btnListadoEst_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(622, 435);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(92, 23);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // grbUsuarios
            // 
            this.grbUsuarios.Controls.Add(this.btnRetocarUsuario);
            this.grbUsuarios.Controls.Add(this.btnNuevoUsuario);
            this.grbUsuarios.Enabled = false;
            this.grbUsuarios.Location = new System.Drawing.Point(271, 320);
            this.grbUsuarios.Name = "grbUsuarios";
            this.grbUsuarios.Size = new System.Drawing.Size(218, 108);
            this.grbUsuarios.TabIndex = 9;
            this.grbUsuarios.TabStop = false;
            this.grbUsuarios.Text = "Administración de usuarios";
            // 
            // btnRetocarUsuario
            // 
            this.btnRetocarUsuario.Location = new System.Drawing.Point(30, 48);
            this.btnRetocarUsuario.Name = "btnRetocarUsuario";
            this.btnRetocarUsuario.Size = new System.Drawing.Size(161, 23);
            this.btnRetocarUsuario.TabIndex = 1;
            this.btnRetocarUsuario.Text = "Modificar usuario";
            this.btnRetocarUsuario.UseVisualStyleBackColor = true;
            this.btnRetocarUsuario.Click += new System.EventHandler(this.btnRetocarUsuario_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(30, 19);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(161, 23);
            this.btnNuevoUsuario.TabIndex = 0;
            this.btnNuevoUsuario.Text = "Crear nuevo usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // grbHoteles
            // 
            this.grbHoteles.Controls.Add(this.btnModificarHotel);
            this.grbHoteles.Controls.Add(this.btnBajaHotel);
            this.grbHoteles.Controls.Add(this.btnNuevoHotel);
            this.grbHoteles.Enabled = false;
            this.grbHoteles.Location = new System.Drawing.Point(19, 320);
            this.grbHoteles.Name = "grbHoteles";
            this.grbHoteles.Size = new System.Drawing.Size(221, 108);
            this.grbHoteles.TabIndex = 10;
            this.grbHoteles.TabStop = false;
            this.grbHoteles.Text = "Administración de Hoteles";
            // 
            // btnModificarHotel
            // 
            this.btnModificarHotel.Location = new System.Drawing.Point(30, 77);
            this.btnModificarHotel.Name = "btnModificarHotel";
            this.btnModificarHotel.Size = new System.Drawing.Size(161, 23);
            this.btnModificarHotel.TabIndex = 2;
            this.btnModificarHotel.Text = "Modificar el Hotel";
            this.btnModificarHotel.UseVisualStyleBackColor = true;
            this.btnModificarHotel.Click += new System.EventHandler(this.btnModificarHotel_Click);
            // 
            // btnBajaHotel
            // 
            this.btnBajaHotel.Location = new System.Drawing.Point(30, 48);
            this.btnBajaHotel.Name = "btnBajaHotel";
            this.btnBajaHotel.Size = new System.Drawing.Size(161, 23);
            this.btnBajaHotel.TabIndex = 1;
            this.btnBajaHotel.Text = "Inhabilitar el Hotel";
            this.btnBajaHotel.UseVisualStyleBackColor = true;
            this.btnBajaHotel.Click += new System.EventHandler(this.btnBajaHotel_Click);
            // 
            // btnNuevoHotel
            // 
            this.btnNuevoHotel.Location = new System.Drawing.Point(30, 19);
            this.btnNuevoHotel.Name = "btnNuevoHotel";
            this.btnNuevoHotel.Size = new System.Drawing.Size(161, 23);
            this.btnNuevoHotel.TabIndex = 0;
            this.btnNuevoHotel.Text = "Dar de alta un Hotel";
            this.btnNuevoHotel.UseVisualStyleBackColor = true;
            this.btnNuevoHotel.Click += new System.EventHandler(this.btnNuevoHotel_Click);
            // 
            // btnCambiarRol
            // 
            this.btnCambiarRol.Location = new System.Drawing.Point(134, 434);
            this.btnCambiarRol.Name = "btnCambiarRol";
            this.btnCambiarRol.Size = new System.Drawing.Size(92, 23);
            this.btnCambiarRol.TabIndex = 11;
            this.btnCambiarRol.Text = "Cambiar rol";
            this.btnCambiarRol.UseVisualStyleBackColor = true;
            this.btnCambiarRol.Click += new System.EventHandler(this.btnCambiarRol_Click);
            // 
            // btnCambiarHotel
            // 
            this.btnCambiarHotel.Location = new System.Drawing.Point(36, 434);
            this.btnCambiarHotel.Name = "btnCambiarHotel";
            this.btnCambiarHotel.Size = new System.Drawing.Size(92, 23);
            this.btnCambiarHotel.TabIndex = 12;
            this.btnCambiarHotel.Text = "Cambiar hotel";
            this.btnCambiarHotel.UseVisualStyleBackColor = true;
            this.btnCambiarHotel.Click += new System.EventHandler(this.btnCambiarHotel_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(242, 9);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(277, 49);
            this.lbltitulo.TabIndex = 13;
            this.lbltitulo.Text = "Sistema de gestión hotelera FRBA-Hotel";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha del sistema:";
            // 
            // txtfechinia
            // 
            this.txtfechinia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechinia.Location = new System.Drawing.Point(36, 25);
            this.txtfechinia.Name = "txtfechinia";
            this.txtfechinia.ReadOnly = true;
            this.txtfechinia.Size = new System.Drawing.Size(166, 22);
            this.txtfechinia.TabIndex = 15;
            this.txtfechinia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 481);
            this.Controls.Add(this.txtfechinia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btnCambiarHotel);
            this.Controls.Add(this.btnCambiarRol);
            this.Controls.Add(this.grbHoteles);
            this.Controls.Add(this.grbUsuarios);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.grbReservas);
            this.Controls.Add(this.grbListado);
            this.Controls.Add(this.grbEstadias);
            this.Controls.Add(this.grbConsumibles);
            this.Controls.Add(this.grbRoles);
            this.Controls.Add(this.grbRegimenes);
            this.Controls.Add(this.grbHabitaciones);
            this.Controls.Add(this.grbHuespedes);
            this.Name = "frmMenuEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.grbHuespedes.ResumeLayout(false);
            this.grbHabitaciones.ResumeLayout(false);
            this.grbRegimenes.ResumeLayout(false);
            this.grbRoles.ResumeLayout(false);
            this.grbReservas.ResumeLayout(false);
            this.grbConsumibles.ResumeLayout(false);
            this.grbEstadias.ResumeLayout(false);
            this.grbListado.ResumeLayout(false);
            this.grbUsuarios.ResumeLayout(false);
            this.grbHoteles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHuespedes;
        private System.Windows.Forms.GroupBox grbHabitaciones;
        private System.Windows.Forms.GroupBox grbRegimenes;
        private System.Windows.Forms.GroupBox grbRoles;
        private System.Windows.Forms.GroupBox grbReservas;
        private System.Windows.Forms.GroupBox grbConsumibles;
        private System.Windows.Forms.GroupBox grbEstadias;
        private System.Windows.Forms.GroupBox grbListado;
        private System.Windows.Forms.Button btnModificarRol;
        private System.Windows.Forms.Button btnAltaRol;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnModificarReserva;
        private System.Windows.Forms.Button btnNuevaReserva;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button butAltaCliente;
        private System.Windows.Forms.Button butCrearHabitacion;
        private System.Windows.Forms.Button butCrearRegimen;
        private System.Windows.Forms.Button btnListadoEst;
        private System.Windows.Forms.Button btnRegistrarConsumible;
        private System.Windows.Forms.Button btnRegistrarEstadiabtnRegistrarEstadia;
        private System.Windows.Forms.GroupBox grbUsuarios;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button butBajaCliente;
        private System.Windows.Forms.Button butModHab;
        private System.Windows.Forms.Button butBajaHab;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnRetocarUsuario;
        private System.Windows.Forms.GroupBox grbHoteles;
        private System.Windows.Forms.Button btnModificarHotel;
        private System.Windows.Forms.Button btnBajaHotel;
        private System.Windows.Forms.Button btnNuevoHotel;
        private System.Windows.Forms.Button btnCambiarRol;
        private System.Windows.Forms.Button btnCambiarHotel;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfechinia;
        private System.Windows.Forms.Button butBajaReg;
        private System.Windows.Forms.Button butModReg;
    }
}