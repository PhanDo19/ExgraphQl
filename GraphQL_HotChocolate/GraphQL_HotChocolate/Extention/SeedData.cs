using GraphQL_HotChocolate.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_HotChocolate.Extention
{
    public static class SeedData
    {
        public static void SeedProduct(this ModelBuilder modelBuilder)
        {
            var newList = new List<Product>() {
                    new Product{Id= 1, Name="Hoa",Category="Hoa",Description ="Hoa de ban"},
                    new Product{Id= 2, Name="Banh",Category="Banh",Description ="Hoa de ban"},
                    new Product{Id= 3, Name="Keo",Category="keo",Description ="Hoa de ban"}
                };
            modelBuilder.Entity<Product>().HasData(newList);

        }
    }
}
