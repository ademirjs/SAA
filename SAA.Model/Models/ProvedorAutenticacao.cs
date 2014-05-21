using System;
using System.Collections.Generic;

namespace SAA.Model.Models
{
    public partial class ProvedorAutenticacao
    {
        public ProvedorAutenticacao()
        {
            this.UsuarioProvedorAutenticacaos = new List<UsuarioProvedorAutenticacao>();
        }

        public int Id { get; set; }
        public int IdTipo { get; set; }
        public string Nome { get; set; }
        public string URI { get; set; }
        public virtual TipoAutenticacao TipoAutenticacao { get; set; }
        public virtual ICollection<UsuarioProvedorAutenticacao> UsuarioProvedorAutenticacaos { get; set; }
    }
}
