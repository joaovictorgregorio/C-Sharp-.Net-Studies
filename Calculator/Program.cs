namespace Calculator {
    class Program {
        static void Main(string[] args) {
            Multiplicacao();
        }

        static void Multiplicacao() {
            // Limpa o console antes da execução.
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            float numberOne = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float numberTwo = float.Parse(Console.ReadLine());

            float multiplication = numberOne * numberTwo;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da multiplicação é: {multiplication}");
            // Segura a finalização do programa em execução. Apenas quando pressionar no teclado Enter ele finaliza.
            Console.ReadKey();
        }
    }
}
