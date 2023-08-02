using Domain.Entities;
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
        public DbSet<Tire> Tires { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
