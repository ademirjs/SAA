using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SAA.Model.Models.Mapping
{
    public class TipoAplicacaoMap : EntityTypeConfiguration<TipoAplicacao>
    {
        public TipoAplicacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TipoAplicacao");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nome).HasColumnName("Nome");
        }
    }
}
