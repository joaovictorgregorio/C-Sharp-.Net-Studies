using System.Runtime.InteropServices;
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
            Console.WriteLine("Instruções...");
            Console.WriteLine("---------------");
            Console.WriteLine("S - Segundo => 10s - 10 segundos");
            Console.WriteLine("M - Segundo => 1m - 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.Write("Quanto tempo deseja cronometrar? ");

            string data = Console.ReadLine().ToLower();
            Console.WriteLine(data);
        }
        static void Start(int time)
        {
            Console.Clear();

            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                /*
                Thread.Sleep: É um método estático da classe Thread do namespace System.Threading. Ele é usado para pausar a execução do thread atual. 1000: Este é o argumento que especifica o tempo de suspensão em milissegundos. Neste caso, 1000 significa 1000 milissegundos, ou seja, 1 segundo. Portanto, quando você chama Thread.Sleep(1000), o thread atual será suspenso por 1 segundo antes de continuar sua execução. 
                */
                Thread.Sleep(500);
            }
        }
    }
}
