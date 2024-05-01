using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoBalta.ContextoCompartilhado;
using CursoBalta.ContextoDeNotificacao;

namespace CursoBalta.ContextoDeAssinatura
{
    public class Aluno : Base
    {
        public Aluno()
        {
            Assinaturas = new List<Assinatura>();
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Usuario Usuario { get; set; }
        public IList<Assinatura> Assinaturas { get; set; }
        public void CriaAssinatura(Assinatura assinatura)
        {
            if (Premium)
            {
                AddNotificacao(
                    new Notificacao(
                        "Premium", "O aluno já tem uma assinatura ativa!"));
                        return;
            }

            Assinaturas.Add(assinatura);
        }
        public bool Premium => Assinaturas.Any(x => x.Inativo);
    }
}