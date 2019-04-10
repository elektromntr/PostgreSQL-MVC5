using System;
using System.Data.Entity;

namespace PostgresTest.Models
{
    public class MyContext : DbContext
    {
        public MyContext() : base(nameOrConnectionString: "Default") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<Car>().Property(b => b._Tags).HasColumnName("Tag");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Car> Cars { get; set; }
    }
}