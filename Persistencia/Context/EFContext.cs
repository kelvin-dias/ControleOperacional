using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Tabelas;

namespace Persistencia.Context
{
    public class EFContext : DbContext
    {
        //Desativar a função que cria o banco de dados e a tabela automáticamente passando parametro Null.
        //public EFContext() : base("Asp_Net_MVC_CS")
        //{
        //    Database.SetInitializer<EFContext>(new MigrateDatabaseToLatestVersion<EFContext, Configuration>());
        //}

        public DbSet<Servidor> Servidores { get; set; }
        public DbSet<Rotina> Rotinas { get; set; }
        public DbSet<Ocorrencia> Ocorrencias { get; set; }
        public DbSet<Iteracao> Iteracoes { get; set; }

        //resolver o problema de pluralização quando cria as tabelas pelo EF.
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Conventions.
        //    Remove<PluralizingTableNameConvention>();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fadami\source\repos\ControleOperacional\ControleOperacional\App_Data\CONTROLE_OPERACIONAL.mdf;Integrated Security=True");
        }
    }

}