using System;
using System.Linq;
using Cec.Sistemas.Entities;
using Cec.Sistemas.Repository.Interfaces;

namespace Cec.Sistemas.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public override void Insert(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof(Cliente));

            // Verifica se já existe algum colaorador no banco de dados com o mesmo nome
            if (Db.Set<Cliente>().Any(c=>c.Nome.ToLower().Contains( cliente.Nome.ToLower())))
            {
                throw  new Exception("Já existe colaborador cadastrado com este nome");
            }

            base.Insert(cliente);
        }        
    }
}