using System.Data;
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
            // DeleteManyCategories(connection);
            // ExecuteProcedureDeleteStudent(connection);
            // ListStudent(connection);
            // ListCategory(connection);
            // ExecuteReadProcedureGetCoursesByCategory(connection);
            // ExecuteScalar(connection);
            // ReadView(connection);
            // OneToOne(connection);
            // OneToMany(connection);
            // QueryMultiple(connection);
            // SelectIn(connection);
            // Like(connection, "mobile");
            Transaction(connection);
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

    static void ListStudent(SqlConnection connection)
    {
        var selectStudentsSql =
            connection.Query<Student>(
                                    @"SELECT
                                        *    
                                    FROM
                                        [Student]");


        foreach (var item in selectStudentsSql)
        {
            Console.WriteLine(
                $"{item.Id} | {item.Name} | {item.Email} | {item.Phone}");
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

    static void ExecuteProcedureDeleteStudent(SqlConnection connection)
    {
        var procedureSql = "[spDeleteStudent]";
        var parameters =
            new
            {
                StudentId = "a88bbf39-dc20-411e-9fdb-29dfd4dd73c5"
            };

        var rows = connection.Execute(
            procedureSql, parameters, commandType: CommandType.StoredProcedure);

        Console.WriteLine($"{rows} linha deletada!");
    }

    static void ExecuteReadProcedureGetCoursesByCategory(SqlConnection connection)
    {
        var procedureSql = "[spGetCoursesByCategory]";
        var parameters = new { CategoryId = "af3407aa-11ae-4621-a2ef-2028b85507c4" };
        var courses = connection.Query(
            procedureSql,
            parameters,
            commandType: CommandType.StoredProcedure);

        foreach (var item in courses)
        {
            Console.WriteLine($"{item.Id}");
        }
    }

    static void ExecuteScalar(SqlConnection connection)
    {
        var category = new Category();
        category.Title = "Amazon AWS";
        category.Url = "amazon";
        category.Summary = "AWS Cloud";
        category.Order = 8;
        category.Description = "Categoria destinada a serviços do AWS";
        category.Featured = false;


        var insertSql = @"
                INSERT INTO 
                    [Category]
                OUTPUT inserted.[Id]
                VALUES(
                    NEWID(), 
                    @Title, 
                    @Url, 
                    @Summary, 
                    @Order, 
                    @Description,
                    @Featured
                )";

        var id = connection.ExecuteScalar<Guid>(insertSql, new
        {
            category.Title,
            category.Url,
            category.Summary,
            category.Order,
            category.Description,
            category.Featured
        });

        Console.Write($"A categoria adicionada foi: {id}");
    }

    static void ReadView(SqlConnection connection)
    {
        var viewSql = "SELECT * FROM [vwCourses]";
        var courses = connection.Query(viewSql);

        foreach (var item in courses)
        {
            Console.WriteLine($"{item.Id} - {item.Title}");
        }
    }

    static void OneToOne(SqlConnection connection)
    {
        var sql = @"
            SELECT
                *
            FROM
                [CareerItem]
            INNER JOIN
                [Course] ON [CareerItem].[CourseId] = [Course].[Id]";

        var items = connection.Query<CareerItem, Course, CareerItem>(
            sql,
            (careerItem, course) =>
            {
                careerItem.Course = course;
                return careerItem;
            }, splitOn: "Id");

        foreach (var item in items)
        {
            Console.WriteLine(item.Course.Title);
        }
    }

    static void OneToMany(SqlConnection connection)
    {
        var sql = @"
            SELECT
                [Career].[Id],
                [Career].[Title],
                [CareerItem].[CareerId],
                [CareerItem].[Title]
            FROM
                [Career]
            INNER JOIN
                [CareerItem] ON [CareerItem].[CareerId] = [Career].[Id]
            ORDER BY
                [Career].[Title]";

        var careers = new List<Career>();
        var items = connection.Query<Career, CareerItem, Career>(
            sql,
            (career, item) =>
            {
                var car = careers.Where(x => x.Id == career.Id).FirstOrDefault();
                if (car == null)
                {
                    car = career;
                    car.Items.Add(item);
                    careers.Add(car);
                }
                else
                {
                    car.Items.Add(item);
                }

                return career;
            }, splitOn: "CareerId");

        foreach (var career in careers)
        {
            Console.WriteLine($"{career.Title}");
            foreach (var item in career.Items)
            {
                Console.WriteLine($" - {item.Title}");
            }
        }
    }

    static void QueryMultiple(SqlConnection connection)
    {
        var query = @"
            SELECT 
                * 
            FROM 
                [Category];
            SELECT
                *
            FROM
                [Course]";

        using (var multi = connection.QueryMultiple(query))
        {
            var categories = multi.Read<Category>();
            var courses = multi.Read<Course>();

            foreach (var item in categories)
            {
                Console.WriteLine(item.Title);
            }

            foreach (var item in courses)
            {
                Console.WriteLine(item.Title);
            }
        }
    }

    static void SelectIn(SqlConnection connection)
    {
        var sqlSelectIn = @"
            SELECT 
                *
            FROM
                [Career]
            WHERE 
                [Id] 
            IN 
                @Id";

        var items = connection.Query<Career>(sqlSelectIn, new
        {
            Id = new[] {
                "01ae8a85-b4e8-4194-a0f1-1c6190af54cb",
                "4327ac7e-963b-4893-9f31-9a3b28a4e72b"
            }
        });

        foreach (var item in items)
        {
            Console.WriteLine(item.Title);
        }
    }

    static void Like(SqlConnection connection, string text)
    {
        var query = @"
            SELECT 
                *
            FROM
                [Course]
            WHERE 
                [Title] 
            LIKE
                @exp";

        var items = connection.Query<Course>(query, new
        {
            exp = $"%{text}%"
        });

        foreach (var item in items)
        {
            Console.WriteLine(item.Title);
        }
    }

    static void Transaction(SqlConnection connection)
    {
        var category = new Category();
        category.Id = Guid.NewGuid();
        category.Title = "Categoria que não quero";
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

        using (var transaction = connection.BeginTransaction())
        {
            var rows = connection.Execute(insertSql, new
            {
                category.Id,
                category.Title,
                category.Url,
                category.Summary,
                category.Order,
                category.Description,
                category.Featured
            },
            transaction);

            // transaction.Commit();
            transaction.Rollback();

            Console.WriteLine($"{rows} linha afetada");
        }
    }
}