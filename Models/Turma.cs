using System.Collections.Generic;

namespace EnglishAppWeb.Models
{
    public class Turma
    {
        public int TurmaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }

        public ICollection<TurmaUsuario> TurmaUsuario { get; set; }
    }
}