using System;
using System.Collections.Generic;

namespace SAA.Model.Models
{
    public partial class Acao
    {
        public Acao()
        {
            this.UsuarioPerfilPermissaos = new List<UsuarioPerfilPermissao>();
        }

        public int Id { get; set; }
        public string Hash { get; set; }
        public string Rota { get; set; }
        public string Descricao { get; set; }
        public int IdTansacao { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public virtual Transacao Transacao { get; set; }
        public virtual ICollection<UsuarioPerfilPermissao> UsuarioPerfilPermissaos { get; set; }
    }
}
