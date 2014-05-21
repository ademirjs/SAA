using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SAA.Model.Models.Mapping
{
    public class AcaoMap : EntityTypeConfiguration<Acao>
    {
        public AcaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Hash)
                .IsRequired();

            this.Property(t => t.Rota)
                .IsRequired();

            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Acao");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Hash).HasColumnName("Hash");
            this.Property(t => t.Rota).HasColumnName("Rota");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.IdTansacao).HasColumnName("IdTansacao");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");

            // Relationships
            this.HasRequired(t => t.Transacao)
                .WithMany(t => t.Acaos)
                .HasForeignKey(d => d.IdTansacao);

        }
    }
}
