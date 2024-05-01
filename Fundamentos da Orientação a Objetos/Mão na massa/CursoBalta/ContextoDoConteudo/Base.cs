using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoBalta.ContextoDeNotificacao;

namespace CursoBalta.ContextoCompartilhado
{
    public abstract class Base : Notificaveis
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}