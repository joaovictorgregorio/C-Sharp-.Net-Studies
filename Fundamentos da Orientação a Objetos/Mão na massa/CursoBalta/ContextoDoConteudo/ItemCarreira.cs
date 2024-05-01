using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoBalta.ContextoDeNotificacao;

namespace CursoBalta.ContextoDoConteudo
{
    public class ItemCarreira : Base
    {
        public ItemCarreira(int ordem, string titulo, string descricao, Curso curso)
        {
            if (curso == null)
                AddNotificacao(new Notificacao("Curso", "Curso inválido"));

            Ordem = ordem;
            Titulo = titulo;
            Descricao = descricao;
            Curso = curso;
        }

        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Curso Curso { get; set; }
    }
}