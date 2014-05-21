using System;
using System.Collections.Generic;

namespace SAA.Model.Models
{
    public partial class UsuarioProvedorAutenticacao
    {
        public int Id { get; set; }
        public int IdProvedorAutenticacao { get; set; }
        public int IdUsuario { get; set; }
        public string Token { get; set; }
        public virtual ProvedorAutenticacao ProvedorAutenticacao { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
