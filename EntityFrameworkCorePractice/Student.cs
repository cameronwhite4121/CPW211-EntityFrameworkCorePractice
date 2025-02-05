﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCorePractice
{
    public class Student
    {
        [Key] // Tell EF Core to make this a primary key (PK)
        public int Id { get; set; }

        public string? FullName {  get; set; }

        public DateOnly DateOfBirth {  get; set; }

        public string Email { get; set; }
    }
}
