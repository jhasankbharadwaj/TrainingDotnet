using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<Product> products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
               new Product
                {
                    ProductId = 1,
                    Price = 789,
                    Description = "nothing",
                    CategoryName = "toy",
                    ImageUrl = "xyd.com",
                    ImageLocalPath = null,

                });
            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  ProductId = 1,
                  Price = 789,
                  Description = "nothing",
                  CategoryName = "toy",
                  ImageUrl = "xyd.com",
                  ImageLocalPath = null,

              });
        }
    }
}
