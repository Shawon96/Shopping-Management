using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Shopping_store.Models
{
    public class StoreContext : IdentityDbContext<User>
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CountCarsForUser> Counts { get; set; }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Jaguar F-Type",
                    PriceDollars = 100000,
                    UrlImage = "https://quto.ru/service-imgs/5d/e6/28/65/5de6286523f50.jpeg",
                    Description = "Легендарный Jaguar с двигателем V12."
                },
                new Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Aston Martin DBX I",
                    PriceDollars = 300000,
                    UrlImage = "https://quto.ru/service-imgs/5d/d5/0f/e0/5dd50fe07ca1b.jpeg",
                    Description = "Элегантный и мощный кроссовер Aston Martin."
                }
            );
        }
    }
}
