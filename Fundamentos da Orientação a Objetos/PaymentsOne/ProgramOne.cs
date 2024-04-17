using System.Security.Cryptography;

/* Aqui foi abordado a partir de (Paradigma orientado a objetos) até (Modificadores de acesso)  */

Console.Clear();

// Instânciamento da classe PagamentoBoleto. Instância é o ato de transformar a classe em um objeto. 
var pagamentoBoleto = new PagamentoBoleto();
pagamentoBoleto.Pagar();
pagamentoBoleto.Vencimento = DateTime.Now;
pagamentoBoleto.NumeroBoleto = "1234";

var pagamento = new Pagamento();
pagamento.DataPagamento = DateTime.Now;

var pagamentoCartaoCredito = new PagamentoCartaoCredito();
pagamentoCartaoCredito.Vencimento = DateTime.Now;

// Os modificadores no C# são: private, protected, internal e public. Se deixar sem nada à frente da classe, será mesma coisa que deixar private. Protected o acesso é permitido apenas para os filhos que herdam do pai. Internal fica disponível dentro do mesmo namespace, muito pouco usado, casos bem específicos. E public fica disponível para uso onde for necessário.
class Pagamento {

    // Propriedades
    public DateTime Vencimento { get; set; }
    private DateTime _dataPagamento;
    public DateTime DataPagamento {
        get { 
            Console.WriteLine("Lendo o valor");
            return _dataPagamento.AddDays(1); 
        }
        set {
            Console.WriteLine("Atribuir um valor"); 
            _dataPagamento = value; 
        }
    }
    
    public int MyProperty { get; private set; }

    // Métodos. Virtual é um modificador que permite, que o método seja sobreescrito. Conceito do polimorfismo.
    public virtual void Pagar() {
        
    }

    public override string ToString() {
        return Vencimento.ToString("dd/MM/yyyy");
    }

    // Irá privar o acesso feito por outras classes, conceito de abstração. Neste caso, funciona apenas na classe Pagamento.
    private void ConsultarSaldoDoCartao(string numerocartao) {
        
    }
}

// Aplicado conceito de herança. Neste caso, PagamentoBoleto herda de Pagamento.
class PagamentoBoleto : Pagamento {
    public string NumeroBoleto;
    // Quando é usado Virtual na classe Pagamento que é o pai, e Override na classe PagamentoBoleto que é o filho. O método Pagar() está sendo sobreescrito, dando uma nova função para este mesmo método. Conceito do polimorfismo.
    public override void Pagar() {
        // Regra do boleto
    }

    void Teste() {
        // Para verificar as propriedades e métodos disponíveis do pai, neste caso Pagamento, usar a palavra BASE.
    }
}

// Não é possível herança múltipla no C#, apenas Pai e filho, sendo heranças únicas. Sem limite de uso, processo pode ser repetido quantas vezes for necessário.
class PagamentoCartaoCredito : Pagamento {
    public string Numero;

    public override void Pagar()
    {
        // Regra cartão de crédito
    }
}
