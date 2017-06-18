using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ModelDemo.Models;

namespace ModelDemo.DbContext
{
    public class DemoModelDbContext : System.Data.Entity.DbContext
    {
        public DemoModelDbContext():base("DbConnection")
        {
            
        }
        public DbSet<ChangeProject> ChangeProjects { get; set; }
        public DbSet<Catagory> Catagorys { get; set; }
        public DbSet<Affect> Affects { get; set; }
    }
}