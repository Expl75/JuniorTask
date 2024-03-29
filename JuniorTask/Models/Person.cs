﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JuniorTask.Models
{
    public class Person
    {
        public string Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public Address HomeAddress { get; set; }
    }
}
