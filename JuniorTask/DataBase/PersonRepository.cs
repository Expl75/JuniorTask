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

        public Person Create(Person person)
        {
            context.People.Add(person);
            return person;
        }

        public Person Delete(string id)
        {
            Person person = context.People.Find(id);
            if (person != null)
                context.People.Remove(person);
            return person;
        }

        public IEnumerable<Person> FindAll()
        {
            return context.People;
        }

        public Person Find(string id)
        {
            return context.People.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public Person Update(Person person)
        {
            context.Entry(person).State = EntityState.Modified;
            return person;
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
