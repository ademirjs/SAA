using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SAA.Model.Models.Mapping
{
    public class TransacaoMap : EntityTypeConfiguration<Transacao>
    {
        public TransacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Hash)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Transacao");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Hash).HasColumnName("Hash");
            this.Property(t => t.IdAplicacao).HasColumnName("IdAplicacao");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");

            // Relationships
            this.HasRequired(t => t.Aplicacao)
                .WithMany(t => t.Transacaos)
                .HasForeignKey(d => d.IdAplicacao);

        }
    }
}
