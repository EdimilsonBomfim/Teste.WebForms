using System.Collections.Generic;

namespace Cec.Sistemas.Facade.Interfaces
{
    public interface IFacadeBase<T> where T : class
    {
        IList<T> List();
        void Save(T obj);
        T Get(int id);
        void Delete(int id);
    }
}
