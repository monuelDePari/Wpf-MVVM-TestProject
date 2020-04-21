using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMuzConv.Models
{
    class PersonContext : DbContext
    {
        public PersonContext() : base("DefaultConnection")
        {
            
        }
        public DbSet<Person> Persons { get; set; }
    }
}
