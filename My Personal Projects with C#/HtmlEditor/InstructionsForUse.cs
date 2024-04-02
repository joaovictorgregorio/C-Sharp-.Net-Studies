namespace HtmlEditor {
    public static class InstructionsForUse {
        public static void MainScreenOptions() {
            // Adiciona a descrição na posição deseja, neste caso, coluna posição 11, na linha 1
            Console.SetCursorPosition(10, 1);
            Thread.Sleep(200);
            Console.WriteLine(" ||| HTML Editor ||| ");

            Console.SetCursorPosition(4, 3);
            Thread.Sleep(250);
            Console.WriteLine("1 - Generate new file ");

            Console.SetCursorPosition(4, 5);
            Thread.Sleep(250);
            Console.WriteLine("2 - Open file ");

            Console.SetCursorPosition(4, 7);
            Thread.Sleep(250);
            Console.WriteLine("3 - Delete file ");

            Console.SetCursorPosition(4, 9);
            Thread.Sleep(250);
            Console.Write("Digite a opção escolhida: ");
        }
        
        public static void ChooseAnOption(short option) {
            
        }
    }
}