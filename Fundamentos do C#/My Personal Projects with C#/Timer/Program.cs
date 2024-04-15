using System;
using System.Threading;
using System.Data.Common;

namespace Timer
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
            Console.WriteLine("INSTRUÇÕES...");
            Console.WriteLine("--------------------");

            Thread.Sleep(500);

            Console.WriteLine("Segundos = s. Exemplo 10s");
            Console.WriteLine("Minutos = m. Exemplo 1m");
            Console.WriteLine("Horas igual = h. Exemplo 1h");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("--------------------");

            Console.Write("Quanto tempo deseja contar? ");
            // Capturar os dados digitado pelo usuário. E transformar os caracteres em minúsculos.
            string userTime = Console.ReadLine().ToLower();

            if (userTime == "0")
            {
                System.Environment.Exit(0);
            }

            Thread.Sleep(500);

            Console.Write("Tipo de contagem = progressiva ou regressiva? ");
            // Capturar o tipo de contagem que o usuário deseja.
            string countType = Console.ReadLine().ToLower();

            // timeMeasurementUnit = Unidade de medida de tempo.
            char timeMeasurementUnit = char.Parse(userTime.Substring(userTime.Length - 1));
            int time = int.Parse(userTime.Substring(0, userTime.Length - 1));
            int multiplyingToMinutes = 1;

            if (timeMeasurementUnit == 'm')
            {
                time *= 60;
            }
            
            PrepareToGetStarted(time, countType);
        }
        static void PrepareToGetStarted(int time, string counttype)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Vai...");
            Thread.Sleep(1500);

            if (counttype == "progressiva")
            {
                ProgressiveTimer(time);
            }
            if (counttype == "regressiva")
            {
                CountdownTimer(time);
            }
        }
        static void ProgressiveTimer(int time)
        {
            Console.Clear();

            int currentTime = 1;

            for (int i = 1; currentTime <= time; i++)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
                currentTime++;
            }

            Console.WriteLine("Contagem finalizada!");
            Thread.Sleep(1500);
            Menu();
        }
        static void CountdownTimer(int time)
        {
            Console.Clear();

            for (int i = time; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Contagem finalizada!");
            Thread.Sleep(1500);
            Menu();
        }
    }
}