using System;
using System.Collections.Generic;

namespace EnglishAppWeb.Models
{
    public class Atividade
    {
        public int AtividadeId { get; set; }
        public string Nome { get; set; }
        public DateTime DataPostagem { get; set; }
        public DateTime DataEntrega { get; set; }
        public int Pontos { get; set; }
        public string Arquivo { get; set; }

        public ICollection<AtividadeAluno> AtividadeAluno { get; set; }
    }
}