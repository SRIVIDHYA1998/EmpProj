using System;
using EmpProj.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EmpProj.EmpProj2
{
    public class OSContext:DbContext
    {
        public DbSet<Emp> Employee { get; set; }
        public DbSet<Sal> Salary { get; set; }
    }
}