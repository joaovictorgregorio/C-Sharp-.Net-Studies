using System.Runtime.CompilerServices;

namespace HtmlEditor {
    public static class SaveFile {
        public static void SaveMenu() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Thread.Sleep(200);
            Console.WriteLine("Press [ESC] to exit");
            // Construindo as linhas
            Console.Write("+ ");
            for(var i = 0; i < 60; i++) {
                Thread.Sleep(5);
                Console.Write("-");
            }
            Console.Write(" +");
            
            Console.SetCursorPosition(26, 1);
            Thread.Sleep(5);
            Console.WriteLine(" Save New File ");
            Console.SetCursorPosition(18, 2);
            Thread.Sleep(10);
            Console.WriteLine("+ ------------------------- +");

            string text = " ";

            SavingFile(text);
        }
        
        public static void SavingFile(string text) {
            Console.Write("Enter the path to save the file: ");
            var directory = Console.ReadLine();

            using(var file = new StreamWriter(directory)) {
                file.Write(text);
            }

            Thread.Sleep(10);
            Console.WriteLine("+ ------------------------- +");
            Console.WriteLine($"O arquivo foi salvo {directory}!");
            Console.ReadLine();
            Menu.MainScreen();
        }
    }
}