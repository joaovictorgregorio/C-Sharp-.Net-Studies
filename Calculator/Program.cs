using System.ComponentModel.Design;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {

            Console.Clear();

            Console.WriteLine("Calculadora");
            Console.WriteLine("--------------------");

            Console.WriteLine("1 - Multiplicação");
            Console.WriteLine("2 - Divisão");
            Console.WriteLine("3 - Soma");
            Console.WriteLine("4 - Subtração");
            Console.WriteLine("5 - Potenciação");
            Console.WriteLine("6 - Sair");

            Console.WriteLine("--------------------");
            Console.Write("Informe sua escolha: ");

            short choiceOfCalculation = short.Parse(Console.ReadLine());

            switch (choiceOfCalculation)
            {
                case 1: Multiplicacao(); break;
                case 2: Divisao(); break;
                case 3: Soma(); break;
                case 4: Subtracao(); break;
                case 5: Potenciacao(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Multiplicacao()
        {
            // Limpa o console antes da execução.
            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            float numberTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float multiplication = numberOne * numberTwo;
            Console.WriteLine($"O resultado da multiplicação é: {multiplication}");
            // Segura a finalização do programa em execução. Apenas quando pressionar no teclado Enter ele finaliza.
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {

            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            float numberTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da divisão é: {numberOne / numberTwo}");
            Console.ReadKey();
            Menu();
        }
        static void Soma()
        {

            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            float numberTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("O resultado da soma é: " + (numberOne + numberTwo));
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {

            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            float numberTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é: {numberOne - numberTwo}");
            Console.ReadKey();
            Menu();
        }
        static void Potenciacao()
        {

            Console.Clear();

            Console.Write("Digite o valor: ");
            float baseNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite o expoente: ");
            float exponent = float.Parse(Console.ReadLine());

            uint potentiation = (uint)Math.Pow(baseNumber, exponent);

            Console.WriteLine("");
            Console.WriteLine($"O resultado da potenciação é: {potentiation}");
            Console.ReadKey();
            Menu();
        }
    }
}
