using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_project.Screens.RoleScreens
{
    public class MenuRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan; 
            Console.WriteLine("Gestão de perfils");
            Console.WriteLine("---------");
            Console.WriteLine("1 - Listar perfils");
            Console.WriteLine("2 - Cadastrar perfil");
            Console.WriteLine("3 - Atualizar perfil");
            Console.WriteLine("4 - Excluir perfil");
            Console.WriteLine("5 - Voltar ao menu principal \n \n");

            Console.Write("Escolha uma opção: ");
            var option = short.Parse(Console.ReadLine());
            Options(option);
        }

        public static void Options(short option)
        {
            switch (option)
            {
                case 1:
                    ListRolesScreen.Load();
                    break;
                case 2:
                    CreateRoleScreen.Load();
                    break;
                case 3:
                    UpdateRoleScreen.Load();
                    break;
                case 4:
                    DeleteRoleScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}