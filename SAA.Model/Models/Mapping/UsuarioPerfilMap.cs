using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SAA.Model.Models.Mapping
{
    public class UsuarioPerfilMap : EntityTypeConfiguration<UsuarioPerfil>
    {
        public UsuarioPerfilMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("UsuarioPerfil");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
            this.Property(t => t.IdPerfilAplicacao).HasColumnName("IdPerfilAplicacao");

            // Relationships
            this.HasRequired(t => t.PerfilAplicacao)
                .WithMany(t => t.UsuarioPerfils)
                .HasForeignKey(d => d.IdPerfilAplicacao);
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.UsuarioPerfils)
                .HasForeignKey(d => d.IdUsuario);

        }
    }
}
