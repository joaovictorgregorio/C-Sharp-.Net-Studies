using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_project.Screens.CategoryScreens
{
    public class MenuCategoryScreen
    {
        public static void Load()
            => DisplayMenu();

        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Categoria");
            Console.WriteLine("---------------");
            Console.WriteLine("1 - Listar categorias");
            Console.WriteLine("2 - Criar categoria");
            Console.WriteLine("3 - Atualizar categoria");
            Console.WriteLine("4 - Excluir categoria");
            Console.WriteLine(
                "5 - Voltar para o menu principal \n \n");
            Console.Write("Escolha uma opção: ");
        }
    }
}