using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SAA.Model.Models.Mapping
{
    public class PerfilAplicacaoMap : EntityTypeConfiguration<PerfilAplicacao>
    {
        public PerfilAplicacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PerfilAplicacao");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdAplicacao).HasColumnName("IdAplicacao");
            this.Property(t => t.Nome).HasColumnName("Nome");

            // Relationships
            this.HasRequired(t => t.Aplicacao)
                .WithMany(t => t.PerfilAplicacaos)
                .HasForeignKey(d => d.IdAplicacao);

        }
    }
}
