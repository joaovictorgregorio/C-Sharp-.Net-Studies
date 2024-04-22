/* Aqui será abordado a partir de (Partial Class) até (Comparando Objetos) */

Console.Clear();
var pagamento = new PagamentoBoleto();

// var pessoa = new Pessoa("");
// var pessoaFisica = new PessoaFisica();
// var pessoaJuridica = new PessoaJuridica();

// // Realização do Downcast. Converter de cima para baixo. Torna classe-pai para classe-filha.
// pessoaFisica = (PessoaFisica)pessoa;
// pessoaJuridica = (PessoaJuridica)pessoa;

// Comparando objetos.
var pessoaA = new Pessoa(1, "Joao Victor Gregorio");
var pessoaB = new Pessoa(1, "Joao Victor Gregorio");

// Será retornado False, pois seus endereços na memória são diferentes. Desta forma, nunca irá funcionar para comparação de objetos.
Console.WriteLine(pessoaA == pessoaB);

// Comparando objetos de forma correta.
Console.WriteLine(pessoaA.Equals(pessoaB));


// Abstract vai negar o instânciamento desta classe, não poderá ser instânciada. Ela só pode ser herdada.
public abstract class Pagamento : IPagamento
{
    public DateTime Vencimento { get; set; }

    public virtual void Pagar(double valor)
    {
        // Executar
    }
}

public class PagamentoCartaoCredito : Pagamento
{
    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }
}

public class PagamentoApplePay : Pagamento
{
    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }
}

public class PagamentoBoleto : Pagamento
{
    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }
}

// Normalmente as Interfaces são iniciadas com a letra I na frente da sua nomenclatura. A diferença entre classe e interface é que as interfaces não contém implementações, apenas declarações. Na interface temos todas as definições que um Pagamento precisa, neste caso. O uso é muito recomendado sem excessões. As interfaces assumem um papel de contrato entre as partes.
public interface IPagamento
{
    // Não é definido os modificadores de acesso como: public, private entre outros. A implementação que definirá depois essas características.
    DateTime Vencimento { get; set; }

    void Pagar(double valor);
}

// O conceito Downcast, converter de cima para baixo. Torna classe-pai para classe-filha.
// IEquatable<Pessoa> é a maneira mais correta para comparar objetos.
public class Pessoa : IEquatable<Pessoa>
{
    public Pessoa(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
    public string Nome { get; set; }
    public int Id { get; set; }

    public bool Equals(Pessoa? other)
    {
        return Id == other.Id;
    }
}

// O conceito de Upcast ou Upcasting é que, como esta classe-filha tem todas as propriedades que a classe-pai tem, podemos dizer que uma classe-filha também é uma classe-pai.
// public class PessoaFisica : Pessoa
// {
//     public string CPF { get; set; }
// }

// public class PessoaJuridica : Pessoa
// {
//     public string CNPJ { get; set; }
// }