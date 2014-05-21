using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SAA.Model.Models.Mapping
{
    public class UsuarioProvedorAutenticacaoMap : EntityTypeConfiguration<UsuarioProvedorAutenticacao>
    {
        public UsuarioProvedorAutenticacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("UsuarioProvedorAutenticacao");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdProvedorAutenticacao).HasColumnName("IdProvedorAutenticacao");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
            this.Property(t => t.Token).HasColumnName("Token");

            // Relationships
            this.HasRequired(t => t.ProvedorAutenticacao)
                .WithMany(t => t.UsuarioProvedorAutenticacaos)
                .HasForeignKey(d => d.IdProvedorAutenticacao);
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.UsuarioProvedorAutenticacaos)
                .HasForeignKey(d => d.IdUsuario);

        }
    }
}
