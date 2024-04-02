using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HtmlEditor {
    public static class FileGenerator {
        public static void FileGeneratorHomeScreen() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.SetCursorPosition(10, 1);
            Thread.Sleep(250);
            Console.WriteLine(" Generating New File ");

            Console.SetCursorPosition(0, 2);
            for(var i = 0; i < 14; i++) {
                Thread.Sleep(10);
                Console.Write(" = ");
            }

            StartsFileGeneration();
        }

        public static void StartsFileGeneration() {
            Console.ForegroundColor = ConsoleColor.White;

            var file = new StringBuilder();

            Console.WriteLine("");
            Console.SetCursorPosition(0, 3);

            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("");
            Console.Write("@Deseja salvar este arquivo: [yes or no] ");
        
            
        }
    }
}