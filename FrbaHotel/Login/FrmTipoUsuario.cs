﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class FrmTipoUsuario : Form
    {
    
        public static ConectorBaseDeDatos conexionBaseDeDatos = new ConectorBaseDeDatos();
        public static string usuario = "";
        public static DateTime fechaApp = FechaConfig.getDate();
        public static string fechaAppConvertida = fechaApp.Date.ToString("yyyy-MM-dd HH:mm:ss");
        public FrmTipoUsuario()
        {
            InitializeComponent();
            conexionBaseDeDatos.conectar();
            //Se actualiza el estado de la reserva segun la fecha del archivo config 
           string comandoReservas = "EXEC FAGD.SetearEstadosReservaSegunConfig '" + fechaAppConvertida + "'";
            SqlDataReader resultado = conexionBaseDeDatos.comando(comandoReservas);
            resultado.Close();
        }

        private void btnAceptarTipoUsuario_Click(object sender, EventArgs e)
        {
            if (cmbTiposDeUsuario.SelectedItem != null)
            {
                if (cmbTiposDeUsuario.SelectedItem.ToString() == "Cliente")
                {
                    usuario = "guest";
                    AbmRol.frmMenuCliente frmMenuCliente = new AbmRol.frmMenuCliente();
                    this.Hide();
                    frmMenuCliente.Show();
                }
                else
                {
                    usuario = "empleado";
                    FrmLoginUsuario frmLoginUsuario = new FrmLoginUsuario();
                    this.Hide();
                    frmLoginUsuario.Show();
                }
            }
            else 
            MessageBox.Show("Debe Seleccionar algún tipo de usuario","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void FrmTipoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmTipoUsuario_Load(object sender, EventArgs e)
        {

        }

        public static string encriptar(string clave)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(clave);

            System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);
            string hashstring = string.Empty;
            foreach (byte x in hash)
            {
                hashstring += String.Format("{0:x2}", x);
            }
            return hashstring;
        }


    }
}
