using Lesson4App.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lesson4App.Data
{
    public class ProductDBContext:DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options)
            :base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
