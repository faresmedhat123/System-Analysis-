using System;
using System.Data.SqlClient;

public class Database
{
    private string masterConnectionString =
        "Data Source=MOHAMED-ALI-200;Initial Catalog=master;Integrated Security=True;";

    private string gymConnectionString =
        "Data Source=MOHAMED-ALI-200;Initial Catalog=GymDb;Integrated Security=True;";

    public void InitializeDatabase()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(masterConnectionString))
            {
                conn.Open();

                string query = @"
                IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'GymDb')
                BEGIN
                    CREATE DATABASE GymDb
                END";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error creating database: " + ex.Message);
        }
    }

    public SqlConnection GetConnection()
    {
        return new SqlConnection(gymConnectionString);
    }
}