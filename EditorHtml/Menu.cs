using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Channels;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawingScreenLine()
        {
            Console.Write("+");

            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
                Thread.Sleep(5);
            }

            Console.Write("+ \n");
        }

        public static void DrawingScreenColumn()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");

                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("| \n");
            }
        }

        public static void DrawScreen()
        {
            DrawingScreenLine();

            DrawingScreenColumn();

            DrawingScreenLine();
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(10, 1);
            Thread.Sleep(200);
            Console.WriteLine("Editor HTML");

            Console.SetCursorPosition(4, 2);
            Console.WriteLine("=======================");
            Thread.Sleep(200);

            Console.SetCursorPosition(3, 3);
            Console.WriteLine("Selecione uma opção abaixo: ");
            Thread.Sleep(200);

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("1 - Novo arquivo");
            Thread.Sleep(300);

            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2 - Abrir");
            Thread.Sleep(300);

            Console.SetCursorPosition(2, 7);
            Console.WriteLine("0 - Sair");
            Thread.Sleep(300);

            Console.SetCursorPosition(2, 8);
            Console.Write("Opção: ");
            Thread.Sleep(300);
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}