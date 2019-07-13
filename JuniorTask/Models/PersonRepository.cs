using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JuniorTask.Models
{
    public class PersonRepository : IRepository<Person>
    {
        private PersonContext context;

        public PersonRepository(PersonContext context)
        {
            this.context = context;
        }

        public void Create(Person person)
        {
            context.People.Add(person);
        }

        public void Delete(string id)
        {
            Person person = context.People.Find(id);
            if (person != null)
                context.People.Remove(person);
        }

        public IEnumerable<Person> FindAll()
        {
            return context.People;
        }

        public Person FindPerson(string id)
        {
            return context.People.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Person person)
        {
            context.Entry(person).State = EntityState.Modified;
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
