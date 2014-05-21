using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SAA.Model.Models.Mapping
{
    public class UsuarioPerfilPermissaoMap : EntityTypeConfiguration<UsuarioPerfilPermissao>
    {
        public UsuarioPerfilPermissaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("UsuarioPerfilPermissao");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdUsuarioPerfil).HasColumnName("IdUsuarioPerfil");
            this.Property(t => t.IdOperacao).HasColumnName("IdOperacao");
            this.Property(t => t.IdTransacao).HasColumnName("IdTransacao");

            // Relationships
            this.HasRequired(t => t.Acao)
                .WithMany(t => t.UsuarioPerfilPermissaos)
                .HasForeignKey(d => d.IdOperacao);
            this.HasRequired(t => t.Transacao)
                .WithMany(t => t.UsuarioPerfilPermissaos)
                .HasForeignKey(d => d.IdTransacao);
            this.HasRequired(t => t.UsuarioPerfil)
                .WithMany(t => t.UsuarioPerfilPermissaos)
                .HasForeignKey(d => d.IdUsuarioPerfil);

        }
    }
}
