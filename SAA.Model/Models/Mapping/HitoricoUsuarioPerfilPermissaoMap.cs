using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SAA.Model.Models.Mapping
{
    public class HitoricoUsuarioPerfilPermissaoMap : EntityTypeConfiguration<HitoricoUsuarioPerfilPermissao>
    {
        public HitoricoUsuarioPerfilPermissaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("HitoricoUsuarioPerfilPermissao");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
            this.Property(t => t.IdUsuarioPerfilTransacao).HasColumnName("IdUsuarioPerfilTransacao");
            this.Property(t => t.DataRegistro).HasColumnName("DataRegistro");

            // Relationships
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.HitoricoUsuarioPerfilPermissaos)
                .HasForeignKey(d => d.IdUsuario);
            this.HasRequired(t => t.UsuarioPerfilPermissao)
                .WithMany(t => t.HitoricoUsuarioPerfilPermissaos)
                .HasForeignKey(d => d.IdUsuarioPerfilTransacao);

        }
    }
}
