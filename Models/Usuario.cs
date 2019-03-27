using System.Collections.Generic;

namespace EnglishAppWeb.Models
{
    public enum TipoUsuario { Aluno, Professor }

    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuario Tipo { get; set; }

        public ICollection<TurmaUsuario> TurmaUsuario { get; set; }
        public ICollection<AtividadeAluno> AtividadeAluno { get; set; }
    }
}