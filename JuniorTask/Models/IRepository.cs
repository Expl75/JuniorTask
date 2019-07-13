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
        void Delete(string id);
        void Create(T item);
        void Update(T item);
        void Save();
    }
}
