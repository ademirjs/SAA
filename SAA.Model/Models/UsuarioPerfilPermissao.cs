using System;
using System.Collections.Generic;

namespace SAA.Model.Models
{
    public partial class UsuarioPerfilPermissao
    {
        public UsuarioPerfilPermissao()
        {
            this.HitoricoUsuarioPerfilPermissaos = new List<HitoricoUsuarioPerfilPermissao>();
        }

        public int Id { get; set; }
        public int IdUsuarioPerfil { get; set; }
        public int IdOperacao { get; set; }
        public int IdTransacao { get; set; }
        public virtual Acao Acao { get; set; }
        public virtual ICollection<HitoricoUsuarioPerfilPermissao> HitoricoUsuarioPerfilPermissaos { get; set; }
        public virtual Transacao Transacao { get; set; }
        public virtual UsuarioPerfil UsuarioPerfil { get; set; }
    }
}
