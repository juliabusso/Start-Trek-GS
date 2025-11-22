using FIAP.CP2.Model;
using Microsoft.EntityFrameworkCore;

namespace FIAP.CP2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Tabelas do sistema
        public DbSet<AlunoModel> Alunos { get; set; }
        public DbSet<ProfissaoAntigaModel> ProfissoesAntigas { get; set; }
        public DbSet<ProfissaoAtualModel> ProfissoesAtuais { get; set; }
        public DbSet<ProfissaoFuturaModel> ProfissoesFuturas { get; set; }
        public DbSet<TipoModel> Tipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
        }
    }
}
