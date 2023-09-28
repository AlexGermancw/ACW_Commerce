using Catalog.Domain;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Persistence.Database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(
            DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInStock> Stocks { get; set; }
    }
}
