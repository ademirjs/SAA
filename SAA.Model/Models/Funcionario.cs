using System;
using System.Collections.Generic;

namespace SAA.Model.Models
{
    public partial class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ADUser { get; set; }
        public int Matricula { get; set; }
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
