using Microsoft.EntityFrameworkCore;
using Banco.Classes.Entidade;
namespace Banco.Classes.Contextos
{
    internal class ContaContextos : DbContext
    {
        //Propriedades - Representa as contas no BD
        public DbSet<Conta> contas {  get; set; }
        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeContrucao)
        {
            string config = @"ECFP507D1319378\SQLEXPRESS;Database=BancoDBCOntas;Trusted_Connection = true;";
            opcoesDeContrucao.UseSqlServer(config);
        }

        protected override void OnModelCreating(ModelBuilder ModeloDeConstrucao)
        {
            ModeloDeConstrucao.Entity<Conta>(Entidade =>
            {
                Entidade.HasKey(e => e.Id );
                Entidade.Property(e => e.NumeroDaCota);
                Entidade.Property(e => e.TitularDaConta);
                Entidade.Property(e => e.SaldoDaConta);
            });
        }
    }
}
