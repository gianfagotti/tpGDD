namespace FrbaHotel.AbmRol
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
            this.grbHabitaciones = new System.Windows.Forms.GroupBox();
            this.grbRegimenes = new System.Windows.Forms.GroupBox();
            this.grbRoles = new System.Windows.Forms.GroupBox();
            this.grbReservas = new System.Windows.Forms.GroupBox();
            this.grbConsumibles = new System.Windows.Forms.GroupBox();
            this.grbEstadias = new System.Windows.Forms.GroupBox();
            this.grbListado = new System.Windows.Forms.GroupBox();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnModificarReserva = new System.Windows.Forms.Button();
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            this.btnModificarRol = new System.Windows.Forms.Button();
            this.btnAltaRol = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.grbRoles.SuspendLayout();
            this.grbReservas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHuespedes
            // 
            this.grbHuespedes.Location = new System.Drawing.Point(507, 140);
            this.grbHuespedes.Name = "grbHuespedes";
            this.grbHuespedes.Size = new System.Drawing.Size(200, 100);
            this.grbHuespedes.TabIndex = 0;
            this.grbHuespedes.TabStop = false;
            this.grbHuespedes.Text = "Administración de huespedes";
            // 
            // grbHabitaciones
            // 
            this.grbHabitaciones.Location = new System.Drawing.Point(264, 140);
            this.grbHabitaciones.Name = "grbHabitaciones";
            this.grbHabitaciones.Size = new System.Drawing.Size(218, 100);
            this.grbHabitaciones.TabIndex = 1;
            this.grbHabitaciones.TabStop = false;
            this.grbHabitaciones.Text = "Administración de habitaciones";
            // 
            // grbRegimenes
            // 
            this.grbRegimenes.Location = new System.Drawing.Point(12, 257);
            this.grbRegimenes.Name = "grbRegimenes";
            this.grbRegimenes.Size = new System.Drawing.Size(221, 100);
            this.grbRegimenes.TabIndex = 2;
            this.grbRegimenes.TabStop = false;
            this.grbRegimenes.Text = "Administración de regímenes";
            // 
            // grbRoles
            // 
            this.grbRoles.Controls.Add(this.btnModificarRol);
            this.grbRoles.Controls.Add(this.btnAltaRol);
            this.grbRoles.Location = new System.Drawing.Point(264, 12);
            this.grbRoles.Name = "grbRoles";
            this.grbRoles.Size = new System.Drawing.Size(218, 100);
            this.grbRoles.TabIndex = 3;
            this.grbRoles.TabStop = false;
            this.grbRoles.Text = "Administración de roles";
            // 
            // grbReservas
            // 
            this.grbReservas.Controls.Add(this.btnCancelarReserva);
            this.grbReservas.Controls.Add(this.btnModificarReserva);
            this.grbReservas.Controls.Add(this.btnNuevaReserva);
            this.grbReservas.Location = new System.Drawing.Point(12, 12);
            this.grbReservas.Name = "grbReservas";
            this.grbReservas.Size = new System.Drawing.Size(221, 111);
            this.grbReservas.TabIndex = 4;
            this.grbReservas.TabStop = false;
            this.grbReservas.Text = "Administración de reservas";
            // 
            // grbConsumibles
            // 
            this.grbConsumibles.Location = new System.Drawing.Point(507, 12);
            this.grbConsumibles.Name = "grbConsumibles";
            this.grbConsumibles.Size = new System.Drawing.Size(200, 100);
            this.grbConsumibles.TabIndex = 5;
            this.grbConsumibles.TabStop = false;
            this.grbConsumibles.Text = "Administración de consumibles";
            // 
            // grbEstadias
            // 
            this.grbEstadias.Location = new System.Drawing.Point(13, 140);
            this.grbEstadias.Name = "grbEstadias";
            this.grbEstadias.Size = new System.Drawing.Size(220, 100);
            this.grbEstadias.TabIndex = 6;
            this.grbEstadias.TabStop = false;
            this.grbEstadias.Text = "Administración de estadías";
            // 
            // grbListado
            // 
            this.grbListado.Location = new System.Drawing.Point(264, 257);
            this.grbListado.Name = "grbListado";
            this.grbListado.Size = new System.Drawing.Size(218, 100);
            this.grbListado.TabIndex = 7;
            this.grbListado.TabStop = false;
            this.grbListado.Text = "Estadísticas";
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
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(507, 270);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(92, 23);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmMenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 464);
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
            this.Text = "Menú Principal";
            this.grbRoles.ResumeLayout(false);
            this.grbReservas.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}