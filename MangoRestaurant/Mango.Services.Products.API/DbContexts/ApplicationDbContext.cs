using Mango.Services.Products.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.Products.API.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
 