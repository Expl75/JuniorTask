using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JuniorTask.Models
{
    public class PersonContext :DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<PersonAttribute> personAttributes { get; set; }
        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {

        }
    }
}
