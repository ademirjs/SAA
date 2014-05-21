using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SAA.Model.Models.Mapping
{
    public class ProvedorAutenticacaoMap : EntityTypeConfiguration<ProvedorAutenticacao>
    {
        public ProvedorAutenticacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.URI)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ProvedorAutenticacao");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdTipo).HasColumnName("IdTipo");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.URI).HasColumnName("URI");

            // Relationships
            this.HasRequired(t => t.TipoAutenticacao)
                .WithMany(t => t.ProvedorAutenticacaos)
                .HasForeignKey(d => d.IdTipo);

        }
    }
}
