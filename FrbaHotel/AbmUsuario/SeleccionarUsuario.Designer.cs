namespace FrbaHotel.AbmUsuario
{
    partial class SeleccionarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el usuario que desea modificar:";
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(16, 41);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(305, 21);
            this.cboUsuarios.TabIndex = 1;
            this.cboUsuarios.SelectedIndexChanged += new System.EventHandler(this.cboUsuarios_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(16, 190);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(305, 24);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(16, 106);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(305, 24);
            this.btnDatos.TabIndex = 4;
            this.btnDatos.Text = "Modificar datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.Location = new System.Drawing.Point(16, 77);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(305, 23);
            this.btnCambiarEstado.TabIndex = 7;
            this.btnCambiarEstado.Text = "Habilitar/Inhabilitar usuario";
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(16, 134);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(305, 23);
            this.btnAñadir.TabIndex = 8;
            this.btnAñadir.Text = "Añadir Rol en Hotel";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(16, 161);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(305, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar Rol en Hotel";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // SeleccionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 224);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cboUsuarios);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEliminar;
    }
}