class Program
{
    static void RealizarPagamento(double valor)
    {
        Console.WriteLine($"Pago o valor de {valor}");
    }
    static void Main(string[] args)
    {
        Console.Clear();
        // Se passar a função sem os (), estaremos chamando ela e não executando a mesma.
        var pagar = new Pagamento.Pagar(RealizarPagamento);
        pagar(25);
    }
}

public class Pagamento
{
    // Usando o delegate, podemos redirecionar a onde será executado as funcionalidades da função Pagar.
    public delegate void Pagar(double valor);
}