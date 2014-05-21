using System;
using System.Collections.Generic;

namespace SAA.Model.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            this.Funcionarios = new List<Funcionario>();
            this.HitoricoUsuarioPerfilPermissaos = new List<HitoricoUsuarioPerfilPermissao>();
            this.UsuarioPerfils = new List<UsuarioPerfil>();
            this.UsuarioProvedorAutenticacaos = new List<UsuarioProvedorAutenticacao>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int IdPerfil { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
        public virtual ICollection<HitoricoUsuarioPerfilPermissao> HitoricoUsuarioPerfilPermissaos { get; set; }
        public virtual ICollection<UsuarioPerfil> UsuarioPerfils { get; set; }
        public virtual ICollection<UsuarioProvedorAutenticacao> UsuarioProvedorAutenticacaos { get; set; }
    }
}
