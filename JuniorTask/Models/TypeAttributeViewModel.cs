using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JuniorTask.Models
{
    public class TypeAttributeViewModel
    {
        public string AttributeId { get; set; }

        [Required]
        public string PersonId { get; set; }

        [Required]
        public string AttributeName { get; set; }

        [Required]
        public string AttributeValue { get; set; }
        public Person person { get; set; }

    }
}
