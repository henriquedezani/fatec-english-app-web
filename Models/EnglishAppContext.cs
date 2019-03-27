using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

//http://www.entityframeworktutorial.net/efcore/configure-many-to-many-relationship-in-ef-core.aspx

namespace EnglishAppWeb.Models
{
    public class EnglishAppContext : DbContext
    {
        public EnglishAppContext(DbContextOptions<EnglishAppContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TurmaUsuario>().HasKey(ta => new { ta.TurmaId, ta.UsuarioId });
            modelBuilder.Entity<AtividadeAluno>().HasKey(ta => new { ta.AtividadeId, ta.UsuarioId });

            // modelBuilder.Entity<TurmaUsuario>()
            //     .HasKey(ta => new { ta.TurmaId, ta.UsuarioId });  
            // modelBuilder.Entity<TurmaUsuario>()
            //     .HasOne(bc => bc.Turma)
            //     .WithMany(b => b.TurmaAluno)
            //     .HasForeignKey(bc => bc.TurmaId)
            //     .OnDelete(DeleteBehavior.SetNull); 
            // modelBuilder.Entity<TurmaUsuario>()
            //     .HasOne(bc => bc.Usuario)
            //     .WithMany(c => c.TurmaAluno)
            //     .HasForeignKey(bc => bc.UsuarioId)
            //     .OnDelete(DeleteBehavior.SetNull);

            // modelBuilder.Entity<AtividadeAluno>()
            //     .HasKey(ta => new { ta.AtividadeId, ta.UsuarioId });  
            // modelBuilder.Entity<AtividadeAluno>()
            //     .HasOne(bc => bc.Atividade)
            //     .WithMany(b => b.AtividadeAluno)
            //     .HasForeignKey(bc => bc.AtividadeId)
            //     .OnDelete(DeleteBehavior.SetNull);
            // modelBuilder.Entity<AtividadeAluno>()
            //     .HasOne(bc => bc.Usuario)
            //     .WithMany(c => c.AtividadeAluno)
            //     .HasForeignKey(bc => bc.UsuarioId)
            //     .OnDelete(DeleteBehavior.SetNull);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Atividade> Atividades { get; set; }
        public DbSet<AtividadeAluno> AtividadeAlunos { get; set; }
        public DbSet<TurmaUsuario> TurmaUsuarios { get; set; }
    }
    
}

// após criados os modelos e configuradas as conexão (Startup), executar:
// dotnet ef migrations add InitialCreate
// dotnet ef database update