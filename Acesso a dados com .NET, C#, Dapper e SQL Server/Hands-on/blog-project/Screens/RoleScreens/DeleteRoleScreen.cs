using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_project.Models;
using blog_project.Repositories;

namespace blog_project.Screens.RoleScreens
{
    public class DeleteRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar um perfil");
            Console.WriteLine("---------------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Perfil deletado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao deletar o perfil!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}