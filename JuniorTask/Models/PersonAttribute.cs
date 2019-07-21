using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JuniorTask.Models
{
    public class PersonAttribute
    {
        public string Id { get; set; }
        [Required]
        public string AttributeName { get; set; }
        [Required]
        public string AttributeValue { get; set; }
        [Required]
        public Person Person { get; set; }
    }
}
