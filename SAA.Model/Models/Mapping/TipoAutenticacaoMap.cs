using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SAA.Model.Models.Mapping
{
    public class TipoAutenticacaoMap : EntityTypeConfiguration<TipoAutenticacao>
    {
        public TipoAutenticacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.URI)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("TipoAutenticacao");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.URI).HasColumnName("URI");
        }
    }
}
