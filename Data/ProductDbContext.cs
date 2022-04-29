using System.Data.Entity;

namespace webapi_core_project.Data
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}