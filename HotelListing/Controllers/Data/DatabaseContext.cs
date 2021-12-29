using HotelListing.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Controllers.Data
{
    public class DatabaseContext:IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options):base (options)
        { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Angola",
                    ShortName = "AO"
                }, 
                new Country
                {
                    Id = 2,
                    Name = "South Africa",
                    ShortName = "SA"
                }, new Country
                {
                    Id = 3,
                    Name = "United States of America",
                    ShortName = "USA"
                }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Terminus",
                    Address = "Lobito",
                    CountryId = 1,
                    Rating = 4.6F
                }, 
                new Hotel
                {
                    Id = 2,
                    Name = "SA Hotel",
                    Address = "Cape Town",
                    CountryId = 2,
                    Rating = 4.8F
                }, 
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Live Hotel",
                    Address = "New York",
                    CountryId = 3,
                    Rating = 5F
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Hotel Chick Chick",
                    Address = "Lobito",
                    CountryId = 1,
                    Rating = 4.2F
                }
                );
        }
    }
}
