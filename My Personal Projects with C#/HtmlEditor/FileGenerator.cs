using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HtmlEditor {
    public static class FileGenerator {
        public static void FileGeneratorHomeScreen() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            Thread.Sleep(200);
            Console.WriteLine("Press [ESC] to exit");
            // Construindo as linhas
            Console.Write("+ ");
            for(var i = 0; i < 60; i++) {
                Thread.Sleep(5);
                Console.Write("-");
            }
            Console.Write(" +");
            
            Console.SetCursorPosition(21, 1);
            Thread.Sleep(5);
            Console.WriteLine(" Generating New File ");
            Console.SetCursorPosition(17, 2);
            Thread.Sleep(10);
            Console.WriteLine("+ ------------------------- +");
            Thread.Sleep(5);
            Console.SetCursorPosition(23, 3);
            Console.WriteLine(" Enter your text ");

            StartsFileGeneration();
        }

        public static void StartsFileGeneration() {
            Console.ForegroundColor = ConsoleColor.White;

            var text = new StringBuilder();

            Console.WriteLine("");
            Console.SetCursorPosition(0, 4);

            do {
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("");
            Console.Write("@Deseja salvar este arquivo: [y or n] ");
        
            char save = char.Parse(Console.ReadLine());

            if (save == 'y') {
                SaveFile.SaveMenu();
            } 
            if (save == 'n') {
                Menu.MainScreen();
            }
            else {
                InstructionsForUse.ChooseAnOption(0);
            }
        }
    }
}