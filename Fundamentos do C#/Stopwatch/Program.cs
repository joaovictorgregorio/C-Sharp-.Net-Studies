using System.Threading;

namespace Stopwatch
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
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar? ");

            // ToLower() vai transformar todos os caracteres que o usuário digitar em letras minúsculas.
            string data = Console.ReadLine().ToLower();
            // Neste caso, está Substring(1,1) pegaria o caracter na posição 1 e pegaria apenas 1 caracter. Outro exemplo para fixar é Substring(2,2) pegaria o caracter da posição 2 como referência e pegaria 2 caracteres, ou seja, posição 2 e 3
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            // Length usado para verificar o total de caracteres que o usuário digitou, neste caso ele vai pegar na posição 0 até o último e o -1 foi usado para excluir o caracter digitado por último e manter apenas os números digitados pelo usuário.
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }
            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            // Já passando o cálculo de forma implícita 
            PreStart(time * multiplier);

        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }
        static void Start(int time)
        {
            // int time = 10;
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                // É um método estático da classe Thread do namespace System.Threading. Ele é usado para pausar a execução do thread atual. O thread atual será suspenso por 1 segundo antes de continuar sua execução.
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2000);
            Menu();
        }
    }
}
