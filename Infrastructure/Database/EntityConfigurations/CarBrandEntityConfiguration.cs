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
    public class CarBrandEntityConfiguration : IEntityTypeConfiguration<CarBrand>
    {
        public void Configure(EntityTypeBuilder<CarBrand> builder)
        {
            builder.ToTable("car_brand");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("id");
            builder.Property(c => c.Name).HasColumnName("name");
            builder.Property(c => c.Description).HasColumnName("description");
            builder.Property(c => c.LogoUrl).HasColumnName("logo_url");

            builder.HasMany(c => c.Models)
                .WithOne(c => c.CarBrand)
                .HasForeignKey(c => c.CarBrandId);
        }
    }
}
