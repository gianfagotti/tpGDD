﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Windows.Forms;


namespace FrbaHotel
{
    public class ConectorBaseDeDatos
    {
        private SqlConnection connection;

        public ConectorBaseDeDatos()
        {
            
        }

        public void conectar()
        {
            try
            {
                connection = new SqlConnection("Data Source=.\\SQLSERVER2012;Initial Catalog=GD1C2018;user=gdHotel2018;password=gd2018");
                connection.Open();

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo conectar");

            }
        }
    
     
        public void executeOnly(string query)
        {
            SqlCommand queryCommand = new SqlCommand();
            queryCommand.CommandTimeout = 999999999;

            queryCommand.Connection = this.connection;
            queryCommand.CommandText = query;
            queryCommand.ExecuteNonQuery();
            queryCommand.Dispose();
            queryCommand = null;
        }

        public DataTable consulta(string consulta)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandTimeout = 999999999;

            sqlCommand.Connection = this.connection;
            sqlCommand.CommandText = consulta;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, this.connection);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public SqlDataReader comando(string consulta)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandTimeout = 999999999;

            sqlCommand.Connection = this.connection;
            sqlCommand.CommandText = consulta;

            SqlDataReader ejecutar = sqlCommand.ExecuteReader();
            return ejecutar;
        }


        public SqlDataAdapter dameDataAdapter(string consulta)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandTimeout = 999999999;
            sqlCommand.Connection = this.connection;
            sqlCommand.CommandText = consulta;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, this.connection);
            return dataAdapter;
        }


        public DataTable dameDataTable(SqlDataAdapter dataAdapter)
        {
            DataTable dataTable = new DataTable();
            dataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(dataTable);
            return dataTable;
        }


        public string executeAndReturn(string query)
        {
            SqlCommand queryCommand = new SqlCommand();
            queryCommand.CommandTimeout = 999999999;
            queryCommand.Connection = this.connection;
            queryCommand.CommandText = query;
            string retorno = Convert.ToString(queryCommand.ExecuteScalar());
            queryCommand.Dispose();
            queryCommand = null;
            return retorno;
        }
    }
}