using System.Net;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

const string connectionString =
    "Server=localhost,1433;Database=balta-io;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";

using (var connection = new SqlConnection(connectionString))
{
    Console.WriteLine("Conectado ao banco de dados!");
    connection.Open();

    using (var command = new SqlCommand())
    {
        command.Connection = connection;
        command.CommandType = System.Data.CommandType.Text;
        command.CommandText = "SELECT [Id], [Title] FROM [Category]";

        var reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine(
                $"{reader.GetGuid(0)} - {reader.GetString(1)}");
        }
    }
}

Console.WriteLine("Hello, World!");
