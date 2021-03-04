using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mar4MVC.Models
{
    public class ReleaseMgmtContext : DbContext

    {

        public ReleaseMgmtContext():base("dbCFRM")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LoginDetails> LoginDetails { get; set; }

    }
}