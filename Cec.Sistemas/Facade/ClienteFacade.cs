using System;
using System.Collections.Generic;
using Cec.Sistemas.Entities;
using Cec.Sistemas.Facade.Interfaces;
using Cec.Sistemas.Repository.Interfaces;

namespace Cec.Sistemas.Facade
{
    public class ClienteFacade : IClienteFacade
    {
        private readonly IClienteRepository _repository;

        public ClienteFacade(IClienteRepository repository)
        {
            _repository = repository;
        }

        public IList<Cliente> List()
        {
            return _repository.List();
        }

        public void Save(Cliente obj)
        {
            if(obj==null)
                throw  new  ArgumentNullException(nameof(Cliente));

            // Verifica se é inclusao ou atualização
            if (obj.Id != 0)
            {
                _repository.Update(obj);
            }
            else
            {
                _repository.Insert(obj);
            }
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