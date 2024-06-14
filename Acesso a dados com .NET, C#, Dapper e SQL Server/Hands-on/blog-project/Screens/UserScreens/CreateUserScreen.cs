using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_project.Models;
using blog_project.Repositories;

namespace blog_project.Screens.UserScreens
{
    public class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Criação de usuário");
            Console.WriteLine("-----------------------");

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("Senha: ");
            var passwordHash = Console.ReadLine();

            Console.Write("Bio: ");
            var bio = Console.ReadLine();

            Console.Write("Imagem: ");
            var image = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            CreateUser(new User
            {
                Name = name,
                Email = email,
                PasswordHash = passwordHash,
                Bio = bio,
                Image = image,
                Slug = slug
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void CreateUser(User user)
        {
            try
            {
                var repository = new UserRepository(
                    Database.Connection
                );
                repository.Create(user);
                Console.WriteLine(
                    $"Usuário {user.Name} cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "Erro ao cadastrar usuário!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}