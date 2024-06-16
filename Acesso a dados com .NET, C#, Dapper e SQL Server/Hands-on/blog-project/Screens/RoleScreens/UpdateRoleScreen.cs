using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_project.Models;
using blog_project.Repositories;

namespace blog_project.Screens.RoleScreens
{
    public class UpdateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar um perfil");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Perfil: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Role
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Update(Role role)
        {
            try
            {
                var repository = new Repository<Role>(
                    Database.Connection
                );
                repository.Update(role);
                Console.WriteLine("Perfil atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao atualizar o perfil! ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}