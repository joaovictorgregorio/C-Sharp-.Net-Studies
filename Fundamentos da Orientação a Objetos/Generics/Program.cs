using System.Reflection.PortableExecutable;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pessoa = new Pessoa();
            var pagamento = new Pagamento();
            var assinatura = new Assinatura();

            // Quando uma classe genérica é instânciada, ela fica esperando um tipo.
            var contexto = new ContextoDosDados<Pessoa, Pagamento, Assinatura>();
            
            contexto.Salvar(pessoa);
            contexto.Salvar(pagamento);
            contexto.Salvar(assinatura);
        }
    }

    // Colocando <PE, PA, AS>, informamos ao sistema que está classe é genérica. PE, PA e AS são todos tipos.
    public class ContextoDosDados<PE, PA, AS>
        // Limitando o uso do Generics. PE só pode ser do tipo Pessoa. E assim na sequência, conforme as definições no where.
        where PE : Pessoa
        where PA : Pagamento
        where AS : Assinatura
    {
        public void Salvar(PE entidade)
        {

        }
        public void Salvar(PA entidade)
        {

        }
        public void Salvar(AS entidade)
        {

        }
    }

    public class Pessoa { }
    public class Pagamento { }
    public class Assinatura { }
}
