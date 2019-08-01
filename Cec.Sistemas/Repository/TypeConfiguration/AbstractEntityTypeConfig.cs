using System.Data.Entity.ModelConfiguration;

namespace Cec.Sistemas.Repository.TypeConfiguration
{
    public abstract class AbstractEntityTypeConfig<T> : EntityTypeConfiguration<T> where T : class
    {
        public AbstractEntityTypeConfig()
        {
            ConfigTable();
            ConfigProperties();
            ConfigPrimaryKey();
            ConfigForeignKey();
        }

        protected abstract void ConfigTable();
        protected abstract void ConfigProperties();
        protected abstract void ConfigPrimaryKey();
        protected abstract void ConfigForeignKey();
    }
}