/* Aqui será abordado a partir de (Partial Class) até ... */

Console.Clear();
var pagamento = new PagamentoBoleto();

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