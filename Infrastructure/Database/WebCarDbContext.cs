using Domain.Entities;
using Domain.Enums;
using Infrastructure.Database.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database
{
    public class WebCarDbContext : DbContext
    {
        public WebCarDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<TireSize> Tires { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CarBrand>().HasData(
                new CarBrand
                {
                    Id = 1,
                    Description = "Luxury car manufacturer",
                    LogoUrl = "https://example.com/brand1-logo.png",
                    Name = "Mercedes-Benz",
                },
                new CarBrand
                {
                    Id = 2,
                    Description = "Sporty and performance-focused cars",
                    LogoUrl = "https://example.com/brand2-logo.png",
                    Name = "Porsche",
                },
                new CarBrand
                {
                    Id = 3,
                    Description = "Iconic American automaker",
                    LogoUrl = "https://example.com/brand3-logo.png",
                    Name = "Ford",
                },
                new CarBrand
                {
                    Id = 4,
                    Description = "Japanese automobile manufacturer",
                    LogoUrl = "https://example.com/brand4-logo.png",
                    Name = "Toyota",
                },
                new CarBrand
                {
                    Id = 5,
                    Description = "Italian luxury sports cars",
                    LogoUrl = "https://example.com/brand5-logo.png",
                    Name = "Ferrari",
                },
                new CarBrand
                {
                    Id = 6,
                    Description = "German luxury and high-performance vehicles",
                    LogoUrl = "https://example.com/brand6-logo.png",
                    Name = "BMW",
                },
                new CarBrand
                {
                    Id = 7,
                    Description = "Swedish manufacturer known for safety",
                    LogoUrl = "https://example.com/brand7-logo.png",
                    Name = "Volvo",
                },
                new CarBrand
                {
                    Id = 8,
                    Description = "American luxury electric vehicles",
                    LogoUrl = "https://example.com/brand8-logo.png",
                    Name = "Tesla",
                },
                new CarBrand
                {
                    Id = 9,
                    Description = "Japanese motorcycle manufacturer",
                    LogoUrl = "https://example.com/brand9-logo.png",
                    Name = "Honda",
                },
                new CarBrand
                {
                    Id = 10,
                    Description = "British luxury sports cars",
                    LogoUrl = "https://example.com/brand10-logo.png",
                    Name = "Aston Martin",
                }
            );

            modelBuilder.Entity<CarModel>().HasData(
                new CarModel
                {
                    Id = 1,
                    Name = "Model A",
                    EngineType = EngineType.Propane,
                    Price = 30000.00M,
                    Year = 2023,
                    Description = "A stylish and compact car",
                    CarBrandId = 1,
                },
                new CarModel
                {
                    Id = 2,
                    Name = "Civic",
                    EngineType = EngineType.Hybrid,
                    Price = 25000.00M,
                    Year = 2023,
                    Description = "Efficient and reliable urban vehicle",
                    CarBrandId = 9,
                },
                new CarModel
                {
                    Id = 3,
                    Name = "X5",
                    EngineType = EngineType.Diesel,
                    Price = 60000.00M,
                    Year = 2023,
                    Description = "Luxurious SUV with advanced features",
                    CarBrandId = 6,
                },
                new CarModel
                {
                    Id = 4,
                    Name = "Mustang",
                    EngineType = EngineType.Gasoline,
                    Price = 40000.00M,
                    Year = 2023,
                    Description = "Iconic American muscle car",
                    CarBrandId = 3,
                },
                new CarModel
                {
                    Id = 5,
                    Name = "Model S",
                    EngineType = EngineType.Electric,
                    Price = 80000.00M,
                    Year = 2023,
                    Description = "High-performance electric sedan",
                    CarBrandId = 8,
                },
                new CarModel
                {
                    Id = 6,
                    Name = "911",
                    EngineType = EngineType.Gasoline,
                    Price = 120000.00M,
                    Year = 2023,
                    Description = "Legendary sports car",
                    CarBrandId = 2,
                },
                new CarModel
                {
                    Id = 7,
                    Name = "C-Class",
                    EngineType = EngineType.Gasoline,
                    Price = 45000.00M,
                    Year = 2023,
                    Description = "Elegant luxury sedan",
                    CarBrandId = 1,
                },
                new CarModel
                {
                    Id = 8,
                    Name = "Model 3",
                    EngineType = EngineType.Electric,
                    Price = 35000.00M,
                    Year = 2023,
                    Description = "Affordable electric compact",
                    CarBrandId = 8,
                },
                new CarModel
                {
                    Id = 9,
                    Name = "Accord",
                    EngineType = EngineType.Hybrid,
                    Price = 28000.00M,
                    Year = 2023,
                    Description = "Reliable and spacious family car",
                    CarBrandId = 9,
                },
                new CarModel
                {
                    Id = 10,
                    Name = "E-Pace",
                    EngineType = EngineType.Diesel,
                    Price = 40000.00M,
                    Year = 2023,
                    Description = "Compact luxury SUV",
                    CarBrandId = 7,
                }
            );

            modelBuilder.Entity<TireSize>().HasData(
                         // Example 1: CarModel gives the result 15, 16, 17
                         new TireSize
                         {
                             Id = 1,
                             Diameter = 15,
                             Width = 195,
                             AspectRatio = 65,
                             TireType = TireType.AllSeason,
                             CarModelId = 2,
                         },
                         new TireSize
                         {
                             Id = 2,
                             Diameter = 16,
                             Width = 205,
                             AspectRatio = 60,
                             TireType = TireType.AllSeason,
                             CarModelId = 2,
                         },
                         new TireSize
                         {
                             Id = 3,
                             Diameter = 17,
                             Width = 215,
                             AspectRatio = 55,
                             TireType = TireType.AllSeason,
                             CarModelId = 2,
                         },
                         // Example 2: CarModel gives the result 17, 18, 19
                         new TireSize
                         {
                             Id = 4,
                             Diameter = 17,
                             Width = 225,
                             AspectRatio = 50,
                             TireType = TireType.Summer,
                             CarModelId = 5,
                         },
                         new TireSize
                         {
                             Id = 5,
                             Diameter = 18,
                             Width = 235,
                             AspectRatio = 45,
                             TireType = TireType.Summer,
                             CarModelId = 5,
                         },
                         new TireSize
                         {
                             Id = 6,
                             Diameter = 19,
                             Width = 245,
                             AspectRatio = 40,
                             TireType = TireType.Summer,
                             CarModelId = 5,
                         }
                            );

            modelBuilder.ApplyConfiguration(new CarBrandEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CarModelEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TireEntityConfiguration());
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        if (entry.OriginalValues.Properties.Any(p => p.Name == "created_on"))
                        {
                            entry.Property("created_on").CurrentValue = DateTime.UtcNow;
                        }
                        break;
                    case EntityState.Modified:
                        if (entry.OriginalValues.Properties.Any(p => p.Name == "updated_on"))
                        {
                            entry.Property("updated_on").CurrentValue = DateTime.UtcNow;
                        }
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
