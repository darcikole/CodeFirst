using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class EmployeeDetailsContext : DbContext
    {
        //public EmployeeDetailsContext() : base("DefaultConnection")
        //{

        //}
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }

    } 
}