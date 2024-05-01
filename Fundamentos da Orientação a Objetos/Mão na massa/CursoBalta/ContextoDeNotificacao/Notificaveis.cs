using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace CursoBalta.ContextoDeNotificacao
{
    public abstract class Notificaveis
    {
        public List<Notificacao> Notificacoes { get; set; }
        public Notificaveis()
        {
            Notificacoes = new List<Notificacao>();
        }
        public void AddNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }

        public void AddNotificacoes(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.AddRange(notificacoes);
        }

        public bool Invalido => Notificacoes.Any();
    }
}