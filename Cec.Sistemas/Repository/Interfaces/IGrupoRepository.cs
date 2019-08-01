using Cec.Sistemas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cec.Sistemas.Repository.Interfaces
{
    public interface IGrupoRepository : IRepositoryBase<Grupo>
    {
        IList<Entities.Grupo> FindByName(string nome);
    }
}
