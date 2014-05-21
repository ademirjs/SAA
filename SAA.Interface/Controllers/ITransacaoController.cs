using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA.Interface.Controllers
{
    public interface ITransacaoController
    {
        /// <summary>
        /// Retorna uma coleção de par de chaves e valores que representa as permissões de um usuário para uma consulta
        /// </summary>
        /// <param name="id">O identificador da transação</param>
        /// <returns>Uma Coleção de KeyValuePair<Acao, bool> que representa as permissões do usuário para cada ação da transação</returns>
        ICollection<KeyValuePair<SAA.Model.Models.Acao, bool>> Get(string id);
    }
}
