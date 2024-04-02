using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HtmlEditor {
    public static class FileGenerator {
        public static void FileGeneratorHomeScreen() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            // Construindo as linhas
            Console.Write("+ ");
            for(var i = 0; i < 100; i++) {
                Console.Write("-");
            }
            Console.Write(" +");
            
            Console.SetCursorPosition(41, 1);
            Thread.Sleep(250);
            Console.WriteLine(" Generating New File ");
            Console.SetCursorPosition(37, 2);
            Thread.Sleep(20);
            Console.WriteLine("+ ------------------------- +");

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
        
            // Planejar salvamento do arquivo...
        }
    }
}