using Cec.Sistemas.Entities;
using Cec.Sistemas.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cec.Sistemas.Repository
{
    public class GrupoRepository : RepositoryBase<Grupo>, IGrupoRepository
    {
        public override void Insert(Grupo grupo)
        {
            if (grupo == null)
                throw new ArgumentNullException(nameof(Grupo));

            // Verifica se já existe algum cliente no banco de dados com o mesmo nome
            if (Db.Set<Grupo>().Any(c => c.Nome.ToLower().Contains(grupo.Nome.ToLower())))
            {
                throw new Exception("Já existe departamento cadastrado com este nome");
            }

            base.Insert(grupo);
            //base.Delete(grupo.Id);
        }

        /// <summary>
        /// Realiza a pesquisa pelo nome do departamento
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Coleção de departamentos</returns>
        public IList<Grupo> FindByName(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentNullException(nameof(nome));

            return new List<Grupo>(Db.Grupos.Where(d => d.Nome.ToLower().Contains(nome)));
        }
    }
}
