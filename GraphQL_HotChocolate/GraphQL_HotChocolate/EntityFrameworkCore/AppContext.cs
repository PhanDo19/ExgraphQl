using GraphQL_HotChocolate.Extention;
using GraphQL_HotChocolate.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_HotChocolate.EntityFrameworkCore
{
    public class AppDBContext : DbContext
    {
        public AppDBContext( DbContextOptions<AppDBContext> options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.SeedProduct();
        }
    }
}
