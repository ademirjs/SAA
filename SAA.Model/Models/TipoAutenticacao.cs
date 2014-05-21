using System;
using System.Collections.Generic;

namespace SAA.Model.Models
{
    public partial class TipoAutenticacao
    {
        public TipoAutenticacao()
        {
            this.ProvedorAutenticacaos = new List<ProvedorAutenticacao>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string URI { get; set; }
        public virtual ICollection<ProvedorAutenticacao> ProvedorAutenticacaos { get; set; }
    }
}
