using System.Net;
using BaltaDataAcess.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

internal class Program
{
    private static void Main(string[] args)
    {
        const string connectionString =
            "Server=localhost,1433;Database=balta-io;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";

        // Execução Dapper
        using (var connection = new SqlConnection(connectionString))
        {
            ListCategory(connection);
        }
    }

    static void ListCategory(SqlConnection connection)
    {
        var categories = connection.Query<Category>(
                "SELECT [Id], [Title] FROM [Category]");

        foreach (var item in categories)
        {
            Console.WriteLine($"{item.Id} - {item.Title}");
        }
    }

    static void InsertCategory(SqlConnection connection)
    {
        var category = new Category();
        category.Id = Guid.NewGuid();
        category.Title = "Amazon AWS";
        category.Url = "amazon";
        category.Summary = "AWS Cloud";
        category.Order = 8;
        category.Description = "Categoria destinada a serviços do AWS";
        category.Featured = false;


        var insertSql = @"INSERT INTO 
                    [Category]
                VALUES(
                    @Id, 
                    @Title, 
                    @Url, 
                    @Summary, 
                    @Order, 
                    @Description,
                    @Featured)";

        var rows = connection.Execute(insertSql, new
        {
            category.Id,
            category.Title,
            category.Url,
            category.Summary,
            category.Order,
            category.Description,
            category.Featured
        });
        if (rows == 1)
            Console.WriteLine($"{rows} linha afetada");
        else
            Console.WriteLine($"{rows} linhas afetadas");
    }

    static void UpdateCategory(SqlConnection connection)
    {
        var updateSql = @"UPDATE 
                            [Category] 
                        SET 
                            [Title]=@Title 
                        WHERE 
                            [Id]=@Id";

        var rows = connection.Execute(updateSql, new {
            
        });
    }
}