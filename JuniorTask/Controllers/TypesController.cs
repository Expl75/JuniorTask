using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JuniorTask.Models;
using JuniorTask.DataBase;

namespace JuniorTask.Controllers
{
    [Route("api/[controller]")]
    public class TypesController : Controller
    {
        private readonly TypesManager manager;
        public TypesController(TypesManager typesManager)
        {
            manager = typesManager;
        }

        [HttpGet]
        public IEnumerable<PersonAttribute> Get()
        {
            return manager.FindAll();
        }

        [HttpGet("{id}")]
        public ActionResult<PersonAttribute> Get(string id)
        {
            PersonAttribute attribute = manager.Find(id);
            if (attribute == null)
                return NotFound();
            return new ObjectResult(attribute);
        }

        [HttpPost]
        public ActionResult<PersonAttribute> Post([FromBody]TypeAttributeViewModel attribute)
        {
            if (attribute == null || attribute.PersonId == null)
                return BadRequest();
            return Ok(manager.Create(attribute));
        }

        [HttpPut("{id}")]
        public ActionResult<PersonAttribute> Put([FromBody] TypeAttributeViewModel attribute)
        {
            if (attribute == null || attribute.PersonId == null)
                return BadRequest();
            PersonAttribute personAttribute = manager.Update(attribute);
            if (personAttribute == null)
                return NotFound();
            return Ok(personAttribute);
        }

        [HttpDelete("{id}")]
        public ActionResult<PersonAttribute> Delete(string id)
        {
            PersonAttribute personAttribute = manager.Delete(id);
            if (personAttribute == null)
                return NotFound();
            return Ok(personAttribute);
        }
    }
}
