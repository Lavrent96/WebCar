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
                    Description = "German luxury and high-performance vehicles",
                    LogoUrl = "https://example.com/brand6-logo.png",
                    Name = "BMW",
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
                    Name = "C-Class",
                    EngineType = EngineType.Hybrid,
                    Price = 25000.00M,
                    Year = 2023,
                    Description = "Efficient and reliable urban vehicle",
                    CarBrandId = 1,
                },
                new CarModel
                {
                    Id = 3,
                    Name = "X5",
                    EngineType = EngineType.Diesel,
                    Price = 60000.00M,
                    Year = 2023,
                    Description = "Luxurious SUV with advanced features",
                    CarBrandId = 3,
                },
                new CarModel
                {
                    Id = 4,
                    Name = "X6",
                    EngineType = EngineType.Gasoline,
                    Price = 40000.00M,
                    Year = 2023,
                    Description = "Luxurious SUV with advanced features",
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
                    CarBrandId = 2,
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
                    Name = "E-Pace",
                    EngineType = EngineType.Diesel,
                    Price = 40000.00M,
                    Year = 2023,
                    Description = "Compact luxury SUV",
                    CarBrandId = 1,
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
                             CarModelId = 1,
                         },
                         new TireSize
                         {
                             Id = 2,
                             Diameter = 16,
                             Width = 205,
                             AspectRatio = 60,
                             TireType = TireType.AllSeason,
                             CarModelId = 1,
                         },
                         new TireSize
                         {
                             Id = 3,
                             Diameter = 17,
                             Width = 215,
                             AspectRatio = 55,
                             TireType = TireType.AllSeason,
                             CarModelId = 1,
                         },
                          new TireSize
                          {
                              Id = 4,
                              Diameter = 15,
                              Width = 195,
                              AspectRatio = 65,
                              TireType = TireType.AllSeason,
                              CarModelId = 2,
                          },
                         new TireSize
                         {
                             Id = 5,
                             Diameter = 16,
                             Width = 205,
                             AspectRatio = 60,
                             TireType = TireType.AllSeason,
                             CarModelId = 2,
                         },
                         new TireSize
                         {
                             Id = 6,
                             Diameter = 17,
                             Width = 215,
                             AspectRatio = 55,
                             TireType = TireType.AllSeason,
                             CarModelId = 2,
                         },
                         new TireSize
                         {
                             Id = 7,
                             Diameter = 17,
                             Width = 225,
                             AspectRatio = 50,
                             TireType = TireType.Summer,
                             CarModelId = 3,
                         },
                         new TireSize
                         {
                             Id = 8,
                             Diameter = 18,
                             Width = 235,
                             AspectRatio = 45,
                             TireType = TireType.Summer,
                             CarModelId = 3,
                         },
                         new TireSize
                         {
                             Id = 9,
                             Diameter = 18,
                             Width = 235,
                             AspectRatio = 45,
                             TireType = TireType.Summer,
                             CarModelId = 4,
                         },
                         new TireSize
                         {
                             Id = 10,
                             Diameter = 18,
                             Width = 235,
                             AspectRatio = 45,
                             TireType = TireType.Summer,
                             CarModelId =5,
                         },
                         new TireSize
                         {
                             Id = 11,
                             Diameter = 18,
                             Width = 235,
                             AspectRatio = 45,
                             TireType = TireType.Summer,
                             CarModelId =6,
                         },
                         new TireSize
                         {
                             Id = 12,
                             Diameter = 18,
                             Width = 235,
                             AspectRatio = 45,
                             TireType = TireType.Summer,
                             CarModelId =7,
                         });

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
