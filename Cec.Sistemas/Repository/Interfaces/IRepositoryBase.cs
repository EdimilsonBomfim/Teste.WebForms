using System.Collections.Generic;

namespace Cec.Sistemas.Repository.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        IList<T> List();
        void Insert(T obj);
        void Update(T obj);
        T Get(int id);
        void Delete(int id);
    }
}
