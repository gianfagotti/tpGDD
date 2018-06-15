using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Configuration;


namespace FrbaHotel
{
    class Conexion
    {

        static string server = ConfigurationManager.AppSettings["server"].ToString();
        static string user = ConfigurationManager.AppSettings["user"].ToString();
        static string password = ConfigurationManager.AppSettings["password"].ToString();

        // Variable de conexion global
        public static SqlConnection conexion = getConnection();


        public static void Conectar()
        {
            try
            {
                conexion.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se pudo establecer la conexion a la base de datos." + e.Message);
            }
        }

        public static SqlDataReader ResolverConsulta(String query)
        {
            return new SqlCommand(query, conexion).ExecuteReader();
        }

        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "SERVER=" + server + "\\SQLSERVER2012;DATABASE=GD1C2018;UID=" + user + ";PASSWORD=" + password + ";" + "MultipleActiveResultSets=True";
            return con;
        }
    }
}