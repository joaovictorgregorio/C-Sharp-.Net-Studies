using System.ComponentModel;

namespace HtmlEditor {
    public static class InstructionsForUse {
        public static void MainScreenOptions() {
            Console.ForegroundColor = ConsoleColor.White;

            // Adiciona a descrição na posição deseja, neste caso, coluna posição 11, na linha 1
            Console.SetCursorPosition(8, 1);
            Thread.Sleep(150);
            Console.WriteLine(" * * * HTML Editor * * * ");

            Console.SetCursorPosition(4, 3);
            Thread.Sleep(100);
            Console.WriteLine("1 - Generate new file ");

            Console.SetCursorPosition(4, 5);
            Thread.Sleep(100);
            Console.WriteLine("2 - Open file ");

            Console.SetCursorPosition(4, 7);
            Thread.Sleep(100);
            Console.WriteLine("3 - Delete file ");

            Console.SetCursorPosition(4, 9);
            Thread.Sleep(100);
            Console.WriteLine("0 - Go out");

            Console.SetCursorPosition(4, 11);
            Thread.Sleep(100);
            Console.Write("Enter your chosen option: ");

            var option = short.Parse(Console.ReadLine());
            ChooseAnOption(option);
        }
        
        public static void ChooseAnOption(short option) {
            switch(option) {
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                case 1: FileGenerator.FileGeneratorHomeScreen(); break;
                case 2: OpenFile.OpenFileMenu(); break;
                case 3: Console.WriteLine("Delete file"); break;
                default: Menu.MainScreen(); break;
            }
        }
    }
}