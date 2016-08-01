using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MigrationWorkflow
{
    public class Context : DbContext
    {

        public DbSet<Cat> Cats { get; set; }

        public DbSet<Dog> Dogs { get; set; }

        public DbSet<Human> Humans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
