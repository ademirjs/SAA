using System;
using System.Collections.Generic;

namespace SAA.Model.Models
{
    public partial class TipoAplicacao
    {
        public TipoAplicacao()
        {
            this.Aplicacaos = new List<Aplicacao>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Aplicacao> Aplicacaos { get; set; }
    }
}
