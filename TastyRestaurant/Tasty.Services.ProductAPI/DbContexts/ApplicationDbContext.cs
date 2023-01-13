using Microsoft.EntityFrameworkCore;
using Tasty.Services.ProductAPI.Models;

namespace Tasty.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

    }
}
