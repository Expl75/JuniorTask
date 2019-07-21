using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuniorTask.DataBase;
using JuniorTask.Models;
using Microsoft.EntityFrameworkCore;

namespace JuniorTask.DataBase
{
    public class AttributeRepository : IRepository<PersonAttribute>
    {
        private readonly PersonContext context;

        public AttributeRepository(PersonContext context)
        {
            this.context = context;
        }

        public PersonAttribute Create(PersonAttribute item)
        {
            context.personAttributes.Add(item);
            return item;
        }

        public PersonAttribute Delete(string id)
        {
            PersonAttribute personAttribute = context.personAttributes.Find(id);
            if (personAttribute != null)
                context.personAttributes.Remove(personAttribute);
            return personAttribute;
        }

        public IEnumerable<PersonAttribute> FindAll()
        {
            return context.personAttributes;
        }

        public PersonAttribute Find(string id)
        {
            return context.personAttributes.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public PersonAttribute Update(PersonAttribute item)
        {
            context.Entry(item).State = EntityState.Modified;
            return item;
        }

        public bool disposed = false;

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
