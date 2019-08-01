using Cec.Sistemas.Business.Interfaces;
using Cec.Sistemas.Entities;
using Cec.Sistemas.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Cec.Sistemas.Business
{
    public class ClienteBusiness : IBusinessBase<Cliente>
    {
        private readonly IClienteRepository _repository;

        public ClienteBusiness(IClienteRepository repository)
        {
            _repository = repository;
        }

        public IList<Cliente> List()
        {
            return _repository.List();
        }

        public void Save(Cliente obj)
        {
            if (obj == null)
                throw new ArgumentNullException("Não pode salvar um colaborador vazio");

            if (_repository.Get(obj.Id) == null)
                _repository.Insert(obj);
            else
                _repository.Update(obj);
        }

        public Cliente Get(int id)
        {
            return _repository.Get(id);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
