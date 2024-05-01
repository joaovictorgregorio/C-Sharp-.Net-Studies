using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoBalta.ContextoDoConteudo.Enumeradores;

namespace CursoBalta.ContextoDoConteudo
{
    public class Curso : Conteudo
    {
        public Curso(string titulo, string url)
            : base(titulo, url)
        {
            Modulos = new List<Modulo>();
        }
        public string Etiqueta { get; set; }
        public IList<Modulo> Modulos { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public ENivelDeConteudo Nivel { get; set; }
    }
}