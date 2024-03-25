using System;
using System.Threading;
using System.Media;

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
            Thread.Sleep(1000);
            Console.WriteLine("Segundos = s. Exemplo 10s");
            Console.WriteLine("Minutos = m. Exemplo 1m");
            Console.WriteLine("Horas igual = h. Exemplo 1h");
            Console.WriteLine("--------------------");
            Console.Write("Quanto tempo você deseja contar? ");
            Thread.Sleep(1000);

            // Capturar os dados digitado pelo usuário. E transformar os caracteres em minúsculos.
            string time = Console.ReadLine().ToLower();
            
            Console.WriteLine(time);
        }
        static void Count(int time)
        {
            Console.Clear();

            int currentTime = 1;

            for (int i = 1; currentTime <= time; i++)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(300);
                currentTime++;
            }
        }
    }
}