using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_project.Models;
using blog_project.Repositories;

namespace blog_project.Screens.TagScreens
{
    public class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(
                "Digite o id para deletar uma tag: ");
            Console.WriteLine("-----------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(
                    Database.Connection
                );
                repository.Delete(id);
                Console.WriteLine("Tag deletada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "Ocorreu um erro ao deletar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}