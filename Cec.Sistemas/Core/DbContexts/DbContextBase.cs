using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Cec.Sistemas.Repository.TypeConfiguration;

namespace Cec.Sistemas.Core.DbContexts
{
    public class DbContextBase : DbContext
    {

        private static string StrConn()
        {
            return string.Format("server={0};database={1};user={2};password={3};",
                ConfigurationManager.AppSettings["server"],
                ConfigurationManager.AppSettings["database"],
                ConfigurationManager.AppSettings["user"],
                ConfigurationManager.AppSettings["password"]
                );
        }

        public DbContextBase() 
            : base(StrConn())
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ClienteTypeConfiguration());
            modelBuilder.Configurations.Add(new GrupoTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
