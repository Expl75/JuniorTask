using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuniorTask.Models
{
    interface IRepository <T>: IDisposable
        where T : class
    {
        IEnumerable<T> FindAll();
        T FindPerson(string id);
        Person Delete(string id);
        Person Create(T item);
        Person Update(T item);
        void Save();
    }
}
