using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProductCrudAssignment.Models
{
    public partial class ProductCategoryDbContext : DbContext
    {
        public ProductCategoryDbContext()
            : base("name=ProductCategoryDbContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
