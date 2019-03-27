
namespace EnglishAppWeb.Models
{
    public class AtividadeAluno
    {
        public int AtividadeId { get; set; }
        public Atividade Atividade { get; set; }
        public int? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}