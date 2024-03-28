using System;

namespace StudiesMyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* GUID

            var id = Guid.NewGuid();

            Transformando para uma STRING
            id.ToString();

            id = new Guid("ff845e9c-a170-47db-a783-f2d40578e6b8");

            Console.WriteLine(id.ToString().Substring(0, 8));
            */

            /* INTERPOLAÇÃO DE STRINGS

            var price = 10.2;

            var text = "O preço do produto é " + price + " apenas na promoção!";

            var text = string.Format("O preço do produto é {0} apenas na promoção!", price);

            var text = $"O preço do produto é {price} apenas na promoção!";

            Console.WriteLine(text);
            */

            /* COMPARAÇÃO DE STRINGS

            var text = "Testando";

            Console.WriteLine(text.CompareTo("Testando"));
            Console.WriteLine(text.CompareTo("testando"));
            Console.WriteLine(text.Contains("Testando"));
            Console.WriteLine(text.Contains("testando"));
            Console.WriteLine(text.Contains("testando", StringComparison.OrdinalIgnoreCase));
            */

            var text = "Este texto é um teste";

            Console.WriteLine(text.StartsWith("Este"));
            Console.WriteLine(text.StartsWith("este"));
            Console.WriteLine(text.StartsWith("livro"));
            Console.WriteLine("--------------------------------");
            Console.WriteLine(text.EndsWith("teste"));
            Console.WriteLine(text.EndsWith("Teste"));
            Console.WriteLine(text.EndsWith("comedia"));
            Console.WriteLine("--------------------------------");
            Console.WriteLine(text.StartsWith("este", StringComparison.OrdinalIgnoreCase));
        }
    }
}
