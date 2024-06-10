using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NqnLesson08CF.Models
{
    public class NqnBookStore:DbContext
    {
        public NqnBookStore():base ("NqnBookStoreConnectionString") 
        {
        
        }
        // tao cac bang
        public DbSet<NqnCategory> NqnCategories { get; set; }
        public DbSet<Nqnbook> NqnBooks { get; set; }
    }
}