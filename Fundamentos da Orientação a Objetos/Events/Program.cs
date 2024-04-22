namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var sala = new Sala();
            // Delegação do evento.
            sala.SalaEsgotadaEvento += QuandoMinhaSalaLotar;

            sala.ReserveAssento();
            sala.ReserveAssento();
            sala.ReserveAssento();
            sala.ReserveAssento();
            sala.ReserveAssento();
        }

        static void QuandoMinhaSalaLotar(object remetente, EventArgs e)
        {
            Console.WriteLine("Sala lotada!");
        }
    }

    public class Sala()
    {
        public void Salas(int assentos)
        {
            Assentos = assentos;
            assentosEmUso = 0;
        }

        protected int assentosEmUso = 0;

        public int Assentos { get; set; }

        public void ReserveAssento()
        {
            assentosEmUso++;
            if (assentosEmUso >= Assentos)
            {
                QuandoSalaTiverEsgotada(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Assento reservado!");
            }
        }

        // Definição do evento. Os eventos são apenas uma assinatura. EventHandler = manipulador de eventos.
        public event EventHandler SalaEsgotadaEvento;

        // EventArgs detecta quem disparou o evento. Aqui está definido a execução do meu evento. Implementação base.
        protected virtual void QuandoSalaTiverEsgotada(EventArgs e)
        {
            EventHandler manipulador = SalaEsgotadaEvento;
            // ? Adicionado, caso venha uma informação nula.
            manipulador?.Invoke(this, e);
        }
    }
}

