using Cec.Sistemas.Core.DbContexts;
using Cec.Sistemas.Entities;
using System.Data.Entity;

namespace Cec.Sistemas.Repository.DbContexts
{
    public class DBSistema : DbContextBase
    {
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public DBSistema()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DBSistema, Migrations.Configuration>());
        }
    }
}
