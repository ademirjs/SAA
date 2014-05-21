using System;
using System.Collections.Generic;

namespace SAA.Model.Models
{
    public partial class PerfilAplicacao
    {
        public PerfilAplicacao()
        {
            this.UsuarioPerfils = new List<UsuarioPerfil>();
        }

        public int Id { get; set; }
        public int IdAplicacao { get; set; }
        public string Nome { get; set; }
        public virtual Aplicacao Aplicacao { get; set; }
        public virtual ICollection<UsuarioPerfil> UsuarioPerfils { get; set; }
    }
}
