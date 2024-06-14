using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_project.Models;
using blog_project.Repositories;

namespace blog_project.Screens.UserScreens
{
    public class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Atualizar um usuário");
            Console.WriteLine("----------------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

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

            UpdateUser(new User
            {
                Id = int.Parse(id),
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

        public static void UpdateUser(User user)
        {
            try
            {
                var repository = new UserRepository(
                    Database.Connection
                );
                repository.Update(user);
                Console.WriteLine(
                    "Usuário atualizado com sucesso!");
            } catch (Exception ex)
            {
                Console.WriteLine(
                    "Não foi possível atualizar o usuário.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}