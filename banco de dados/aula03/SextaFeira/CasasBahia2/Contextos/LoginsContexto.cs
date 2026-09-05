using Microsoft.EntityFrameworkCore;
using CasasBahia2.Modelos;

namespace CasasBahia2.Contextos
{
    internal class LoginsContexto : DbContext
    {
        public DbSet<Logins> LoginsSet { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=ECFP507D1319378\SQLEXPRESS03;Database=CasasBahia2;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Logins>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Usuario);
                entity.Property(e => e.Senha);
                entity.Property(e => e.Regra);
            });
        }
    }
}
