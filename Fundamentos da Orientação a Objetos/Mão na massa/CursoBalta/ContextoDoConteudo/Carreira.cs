using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBalta.ContextoDoConteudo
{
    public class Carreira : Conteudo
    {
        public Carreira()
        {
            Items = new List<ItemCarreira>();
        }
        public IList<ItemCarreira> Items { get; set; }
        // Expression Body
        public int TotalCursos => Items.Count;
    }
}