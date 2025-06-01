using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace ADODotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string connectionString = "Data Source=DESKTOP-RJ7FDJE\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            string query = "Select * from student";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader sqldr = cmd.ExecuteReader();
            if (sqldr.HasRows)
            {
                while (sqldr.Read())
                {
                    Console.WriteLine(sqldr["Rollno"] + " " + sqldr["Name"] + " " + sqldr["city"]);

                }
            }
            conn.Close();

        }
    }
}