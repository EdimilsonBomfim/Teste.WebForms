using System;
using Cec.Sistemas.Business.Interfaces;
using Cec.Sistemas.Repository.Interfaces;
using System.Collections.Generic;

namespace Cec.Sistemas.Business
{
    public class GrupoBusiness : IGrupoBusiness
    {
        private readonly IGrupoRepository _repository;

        public GrupoBusiness(IGrupoRepository repository)
        {
            _repository = repository;
        }

        public void Save(Entities.Grupo obj)
        {
            if (obj == null)
                throw new ArgumentNullException("Não pode salvar um departamento vazio");

            if (_repository.Get(obj.Id) == null)
                _repository.Insert(obj);
            else
                _repository.Update(obj);
        }

        public IList<Entities.Grupo> List()
        {
            return _repository.List();
        }

        public Entities.Grupo Get(int id)
        {
            return _repository.Get(id);
        }

        public IList<Entities.Grupo> FindByName(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentNullException("Nenhum valor fornecido para o parâmetro da pesquisa");

            return _repository.FindByName(nome);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
