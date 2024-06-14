using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_project.Screens.UserScreens
{
    public class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Gestão de usuários");
            Console.WriteLine("-------------------------");
            Console.WriteLine("O que deseja fazer? \n");
            Console.WriteLine("1 - Listar usuários");
            Console.WriteLine("2 - Criar usuário");
            Console.WriteLine("3 - Atualizar usuário");
            Console.WriteLine("4 - Excluir usuário");
            Console.WriteLine(
                "5 - Voltar para o menu principal \n \n");

            Console.Write("Escolha uma opção: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUsersScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    UpdateUserScreen.Load();
                    break;
                case 4:
                    DeleteUserScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}