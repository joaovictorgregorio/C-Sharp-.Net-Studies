using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_project.Models;
using blog_project.Repositories;

namespace blog_project.Screens.UserScreens
{
    public class ListUsersScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Lista de usuários");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void List()
        {
            var repository = new UserRepository(
                Database.Connection
            );

            var users = repository.Get();

            foreach (var item in users)
                Console.WriteLine(
                    $"{item.Id} - {item.Name} ({item.Email})");
        }
    }
}