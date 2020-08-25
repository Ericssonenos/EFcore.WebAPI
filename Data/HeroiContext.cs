using EFcore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFcore.WebAPI.Data
{
    public class HeroiContext : DbContext
    {
        public DbSet<Heroi>Herois { get; set; }
        public DbSet<Batalha>Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<HeroiBatalha> HeroiBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> identidadeSecretas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexao =
                    @"data source = 162.241.137.54; " +
                    "initial catalog = ESousa_Pantanal; " +
                    "user id = ESousa_Ericsson; " +
                    "pwd = Tailor@01; " +
                    "packet size = 4096; " +
                    "persist security info = False; " +
                    "initial catalog = ESousa_Pantanal;  ";


            optionsBuilder.UseSqlServer( 
                @"data source= DESKTOP-BTMP0PO\MODULO1; " +
                "Integrated Security=SSPI; " +
                "Initial Catalog = HeroApp;" +
                "Min Pool Size=5;" +
                "Max Pool Size=250; " +
                "Connect Timeout=3");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(Entidade =>
                {
                    Entidade.HasKey(chave => new { chave.BatalhaId, chave.HeroId });
                });
        }
    }
}
