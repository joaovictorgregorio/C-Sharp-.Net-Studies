using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoBalta.ContextoCompartilhado;

namespace CursoBalta.ContextoDeAssinatura
{
    public class Assinatura : Base
    {
        public Plano Plano { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool Inativo => DataFinal <= DateTime.Now;
    }
}