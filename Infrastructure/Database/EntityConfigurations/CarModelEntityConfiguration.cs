using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.EntityConfigurations
{
    public class CarModelEntityConfiguration : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.ToTable("car_model");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("id");
            builder.Property(c => c.Description).HasColumnName("description");
            builder.Property(c => c.Name).HasColumnName("name");
            builder.Property(c => c.Year).HasColumnName("year");
            builder.Property(c => c.EngineType).HasColumnName("engine_type");
            builder.Property(c => c.Price).HasColumnName("price");
            builder.Property(c => c.CarBrandId).HasColumnName("car_brand_id");

            builder.HasMany(s => s.Tires)
                .WithOne(c => c.CarModel)
                .HasForeignKey(c => c.CarModelId);
        }
    }
}
