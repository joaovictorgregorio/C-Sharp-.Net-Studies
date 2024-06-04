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
            // CreateManyCategories(connection);
            DeleteManyCategories(connection);
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

    static void GetCategory(SqlConnection connection)
    {

    }

    static void CreateCategory(SqlConnection connection)
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

        Console.WriteLine($"{rows} linha afetada");

    }

    static void UpdateCategory(SqlConnection connection)
    {
        var updateQuery = @"UPDATE 
                            [Category] 
                        SET 
                            [Title]=@Title 
                        WHERE 
                            [Id]=@Id";

        var rows = connection.Execute(updateQuery, new
        {
            id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"),
            title = "Frontend 2024",
        });

        Console.WriteLine($"{rows} registro atualizado!");
    }

    static void DeleteCategory(SqlConnection connection)
    {

    }

    static void CreateManyCategories(SqlConnection connection)
    {
        var categoryOne = new Category();
        categoryOne.Id = Guid.NewGuid();
        categoryOne.Title = "New category number one";
        categoryOne.Url = "new category one";
        categoryOne.Summary = "new category one";
        categoryOne.Order = 9;
        categoryOne.Description = "new category one";
        categoryOne.Featured = true;

        var categoryTwo = new Category();
        categoryTwo.Id = Guid.NewGuid();
        categoryTwo.Title = "New category number two";
        categoryTwo.Url = "new category two";
        categoryTwo.Summary = "new category two";
        categoryTwo.Order = 10;
        categoryTwo.Description = "new category two";
        categoryTwo.Featured = true;

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

        var rows = connection.Execute(insertSql, new[]{
            new {
                categoryOne.Id,
                categoryOne.Title,
                categoryOne.Url,
                categoryOne.Summary,
                categoryOne.Order,
                categoryOne.Description,
                categoryOne.Featured

            },
            new {
                categoryTwo.Id,
                categoryTwo.Title,
                categoryTwo.Url,
                categoryTwo.Summary,
                categoryTwo.Order,
                categoryTwo.Description,
                categoryTwo.Featured
            }
        });

        Console.WriteLine($"{rows} linhas adicionadas");
    }

    static void DeleteManyCategories(SqlConnection connection)
    {
        var deleteSql = @"DELETE FROM
                            [Category]
                        WHERE 
                            [id]=@Id";

        var rows = connection.Execute(deleteSql, new[] {
            new {
                Id = new Guid("53428d7d-d092-4a98-bfdc-d940fd07d18d"),
            },
            new {
                Id = new Guid("73c031a7-57b0-4fb7-bf61-4558cbe3656a"),
            }
        });

        Console.WriteLine($"{rows} linhas deletadas");
    }
}