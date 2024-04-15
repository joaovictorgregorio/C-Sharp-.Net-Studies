using System;
using System.ComponentModel;
using Microsoft.VisualBasic;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que você deseja fazer? ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }
        static void Open()
        {
            Console.Clear();

            Console.WriteLine("Qual caminho do arquivo? ");

            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void Edit()
        {
            Console.Clear();

            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("------------------------------");

            string text = "";

            // Explicação: Enquanto o usuário não apertar a tecla ESC representado por ConsoleKey.Escape, será registrado todos as teclas pressionadas no teclado.
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }
        static void Save(string text)
        {
            Console.Clear();

            Console.WriteLine(" Qual caminho para salvar o arquivo? ");

            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
}
