using System.Security.Cryptography;
using static System.Console;

Clear();

// Instânciamento da classe PagamentoBoleto. Instância é o ato de transformar a classe em um objeto. 
var pagamentoBoleto = new PagamentoBoleto();
pagamentoBoleto.Pagar();
pagamentoBoleto.Vencimento = DateTime.Now;
pagamentoBoleto.NumeroBoleto = "1234";

var pagamento = new Pagamento();

var pagamentoCartaoCredito = new PagamentoCartaoCredito();
pagamentoCartaoCredito.Vencimento = DateTime.Now;

class Pagamento {

    // Propriedades
    public DateTime Vencimento;

    // Métodos
    public void Pagar() {
        ConsultarSaldoDoCartao("123456789");
    }

    // Irá privar o acesso feito por outras classes, conceito de abstração. Neste caso, funciona apenas na classe Pagamento.
    private void ConsultarSaldoDoCartao(string numerocartao) {
        
    }
}

// Aplicado conceito de herança. Neste caso, PagamentoBoleto herda de Pagamento.
class PagamentoBoleto : Pagamento {
    public string NumeroBoleto;
}

// Não é possível herança múltipla no C#, apenas Pai e filho, sendo heranças únicas. Sem limite de uso, processo pode ser repetido quantas vezes for necessário.
class PagamentoCartaoCredito : Pagamento {
    public string Numero;
}
