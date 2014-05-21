using System;
using System.Collections.Generic;

namespace SAA.Model.Models
{
    public partial class Aplicacao
    {
        public Aplicacao()
        {
            this.PerfilAplicacaos = new List<PerfilAplicacao>();
            this.Transacaos = new List<Transacao>();
        }

        public int Id { get; set; }
        public string Guid { get; set; }
        public string Nome { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public int IdTipoAplicacao { get; set; }
        public virtual TipoAplicacao TipoAplicacao { get; set; }
        public virtual ICollection<PerfilAplicacao> PerfilAplicacaos { get; set; }
        public virtual ICollection<Transacao> Transacaos { get; set; }
    }
}
