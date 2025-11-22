using Microsoft.EntityFrameworkCore;
using FIAP.CP2.Model;

namespace FIAP.CP2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Tabelas do projeto Start Trek
        public DbSet<ProfissaoAntigaModel> ProfissoesAntigas { get; set; }
        public DbSet<ProfissaoAtualModel> ProfissoesAtuais { get; set; }
        public DbSet<ProfissaoFuturaModel> ProfissoesFuturas { get; set; }

        // Caso o menu Tipos vire tabela
        public DbSet<TipoModel> Tipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurações básicas das tabelas
            modelBuilder.Entity<ProfissaoAntigaModel>().ToTable("PROFISSOES_ANTIGAS");
            modelBuilder.Entity<ProfissaoAtualModel>().ToTable("PROFISSOES_ATUAIS");
            modelBuilder.Entity<ProfissaoFuturaModel>().ToTable("PROFISSOES_FUTURAS");
            modelBuilder.Entity<TipoModel>().ToTable("TIPOS");

            // Exemplos de configurações comuns:
            modelBuilder.Entity<ProfissaoAntigaModel>()
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<ProfissaoAtualModel>()
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<ProfissaoFuturaModel>()
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<TipoModel>()
                .Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
