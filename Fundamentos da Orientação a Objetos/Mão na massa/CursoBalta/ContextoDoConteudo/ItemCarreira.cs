using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBalta.ContextoDoConteudo
{
    public class ItemCarreira
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public string Descricao { get; set; }
        public Curso Curso { get; set; }
    }
}