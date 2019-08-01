using System.Collections.Generic;
using Cec.Sistemas.Entities;

namespace Cec.Sistemas.Facade.Interfaces
{
    public interface IGrupoFacade : IFacadeBase<Grupo>
    {
        IList<Grupo> FindByName(string nome);
        //void Delete(string iD);
    }
}
