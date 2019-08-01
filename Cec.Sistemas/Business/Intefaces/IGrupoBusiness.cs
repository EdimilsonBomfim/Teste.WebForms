using Cec.Sistemas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cec.Sistemas.Business.Interfaces
{
    public interface IGrupoBusiness : IBusinessBase<Grupo>
    {
        IList<Grupo> FindByName(string nome);
    }
}
