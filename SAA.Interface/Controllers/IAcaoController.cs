using System.Collections.Generic;

namespace SAA.Interface.Controllers
{
    interface IAcaoController
    {
        KeyValuePair<SAA.Model.Models.Acao, bool> Get(string id);
    }
}
