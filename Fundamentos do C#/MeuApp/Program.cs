using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace MeuApp
{

    class MainClass
    {

        public static string LongestWord(string sen)
        {

            string comprimentoPalavra = GetMa;
            string palavraAtual = "";

            foreach (char caractere in sen)
            {
                if (char.IsLetterOrDigit())
                palavraAtual += caractere;
            }

            else if(!string.IsNullOrEmpty(palavraAtual)) {

            }
        }

        static void Main()
        {

            var frase = "Eu amo cachorros";
            Console.WriteLine(LongestWord(frase));

        }

    }
}
//     class Program
//     {
//         /* Usando criação de métodos no programa
//         static void Main(string[] args)
//         {
//             MeuMetodo();

//             string nome = RetornaNome("João", "Victor");
//             Console.WriteLine(nome);
//         }

//         static void MeuMetodo()
//         {
//             Console.WriteLine("C# meu ovo!");
//         }

//         static string RetornaNome(string nome, string sobrenome, int idade = 24) {

//             return nome + " " + sobrenome + " tem " + idade + " anos!";
//         }
//         */
//         /*
//         static void Main(string[] args)
//         {
//             var arr = new string[2];
//             arr[0] = "Item 1";

//             var arr2 = arr;

//             Console.WriteLine(arr[0]);
//             Console.WriteLine(arr[0]);

//             arr[0] = "Item 2";
//             Console.WriteLine(arr[0]);
//             Console.WriteLine(arr[0]);
//         }
//         */

//         static void Main(string[] args) {

//         var mouse = new Product(99, "Teclado", 199.99, EProductType.Product);
//         var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);

//         Console.WriteLine(mouse.Id);
//         Console.WriteLine(mouse.Name);
//         Console.WriteLine(mouse.Price);
//         Console.WriteLine((int)mouse.Type);
//         }
//     }

//     struct Product
//     {
//         public Product(int id, string name, double price, EProductType type)
//         {
//             Id = id;
//             Name = name;
//             Price = price;
//             Type = type;
//         }
//         public int Id;
//         public string Name;
//         public double Price;
//         public EProductType Type;
//         public double PriceInDolar(double dolar)
//         {
//             return Price * dolar;
//         }
//     }

//     enum EProductType {
//         Product = 1,
//         Service = 2,
//     }
// }