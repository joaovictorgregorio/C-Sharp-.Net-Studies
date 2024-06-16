using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_project.Models;
using blog_project.Repositories;

namespace blog_project.Screens.RoleScreens
{
    public class ListRolesScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de perfis");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void List()
        {
            var repository = new Repository<Role>(Database.Connection);
            var roles = repository.Get();

            foreach (var item in roles)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
        }
    }
}