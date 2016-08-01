using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace MigrationWorkflow
{
    public class Context : DbContext
    {

        public DbSet<Cat> Cats { get; set; }

        public DbSet<Dog> Dogs { get; set; }

        public DbSet<Human> Humans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
