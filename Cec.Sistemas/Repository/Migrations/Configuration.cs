using Cec.Sistemas.Entities;
using System.Collections.Generic;

namespace Cec.Sistemas.Repository.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Cec.Sistemas.Repository.DbContexts.DBSistema>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            MigrationsDirectory = @"Repository\Migrations";
            ContextKey = "Cec.Sistemas.Repository.DbContexts.DBSistema";
        }

        protected override void Seed(Cec.Sistemas.Repository.DbContexts.DBSistema context)
        {
            //var departamentos = new List<Grupo>
            //{
            //    new Grupo{Nome = "Administração Geral", Ativo = true},
            //    new Grupo{Nome = "Financeiro", Ativo = true},
            //    new Grupo{Nome = "RH",Ativo = true},
            //    new Grupo{Nome = "TI",Ativo = true}
            //};

            //context.Grupos.AddOrUpdate(departamentos.ToArray());
        }
    }
}
