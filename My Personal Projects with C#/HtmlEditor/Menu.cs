using System.Reflection.PortableExecutable;

namespace HtmlEditor {
    public static class Menu {
        public static void MainScreen() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            ScreenConstruction();
            InstructionsForUse.MainScreenOptions();
        }
        public static void ScreenConstruction(){
            ScreenLines();
            ScreenColumns();
            Console.WriteLine("");
            ScreenLines();
        }

        public static void ScreenLines() {
            Console.Write("***");

            for(var i = 0; i < 35; i++) {
                Console.Write("=");
                Thread.Sleep(5);
            }

            Console.Write("***");
        }

        public static void ScreenColumns() {
            for(var lines = 14; lines > 1; lines--) {
                Console.Write("\n *");

                for(var columns = 0; columns < 36; columns++) {
                    Console.Write(" ");
                }
            
                Console.Write(" *");  
            }
        }
    }
}