using System.Data;
using blog_project.Models;
using blog_project.Repositories;
using blog_project.Screens.TagScreens;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

internal class Program
{
    private const string CONNECTION_STRING = @"
    Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";

    private static void Main(string[] args)
    {
        var connection = new SqlConnection(CONNECTION_STRING);
        connection.Open();


        connection.Close();
        Console.ReadKey();
    }
}
/*
    public static void ReadUsers(SqlConnection connection)
    {
        var repository = new Repository<User>(connection);
        var items = repository.Get();

        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
            foreach (var role in item.Roles)
            {
                Console.WriteLine($" - {role.Name}");
            }
        }

    }
    public static void ReadUsersWithRoles(SqlConnection connection)
    {
        var repository = new UserRepository(connection);
        var items = repository.GetWithRoles();

        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
            foreach (var role in item.Roles)
            {
                Console.WriteLine($" - {role.Name}");
            }
        }
    }
    public static void ReadRoles(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
    }
    public static void ReadTags(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
    }
    public static void CreateUser(SqlConnection connection)
    {
        var user = new User()
        {
            Name = "Joao Victor",
            Email = "joaosilva@gmail.com",
            PasswordHash = "Hash",
            Bio = "O melhor desenvolvedor de catanduva",
            Image = "https://",
            Slug = "joaovictor-gregorio"
        };

        var repository = new Repository<User>(connection);
        repository.Create(user);
    }
}*/