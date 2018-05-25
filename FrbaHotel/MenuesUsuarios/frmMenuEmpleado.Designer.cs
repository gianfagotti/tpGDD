namespace FrbaHotel.MenuesUsuarios
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
            this.lblOpcion = new System.Windows.Forms.Label();
            this.btnGenerarRol = new System.Windows.Forms.Button();
            this.btnModificarRol = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnModificarReserva = new System.Windows.Forms.Button();
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(12, 9);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(119, 13);
            this.lblOpcion.TabIndex = 6;
            this.lblOpcion.Text = "Seleccione una opción:";
            // 
            // btnGenerarRol
            // 
            this.btnGenerarRol.Location = new System.Drawing.Point(46, 37);
            this.btnGenerarRol.Name = "btnGenerarRol";
            this.btnGenerarRol.Size = new System.Drawing.Size(180, 23);
            this.btnGenerarRol.TabIndex = 7;
            this.btnGenerarRol.Text = "Generar nuevo Rol";
            this.btnGenerarRol.UseVisualStyleBackColor = true;
            // 
            // btnModificarRol
            // 
            this.btnModificarRol.Location = new System.Drawing.Point(46, 75);
            this.btnModificarRol.Name = "btnModificarRol";
            this.btnModificarRol.Size = new System.Drawing.Size(180, 23);
            this.btnModificarRol.TabIndex = 8;
            this.btnModificarRol.Text = "Modificar Rol Existente";
            this.btnModificarRol.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(46, 235);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(180, 23);
            this.btnCerrarSesion.TabIndex = 13;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(46, 195);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(180, 23);
            this.btnCancelarReserva.TabIndex = 12;
            this.btnCancelarReserva.Text = "Cancelar reserva existente";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // btnModificarReserva
            // 
            this.btnModificarReserva.Location = new System.Drawing.Point(46, 154);
            this.btnModificarReserva.Name = "btnModificarReserva";
            this.btnModificarReserva.Size = new System.Drawing.Size(180, 23);
            this.btnModificarReserva.TabIndex = 11;
            this.btnModificarReserva.Text = "Modificar reserva existente";
            this.btnModificarReserva.UseVisualStyleBackColor = true;
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.Location = new System.Drawing.Point(46, 113);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.Size = new System.Drawing.Size(180, 23);
            this.btnNuevaReserva.TabIndex = 10;
            this.btnNuevaReserva.Text = "Generar nueva reserva";
            this.btnNuevaReserva.UseVisualStyleBackColor = true;
            // 
            // frmMenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 286);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnModificarReserva);
            this.Controls.Add(this.btnNuevaReserva);
            this.Controls.Add(this.btnModificarRol);
            this.Controls.Add(this.btnGenerarRol);
            this.Controls.Add(this.lblOpcion);
            this.Name = "frmMenuEmpleado";
            this.Text = "Menú Principal";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Button btnGenerarRol;
        private System.Windows.Forms.Button btnModificarRol;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnModificarReserva;
        private System.Windows.Forms.Button btnNuevaReserva;
    }
}