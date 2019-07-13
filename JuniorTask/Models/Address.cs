using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JuniorTask.Models
{
    public class Address
    {
        [Required]
        public string Line1 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        public string Id { get; set; }
    }
}
