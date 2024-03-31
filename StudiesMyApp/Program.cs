using System;
using System.Text;

namespace StudiesMyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

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

            /*  STARTSWITH / ENDSWITH
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
            */

            /* EQUALS
            var text = "Testando um texto comparação";
            var number = 23;

            Console.WriteLine(text.Equals("Testando um texto comparação"));
            Console.WriteLine(text.Equals("testando um texto comparação"));
            Console.WriteLine(text.Equals("testando um texto comparação", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(number.Equals(24));
            */

            /* ÍNDICES 

            var text = "Este é um texto de teste";

            Mostra à posição de onde se encontra a STRING.
            Console.WriteLine(text.IndexOf("é"));

            Mostra à posição onde apareceu está última STRING.
            Console.WriteLine(text.LastIndexOf("s"));
            */

            /* MÉTODOS ADICIONAIS
            
            var text = "Este texto é um teste";

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Insert(11, "aqui "));
            Console.WriteLine(text.Remove(0, 5));
            Console.WriteLine(text.Length);
            */

            /*  MANIPULANDO STRINGS
            var text = "Este texto é um teste";

            Console.WriteLine(text.Replace("e", "a", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("---------------------------");

            var division = text.Split(" ");
            Console.WriteLine(division[0]);
            Console.WriteLine(division[1]);
            Console.WriteLine(division[2]);
            Console.WriteLine(division[3]);
            Console.WriteLine(division[4]);

            Console.WriteLine("---------------------------");

            // var result = text.Substring( 5, 5);
            var result = text.Substring(5, text.LastIndexOf("o"));
            Console.WriteLine(result);
            
            Console.WriteLine("---------------------------");

            var textTrim = " Este é um texto espaçado ";
            Console.WriteLine(textTrim.Trim());
            */

            // STRINGBUILDER

            var text = new StringBuilder();
            text.Append("Este ");
            text.Append("texto ");
            text.Append("é ");
            text.Append("um ");
            text.Append("teste");

            Console.WriteLine(text.ToString());
        }
    }
}
