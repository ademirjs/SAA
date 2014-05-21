using System;
using System.Collections.Generic;

namespace SAA.Model.Models
{
    public partial class UsuarioPerfil
    {
        public UsuarioPerfil()
        {
            this.UsuarioPerfilPermissaos = new List<UsuarioPerfilPermissao>();
        }

        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdPerfilAplicacao { get; set; }
        public virtual PerfilAplicacao PerfilAplicacao { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<UsuarioPerfilPermissao> UsuarioPerfilPermissaos { get; set; }
    }
}
