using System.Collections;
using System.Data.Common;
using System.Linq;
using System.Security.AccessControl;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // IEnumerable é o tipo de lista mais usado. IList permite add, remove e várias outras funções para manipular a lista de forma mais complexa.
            var pagamentos = new List<Pagamento>();
            pagamentos.Add(new Pagamento(1));
            pagamentos.Add(new Pagamento(2));
            pagamentos.Add(new Pagamento(3));
            pagamentos.Add(new Pagamento(4));
            pagamentos.Add(new Pagamento(5));

            foreach (var pagamento in pagamentos)
            {
                Console.Write(pagamento.Id + " ");
            }

            Console.WriteLine("\n------------------------------------");

            // Gerando uma nova lista.
            var pagamentoPagos = new List<Pagamento>();
            // AddRange, adiciona uma lista dentro de outra lista.
            pagamentoPagos.AddRange(pagamentos);

            foreach (var pagamento in pagamentos)
            {
                Console.Write(pagamento.Id + " ");
            }

            Console.WriteLine("\n------------------------------------");

            // Where executa uma função de busca dentro de uma lista, neste caso, x => x.Id == 3. Ele vai buscar dentro da lista pagamentos, o pagamento que tem o ID igual ao valor 3. Where retorna sempre uma lista, independente da quantidade de caracteres que forem iguais há informação passada para ele. 
            var wherePagamento = pagamentos.Where(x => x.Id == 3);

            // First usado para retornar apenas uma informação.
            var firstPagamento = pagamentos.First(x => x.Id == 5);
            Console.WriteLine(firstPagamento.Id);

            Console.WriteLine("------------------------------------");

            pagamentos.Remove(new Pagamento(3));
            foreach (var pagamento in pagamentos)
            {
                Console.Write(pagamento.Id + " ");
            }

            Console.WriteLine("\n------------------------------------");

            // Remove todos os elementos da lista
            // pagamentos.Clear();

            // Pesquisa na nossa lista se a informação passada dentro da função existe, dentro do contexto desta lista. 
            var existe = pagamentos.Any(x => x.Id == 3);
            Console.WriteLine(existe);

            Console.WriteLine("------------------------------------");

            // Mostra a quantidade de itens que tem conforme os parâmetros passando dentro da função, neste caso, retorna 1 item.
            var contagem = pagamentos.Count(x => x.Id == 2);
            Console.WriteLine(contagem);

            Console.WriteLine("------------------------------------");

            // Neste caso, o Skip vai pular a contagem do primeiro pagamento retornando 2, 3, 4, 5.
            foreach (var pagamento in pagamentos.Skip(1))
            {
                Console.Write(pagamento.Id + " ");
            }

            Console.WriteLine("\n------------------------------------");

            // Vai pegar apenas 2 itens da lista. Também podemos usar tudo junto. Exemplo pagamento.Skip(2).Take(3), pulando dois itens e pegando apenas três itens da lista.
            foreach (var pagamento in pagamentos.Take(2))
            {
                Console.Write(pagamento.Id + " ");
            }

            // Convertendo a lista para Enumerable. E também da para fazer ao contrário que seria IEnumerable<Pagamento> pagamentos = new List<Pagamento>(); Transformando para pagamentos.ToList(); 
            pagamentos.AsEnumerable();
            // Converte para Array, o tipo mais básico das listas.
            pagamentos.ToArray();
        }
        public class Pagamento
        {
            public int Id { get; set; }
            // Construtor.
            public Pagamento(int id)
            {
                Id = id;
            }
        }
    }
}