using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SAA.Model.Models.Mapping;

namespace SAA.Model.Models
{
    public partial class KERBEROSContext : DbContext
    {
        static KERBEROSContext()
        {
            Database.SetInitializer<KERBEROSContext>(null);
        }

        public KERBEROSContext()
            : base("Name=KERBEROSContext")
        {
        }

        public DbSet<Acao> Acaos { get; set; }
        public DbSet<Aplicacao> Aplicacaos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<HitoricoUsuarioPerfilPermissao> HitoricoUsuarioPerfilPermissaos { get; set; }
        public DbSet<PerfilAplicacao> PerfilAplicacaos { get; set; }
        public DbSet<ProvedorAutenticacao> ProvedorAutenticacaos { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TipoAplicacao> TipoAplicacaos { get; set; }
        public DbSet<TipoAutenticacao> TipoAutenticacaos { get; set; }
        public DbSet<Transacao> Transacaos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioPerfil> UsuarioPerfils { get; set; }
        public DbSet<UsuarioPerfilPermissao> UsuarioPerfilPermissaos { get; set; }
        public DbSet<UsuarioProvedorAutenticacao> UsuarioProvedorAutenticacaos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AcaoMap());
            modelBuilder.Configurations.Add(new AplicacaoMap());
            modelBuilder.Configurations.Add(new FuncionarioMap());
            modelBuilder.Configurations.Add(new HitoricoUsuarioPerfilPermissaoMap());
            modelBuilder.Configurations.Add(new PerfilAplicacaoMap());
            modelBuilder.Configurations.Add(new ProvedorAutenticacaoMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TipoAplicacaoMap());
            modelBuilder.Configurations.Add(new TipoAutenticacaoMap());
            modelBuilder.Configurations.Add(new TransacaoMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new UsuarioPerfilMap());
            modelBuilder.Configurations.Add(new UsuarioPerfilPermissaoMap());
            modelBuilder.Configurations.Add(new UsuarioProvedorAutenticacaoMap());
        }
    }
}
