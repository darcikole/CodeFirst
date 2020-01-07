using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class EmployeeDetails
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }
        public decimal? Salary { get; set; }
        public string Position { get; set; }
    }
}