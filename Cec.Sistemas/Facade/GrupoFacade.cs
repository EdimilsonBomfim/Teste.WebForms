using Cec.Sistemas.Business.Interfaces;
using Cec.Sistemas.Entities;
using Cec.Sistemas.Facade.Interfaces;
using System;
using System.Collections.Generic;

namespace Cec.Sistemas.Facade
{
    public class GrupoFacade : IGrupoFacade
    {
        IGrupoBusiness _grupoBusiness;

        public GrupoFacade(IGrupoBusiness grupoBusiness)
        {
            _grupoBusiness = grupoBusiness;
        }

        public IList<Entities.Grupo> List()
        {
            return _grupoBusiness.List();
        }

        public void Save(Entities.Grupo obj)
        {
            _grupoBusiness.Save(obj);
        }

        public Entities.Grupo Get(int id)
        {
            return _grupoBusiness.Get(id);
        }

        public void Delete(int id)
        {
           _grupoBusiness.Delete(id);
        }

        public IList<Grupo> FindByName(string nome)
        {
            return _grupoBusiness.FindByName(nome);
        }
    }
}
