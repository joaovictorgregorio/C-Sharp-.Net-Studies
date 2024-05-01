using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBalta.ContextoDeNotificacao
{
    public sealed class Notificacao
    {
        public Notificacao()
        {
            
        }

        public Notificacao(string propriedade, string mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
        }

        public string Propriedade { get; set; }
        public string Mensagem { get; set; }
    }
}