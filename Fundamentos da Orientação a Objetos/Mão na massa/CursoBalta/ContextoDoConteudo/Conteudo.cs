using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBalta.ContextoDoConteudo
{
    // Adicionado tudo que é comum entre as classes do projeto.
    public abstract class Conteudo
    {
        // Método Construtor da Classe : Conteudo
        public Conteudo()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Url { get; set; }
    }
}