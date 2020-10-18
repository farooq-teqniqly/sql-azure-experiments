using System;
using System.Data.SqlClient;

namespace SqlAzureWindowsAuth
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=fm-d-usw2-sql-demo.database.windows.net;Authentication=Active Directory Integrated; Initial Catalog=demo;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            Console.WriteLine("Connected!");
        }
    }
}


