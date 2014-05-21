using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SAA.Interface.Controllers;
using SAA.Model.Models;

namespace SAA.WebApi.Controllers
{
    public class TransacaoController : ApiController, ITransacaoController
    {
        public ICollection<KeyValuePair<Acao, bool>> Get(string id)
        {
            Acao acao = new Acao();
            acao.Id = 1;
            acao.Descricao = "Teste";
            acao.DataCriacao = DateTime.Now;
            List<KeyValuePair<Acao, bool>> Permissoes = new List<KeyValuePair<Acao, bool>>();
            Permissoes.Add(new KeyValuePair<Acao, bool>(acao, true));
            return Permissoes;
        }
    }
}
