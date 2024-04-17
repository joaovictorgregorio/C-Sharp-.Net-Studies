/* Aqui será abordado a partir de (Tipos complexos) até ... */

Console.Clear();

// Execução principal do código.
var pagamento = new Pagamento();
pagamento.NumeroBoleto = "01548411512";
Console.WriteLine(pagamento.NumeroBoleto);

pagamento.DataPagamento = DateTime.Now;
Console.WriteLine(pagamento.DataPagamento);


public class Pagamento {
    public string NumeroBoleto;
    // Get e Set são acessores que podem atribuir ou receber valores, a diferença entre propriedades e variáveis é exatamente está característica do Get e Set.
    public DateTime Vencimento { get; set; }
    // Dependendo do escopo do projeto, é bem possível que encontre _underline na frente de propriedades privadas é bem comum.
    private DateTime _dataPagamento;
    // privete DateTime _dataPagamento e public DateTime DataPagamento estão interligados, foi usado o comando (propfull) para criar instantaneamente as duas propriedades.
    public DateTime DataPagamento {
        // Os acessores Get e Set permite interagir com os valores, antes de atribuí-los. É muito importante para validação dos dados, um exemplo setar o CPF, usuário manda com pontos, nós pegamos está informação, executamos uma exclusão dos pontos e deixamos apenas os números para o sistema.
        get {
            Console.WriteLine("Lendo o valor");
            Console.ForegroundColor = ConsoleColor.Cyan; 
            // O Get precisa retornar sempre o mesmo tipo de dado, neste caso, é o DateTime. Podemos informar retornar dados adicionais como por exemplo: return _dataPagamento.AddYears(1), retorna a data com mais 1 ano à frente.
            return _dataPagamento.AddYears(1);
        }
        set { 
            Console.WriteLine("Atribuindo o valor");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            _dataPagamento = value; 
        }
    }
    
    Address BillingAddress;
    void Pagar() { }
}

public class Address {
    string ZipCode;
}
