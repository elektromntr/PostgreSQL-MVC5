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
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Car> Cars { get; set; }
    }
}