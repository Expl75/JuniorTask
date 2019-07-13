using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JuniorTask.Models
{
    public class Person
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Please enter a first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter an age")]
        public string Age { get; set; }
        public Address HomeAddress { get; set; }
    }
}
