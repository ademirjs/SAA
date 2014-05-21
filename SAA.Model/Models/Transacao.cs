using System;
using System.Collections.Generic;

namespace SAA.Model.Models
{
    public partial class Transacao
    {
        public Transacao()
        {
            this.Acaos = new List<Acao>();
            this.UsuarioPerfilPermissaos = new List<UsuarioPerfilPermissao>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Hash { get; set; }
        public int IdAplicacao { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public virtual ICollection<Acao> Acaos { get; set; }
        public virtual Aplicacao Aplicacao { get; set; }
        public virtual ICollection<UsuarioPerfilPermissao> UsuarioPerfilPermissaos { get; set; }
    }
}
