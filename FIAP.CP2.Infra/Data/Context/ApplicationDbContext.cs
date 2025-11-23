using FIAP.CP2.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;

namespace FIAP.CP2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Tabelas
        public DbSet<ProfissaoAntigaModel> ProfissoesAntigas { get; set; }
        public DbSet<ProfissaoAtualModel> ProfissoesAtuais { get; set; }
        public DbSet<ProfissaoFuturaModel> ProfissoesFuturas { get; set; }
        public DbSet<TipoModel> Tipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Nome das tabelas
            modelBuilder.Entity<ProfissaoAntigaModel>().ToTable("PROFISSOES_ANTIGAS");
            modelBuilder.Entity<ProfissaoAtualModel>().ToTable("PROFISSOES_ATUAIS");
            modelBuilder.Entity<ProfissaoFuturaModel>().ToTable("PROFISSOES_FUTURAS");
            modelBuilder.Entity<TipoModel>().ToTable("TIPOS");

            // Campos das profissões antigas
            modelBuilder.Entity<ProfissaoAntigaModel>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.Nome)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(x => x.MotivoExtincao)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(x => x.SubstituidaPor)
                      .HasMaxLength(100);
            });

            // Campos das profissões atuais
            modelBuilder.Entity<ProfissaoAtualModel>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.Nome)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(x => x.RiscoExtincao)
                      .HasMaxLength(100);

                entity.Property(x => x.Motivo)
                      .HasMaxLength(200);
            });

            // Campos das profissões futuras
            modelBuilder.Entity<ProfissaoFuturaModel>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.Nome)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(x => x.MotivoExistencia)
                      .HasMaxLength(200);

                entity.Property(x => x.ChanceDeExistir)
                      .HasMaxLength(50);
            });

            // Campos do tipo (opcional no seu projeto)
            modelBuilder.Entity<TipoModel>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.Nome)
                      .IsRequired()
                      .HasMaxLength(50);
            });
        }
    }
}
