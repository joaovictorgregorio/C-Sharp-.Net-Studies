using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBalta.ContextoDoConteudo
{
    // Adicionado tudo que é comum entre as classes do projeto.
    public abstract class Conteudo : Base
    {
        // Método Construtor da Classe : Conteudo
        public Conteudo(string titulo, string url)
        {
            Titulo = titulo;
            Url = url;
        }

        public string Titulo { get; set; }
        public string Url { get; set; }
    }
}