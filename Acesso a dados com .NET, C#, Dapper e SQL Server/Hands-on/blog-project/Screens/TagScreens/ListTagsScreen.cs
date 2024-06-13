using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_project.Models;
using blog_project.Repositories;

namespace blog_project.Screens.TagScreens
{
    public class ListTagsScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Lista de tags");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void List()
        {
            var repository = new Repository<Tag>(
                Database.Connection
            );
            var tags = repository.Get();

            foreach (var item in tags)
                Console.WriteLine(
                    $"{item.Id} - {item.Name} ({item.Slug})");
        }
    }
}