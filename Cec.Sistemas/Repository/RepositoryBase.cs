using Cec.Sistemas.Repository.DbContexts;
using Cec.Sistemas.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cec.Sistemas.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DBSistema Db = new DBSistema();

        public virtual void Insert(T obj)
        {
            Db.Set<T>().Add(obj);
            Db.SaveChanges();
        }

        public virtual T Get(int id)
        {
            return Db.Set<T>().Find(id);
        }

        public virtual IList<T> List()
        {
            return Db.Set<T>().ToList();
        }

        public virtual void Update(T obj)
        {
            Db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var reg = Db.Set<T>().Find(id);

            if (reg == null)
                throw new ArgumentNullException("Registro não encontrado");

            Db.Set<T>().Remove(reg);
            Db.SaveChanges();
        }
    }
}
