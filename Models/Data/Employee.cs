using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCore.Models.Data
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        public Dept Department { get; set; }
    }
}
