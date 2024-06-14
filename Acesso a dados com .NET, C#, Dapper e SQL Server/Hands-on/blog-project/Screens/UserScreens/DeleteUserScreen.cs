using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_project.Repositories;

namespace blog_project.Screens.UserScreens
{
    public class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar um usuário");
            Console.WriteLine("------------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new UserRepository(
                    Database.Connection
                );
                repository.Delete(id);
                Console.WriteLine(
                    "\nUsuário deletado com sucesso!"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Erro ao deletar o usuário: {ex.Message}"
                );
            }
        }
    }
}