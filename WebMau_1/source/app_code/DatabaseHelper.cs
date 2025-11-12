using System;
using System.Data.SqlClient;
using System.Configuration;

public class DatabaseHelper
{
    public static void BuildDatabase(string dbName)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["dev"].ConnectionString;

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
        builder.InitialCatalog = "master";
        string masterConnectionString = builder.ConnectionString;

        using (SqlConnection conn = new SqlConnection(masterConnectionString))
        {
            conn.Open();

            string checkDbQuery = $"IF DB_ID(N'{dbName}') IS NULL CREATE DATABASE [{dbName}]";
            using (SqlCommand cmd = new SqlCommand(checkDbQuery, conn))
            {
                cmd.ExecuteNonQuery();
            }

            Console.WriteLine($"Database '{dbName}' đã được tạo (nếu chưa tồn tại).");
        }
    }
}
