using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_project.Screens.CategoryScreens
{
    public class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gestão de Categoria");
            Console.WriteLine("---------------");
            Console.WriteLine("1 - Listar categorias");
            Console.WriteLine("2 - Criar categoria");
            Console.WriteLine("3 - Atualizar categoria");
            Console.WriteLine("4 - Excluir categoria");
            Console.WriteLine("5 - Voltar para o menu principal \n \n");

            Console.Write("Escolha uma opção: ");
            var option = short.Parse(Console.ReadLine());
            Options(option);
        }

        public static void Options(short option)
        {
            switch (option)
            {
                case 1:
                    ListCategorysScreen.Load();
                    break;
                case 2:
                    CreateCategoryScreen.Load();
                    break;
                case 3:
                    UpdateCategoryScreen.Load();
                    break;
                case 4:
                    DeleteCategoryScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}