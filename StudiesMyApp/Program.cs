using System;

namespace StudiesMyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            // Transformando para uma STRING
            id.ToString();

            id = new Guid("ff845e9c-a170-47db-a783-f2d40578e6b8");

           

            Console.WriteLine(id.ToString().Substring(0, 8));
        }
    }
}
