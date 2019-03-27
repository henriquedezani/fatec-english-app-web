namespace EnglishAppWeb.Models
{
    public class TurmaUsuario
    {
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }


    }
}