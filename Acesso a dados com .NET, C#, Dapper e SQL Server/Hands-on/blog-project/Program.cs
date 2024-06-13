using System.Data;
using blog_project;
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
        Database.Connection = new SqlConnection(
            CONNECTION_STRING
        );
        Database.Connection.Open();

        Load();

        Console.ReadKey();
        Database.Connection.Close();
    }

    private static void Load()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Meu Blog");
        Console.WriteLine("--------------------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine();
        Console.WriteLine("1 - Gestão de usuário");
        Console.WriteLine("2 - Gestão de perfil");
        Console.WriteLine("3 - Gestão de categoria");
        Console.WriteLine("4 - Gestão de tag");
        Console.WriteLine("5 - Vincular perfil/usuário");
        Console.WriteLine("6 - Vincular post/tag");
        Console.WriteLine("7 - Relatórios");
        Console.WriteLine();
        Console.WriteLine();

        var option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                // UserScreen.Load();
                break;
            case 2:
                // ProfileScreen.Load();
                break;
            case 3:
                // CategoryScreen.Load();
                break;
            case 4:
                MenuTagScreen.Load();
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            default: Load(); break;
        }
    }
}
/*
    public static void ReadUsers(SqlConnection Database.Connection)
    {
        var repository = new Repository<User>(Database.Connection);
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
    public static void ReadUsersWithRoles(SqlConnection Database.Connection)
    {
        var repository = new UserRepository(Database.Connection);
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
    public static void ReadRoles(SqlConnection Database.Connection)
    {
        var repository = new Repository<Role>(Database.Connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
    }
    public static void ReadTags(SqlConnection Database.Connection)
    {
        var repository = new Repository<Tag>(Database.Connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
    }
    public static void CreateUser(SqlConnection Database.Connection)
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

        var repository = new Repository<User>(Database.Connection);
        repository.Create(user);
    }
}*/