using System;
using System.Threading;
using System.Media;
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
            Console.WriteLine("Minutos = min. Exemplo 1min");
            Console.WriteLine("Horas igual = h. Exemplo 1h");
            Console.WriteLine("Tipo de contagem = Progressiva ou Regressiva");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("--------------------");
            
            Thread.Sleep(500);

            // Capturar os dados digitado pelo usuário. E transformar os caracteres em minúsculos.
            string userTime = Console.ReadLine().ToLower();
            // timeMeasurementUnit = Unidade de medida de tempo.
            char timeMeasurementUnit = char.Parse(userTime.Substring(userTime.Length - 1));
            int time = int.Parse(userTime.Substring(0, userTime.Length - 1));
            int multiplyingToMinutes = 1;

            if (userTime == "progressiva") {
                ProgressiveTimer(time);
            }

            if (timeMeasurementUnit == 'm')
            {
                time *= 60;
            }
            if (time == 0)
            {
                System.Environment.Exit(0);
            }

             PrepareToGetStarted(time);
        }
        static void PrepareToGetStarted(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Vai...");
            Thread.Sleep(1500);

            Count(time);
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
            Thread.Sleep(1000);
        }
    }
}