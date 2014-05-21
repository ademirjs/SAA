using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SAA.Model.Models.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Login)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Senha)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Usuario");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Login).HasColumnName("Login");
            this.Property(t => t.Senha).HasColumnName("Senha");
            this.Property(t => t.IdPerfil).HasColumnName("IdPerfil");
        }
    }
}
