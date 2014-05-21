using System;
using System.Collections.Generic;

namespace SAA.Model.Models
{
    public partial class HitoricoUsuarioPerfilPermissao
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdUsuarioPerfilTransacao { get; set; }
        public System.DateTime DataRegistro { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual UsuarioPerfilPermissao UsuarioPerfilPermissao { get; set; }
    }
}
