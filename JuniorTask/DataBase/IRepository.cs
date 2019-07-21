using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuniorTask.Models
{
    public interface IRepository <T>: IDisposable
        where T : class
    {
        IEnumerable<T> FindAll();
        T Find(string id);
        T Delete(string id);
        T Create(T item);
        T Update(T item);
        void Save();
    }
}
