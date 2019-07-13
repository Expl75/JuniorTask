using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JuniorTask.Models;

namespace JuniorTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        private readonly IRepository<Person> repository;
        public EntityController(PersonContext context)
        {
            repository = new PersonRepository(context);
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return repository.FindAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Person> Get(string id)
        {
            Person person =  repository.FindPerson(id);
            if (person == null)
                return NotFound();
            return new ObjectResult(person);
        }

        [HttpPost]
        public ActionResult<Person> Post([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();

            repository.Create(person);
            repository.Save();
            return Ok(person);
        }

        [HttpPut("{id}")]
        public ActionResult<Person> Put([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();
            Person putPerson = repository.FindPerson(person.Id);
            if (putPerson == null)
                return NotFound();

            repository.Update(person);
            repository.Save();
            return Ok(person);
        }
      
        [HttpDelete("{id}")]
        public ActionResult<Person> Delete(string id)
        {
            Person person = repository.FindPerson(id);
            if(User == null)
            {
                return NotFound();
            }
            repository.Delete(id);
            repository.Save();
            return Ok(person);
        }
    }
}
