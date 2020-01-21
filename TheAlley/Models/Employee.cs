﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheAlley.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30,ErrorMessage ="Name cannot exceed 30 characters!")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage ="Invalid Email Format")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public string PhotoPath { get; set; }

        internal void DeleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
