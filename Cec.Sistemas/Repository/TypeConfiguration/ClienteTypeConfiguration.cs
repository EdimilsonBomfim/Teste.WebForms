using Cec.Sistemas.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cec.Sistemas.Repository.TypeConfiguration
{
    public class ClienteTypeConfiguration:AbstractEntityTypeConfig<Cliente>
    {
        protected override void ConfigTable()
        {
            ToTable("Colaboradores");
        } 

        protected override void ConfigProperties()
        {
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(80)
                .IsRequired();

            Property(x => x.Documento)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.TipoPessoa)
              .HasColumnType("varchar")
              .HasMaxLength(1)
              .IsRequired();

            Property(x => x.GrupoId)
                .HasColumnType("int")
                .HasColumnName("DepartamentoId");
        }

        protected override void ConfigPrimaryKey() 
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigForeignKey()
        {
            HasRequired(a => a.Grupo)
                .WithMany(b => b.Clientes)
                .HasForeignKey(c => c.GrupoId)
                .WillCascadeOnDelete(false);
        }
    }
}