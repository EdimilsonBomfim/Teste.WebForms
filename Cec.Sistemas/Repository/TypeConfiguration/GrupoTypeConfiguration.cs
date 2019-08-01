using Cec.Sistemas.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cec.Sistemas.Repository.TypeConfiguration
{
    public class GrupoTypeConfiguration : AbstractEntityTypeConfig<Grupo>
    {
        protected override void ConfigTable()
        {
            ToTable("Departamentos");
        }

        protected override void ConfigProperties()
        {
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(80)
                .IsRequired();

            Property(x => x.ReponsavelId)
                .HasColumnName("ResponsavelId")
                .HasColumnType("int")
                .IsOptional();
        }

        protected override void ConfigPrimaryKey()
        {
            HasKey(g => g.Id);
        }

        protected override void ConfigForeignKey()
        {

        }
    }
}
