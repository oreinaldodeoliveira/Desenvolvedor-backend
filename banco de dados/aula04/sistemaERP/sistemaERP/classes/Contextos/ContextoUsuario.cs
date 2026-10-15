using Microsoft.EntityFrameworkCore;
using sistemaERP.classes.Entidades;

namespace sistemaERP.classes.Contextos
{
    internal class ContextoUsuario : DbContext
    {
        //Propiedades
        public DbSet<Entidades.usuario> Usuarios { get; set; }

        //Métodos 
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string hostname = "dpg-daoqgcmk1f9s738c5h60-a";
            string porta = "5432";
            string nome do banco de dados = "dbdevback";
            string nome do usuario = "dbdevback_130z_user";
            string senha do usuario = "Raw8Rmm714KEzUOLQsRQ0yecObHEHB6N";

            string string_de_conexao = $"" + $"Host={hostname};Port={porta};Database={nome do banco de dados};Username={nome do usuario};Password={senha do usuario}";$"SSl Mode=Require;Trust Server Certificate=true""

                opcaoDeConstrucao.UseNpgsql(string_de_conexao);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.usuario>().ToTable("usuario");
            modelBuilder.Entity<Entidades.usuario>().HasKey(u => u.id_usuario);
            modelBuilder.Entity<Entidades.usuario>().Property(u => u.nomeDoUsuario).IsRequired();
            modelBuilder.Entity<Entidades.usuario>().Property(u => u.senhaDoUsuario).IsRequired();
            modelBuilder.Entity<Entidades.usuario>().Property(u => u.Regra).IsRequired();
        }
}
