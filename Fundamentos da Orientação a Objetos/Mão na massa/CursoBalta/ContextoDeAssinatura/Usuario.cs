using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoBalta.ContextoDoConteudo;

namespace CursoBalta.ContextoDeAssinatura
{
    public class Usuario : Base
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
    }
}