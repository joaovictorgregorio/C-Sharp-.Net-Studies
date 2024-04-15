namespace HtmlEditor {
    public static class OpenFile {
        public static void OpenFileMenu() {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;

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
            Console.WriteLine(" Open File ");
            Console.SetCursorPosition(18, 2);
            Thread.Sleep(10);
            Console.WriteLine("+ ------------------------- +");

            OpeningFile();
        }

        public static void OpeningFile() {
            Console.Write("Enter the path to open the file: ");

            var directory = Console.ReadLine();

            using(var file = new StreamReader(directory)) {
                string text = file.ReadToEnd();
                Thread.Sleep(50);
                Console.WriteLine("+ ------------------------- +");
                Thread.Sleep(100);
                Console.WriteLine(text);
            }

            Console.ReadLine();
            Menu.MainScreen();
        }
    }
}