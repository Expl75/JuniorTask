using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuniorTask.Models;

namespace JuniorTask.DataBase
{
    public class TypesManager
    {
        private readonly IRepository<PersonAttribute> attributeRepository;
        private readonly IRepository<Person> personRepository;
        public TypesManager(IRepository<PersonAttribute> attrRepository, IRepository<Person> perRepository)
        {
            attributeRepository = attrRepository;
            personRepository = perRepository;
        }

        public PersonAttribute Create(TypeAttributeViewModel attribute)
        {
            Person person = personRepository.Find(attribute.PersonId);
            PersonAttribute personAttribute = new PersonAttribute
            {
                AttributeName = attribute.AttributeName,
                AttributeValue = attribute.AttributeValue,
                Id = attribute.AttributeId,
                Person = person
            };
            attributeRepository.Create(personAttribute);
            attributeRepository.Save();
            return personAttribute;
        }

        public PersonAttribute Update(TypeAttributeViewModel attribute)
        {
            PersonAttribute findAttibute = attributeRepository.Find(attribute.AttributeId);
            if (findAttibute == null)
                return findAttibute;
            Person person = personRepository.Find(attribute.PersonId);
            PersonAttribute personAttribute= new PersonAttribute
            {
                AttributeName = attribute.AttributeName,
                AttributeValue = attribute.AttributeValue,
                Id = attribute.AttributeId,
                Person = person
            };
            attributeRepository.Update(personAttribute);
            attributeRepository.Save();
            return personAttribute;
        }

        public IEnumerable<PersonAttribute> FindAll()
        {
            return attributeRepository.FindAll();
        }

        public PersonAttribute Delete(string id)
        {
            PersonAttribute personAttribute = attributeRepository.Find(id);
            if(personAttribute != null)
            {
                attributeRepository.Delete(id);
                attributeRepository.Save();
            }
            return personAttribute;
        }

        public PersonAttribute Find(string id)
        {
            PersonAttribute attribute = attributeRepository.Find(id);
            return attribute;
        }
    }
}
