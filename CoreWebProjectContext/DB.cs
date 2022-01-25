using CoreWebProjectEntities;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;


namespace CoreWebProjectContext
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options)
        {
        }

        protected DB()
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
