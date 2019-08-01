using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cec.Sistemas.Business.Interfaces
{
    public interface IBusinessBase<T> where T : class
    {
        IList<T> List();
        void Save(T obj);
        T Get(int id);
        void Delete(int id);        
    }
}
