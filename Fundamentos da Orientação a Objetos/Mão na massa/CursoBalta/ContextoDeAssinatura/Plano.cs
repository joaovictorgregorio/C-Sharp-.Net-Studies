using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoBalta.ContextoCompartilhado;

namespace CursoBalta.ContextoDeAssinatura
{
    public class Plano : Base
    {
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
    }
}