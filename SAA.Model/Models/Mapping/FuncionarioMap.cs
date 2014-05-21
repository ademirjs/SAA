using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SAA.Model.Models.Mapping
{
    public class FuncionarioMap : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ADUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Funcionario");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.ADUser).HasColumnName("ADUser");
            this.Property(t => t.Matricula).HasColumnName("Matricula");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");

            // Relationships
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.Funcionarios)
                .HasForeignKey(d => d.IdUsuario);

        }
    }
}
