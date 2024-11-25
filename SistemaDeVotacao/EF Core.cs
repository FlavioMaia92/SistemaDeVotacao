using Microsoft.EntityFrameworkCore;
using VotingManager.Model.Users;
using VotingManager.Model.Elections;
using SistemaDeVotacao;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace VotingManager.Persistence
{
    public class VotingContext : DbContext
    {
        public DbSet<Eleitor> Eleitores { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Eleicao> Eleicoes { get; set; }
        public DbSet<Voto> Votos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=voting.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Voto>()
                .HasOne(v => v.Eleitor)
                .WithMany()
                .HasForeignKey(v => v.EleitorId);

            modelBuilder.Entity<Voto>()
                .HasOne(v => v.Candidato)
                .WithMany()
                .HasForeignKey(v => v.CandidatoId);
        }
    }
}
