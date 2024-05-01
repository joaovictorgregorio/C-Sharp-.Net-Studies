using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBalta.ContextoDoConteudo
{
    public class Modulo : Base
    {
        public Modulo()
        {
            Aulas = new List<Aula>();
        }
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public IList<Aula> Aulas { get; set; }
    }
}