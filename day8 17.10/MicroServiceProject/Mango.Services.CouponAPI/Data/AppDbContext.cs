using Mango.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { 
        }
        public DbSet<Coupon> Coupons { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coupon>().HasData(new Coupon { CouponId = 90, CouponCode = "12345asd", CouponAmount = 90.0, MinAmount = 99 });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 91,
                CouponCode = "12345assd",
                CouponAmount = 90.0,
                MinAmount = 99,
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 92,
                CouponCode = "12345absd",
                CouponAmount = 91.0,
                MinAmount = 100,
            });
        }



    }
   
}
