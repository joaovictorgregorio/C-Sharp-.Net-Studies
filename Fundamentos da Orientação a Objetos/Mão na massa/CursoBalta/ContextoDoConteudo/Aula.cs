using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoBalta.ContextoDoConteudo.Enumeradores;

namespace CursoBalta.ContextoDoConteudo
{
    public class Aula
    {
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public ENivelDeConteudo Nivel { get; set; }
    }
}