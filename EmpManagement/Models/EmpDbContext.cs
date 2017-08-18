using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmpManagement.Models
{
    public class EmpDbContext:DbContext
    {
        public EmpDbContext():base("EmpContext")
        {

        }

      public  DbSet<Employee> Employees { get; set; }
    }
}