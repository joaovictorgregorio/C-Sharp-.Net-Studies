using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace blog_project.Screens.TagScreens
{
    public class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Gestão de tags");
            Console.WriteLine("--------------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar tags");
            Console.WriteLine("2 - Cadastrar tags");
            Console.WriteLine("3 - Atualizar tags");
            Console.WriteLine("4 - Excluir tags");
            Console.WriteLine("5 - Voltar ao menu principal \n \n");

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListTagsScreen.Load();
                    break;
                case 2:
                    CreateTagScreen.Load();
                    break;
                case 3:
                    UpdateTagScreen.Load();
                    break;
                case 4:
                    DeleteTagScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}