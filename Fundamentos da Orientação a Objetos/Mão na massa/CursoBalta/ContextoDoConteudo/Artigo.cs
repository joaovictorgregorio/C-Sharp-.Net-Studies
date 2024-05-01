using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoBalta.ContextoDeNotificacao;

namespace CursoBalta.ContextoDoConteudo
{
    public class Artigo : Conteudo
    {
        public IList<Notificacao> Notificacoes { get; set; }
        public Artigo(string titulo, string url)
            // Passando para o construtor da classe Conteudo.
            : base(titulo, url)
        {
            
        }
    }
}