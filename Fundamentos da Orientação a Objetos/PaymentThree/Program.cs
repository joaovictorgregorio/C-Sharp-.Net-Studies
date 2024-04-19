/* Aqui será abordado a partir de (Using e Dispose) até (Classes seladas) */

Console.Clear();

// Execução principal do código...

// O using garante que não haja erro humano aqui, pois ele evita que o programador esqueça de chamar o método Dispose, utilizando o using será passado por todas as etapas automaticamente, evitando erro.
using (var pagamento = new Pagamento())
{
    Console.WriteLine("Processando o pagamento");
}

PagamentoCartao.PagamentoDoCartao();

public class Pagamento : IDisposable
{
    // Garbage Collector = coletor de lixo. Facilita o alocação e exclusão dos objetos da memória, atua de forma independente. Microsoft recomenda em deixar ele trabalhando, sem modificações feitas por nós. OBS:  Comando para chamada GC.Collector.
    public Pagamento()
    {
        Console.WriteLine("Iniciando o pagamento");
    }
    // Método que será chamado, quando precisarmos destruir o objeto.
    public void Dispose()
    {
        Console.WriteLine("Finalizando o pagamento");
    }

}

// Quando uma classe está static = estática, ela não pode ser instânciada. var pagamento = new PagamentoCartao().
public static class PagamentoCartao
{
    // Se a classe for static, todos os elementos criados dentro desta classe precisam ser static também.
    public static void PagamentoDoCartao()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("---------------");
        Console.WriteLine("Pagamento cartão");
    }
}


public static class Settings
{
    public static string API_URL { get; set; }
}

// Sealed irá bloquear que outras classes possam derivar/herdar delas, funciona como um bloqueio de herança.
public sealed class PagamentoBoleto {

}
