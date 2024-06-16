using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_project.Models;
using blog_project.Repositories;

namespace blog_project.Screens.RoleScreens
{
    public class CreateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Criar um perfil");
            Console.WriteLine("-------------");

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Role
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Create(Role role)
        {
            try
            {
                var repository = new Repository<Role>(
                    Database.Connection
                );
                repository.Create(role);
                Console.WriteLine("Perfil cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar o perfil!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}