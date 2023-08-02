using Domain.Entities;
using Domain.Enums;
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
    public class TireEntityConfiguration : IEntityTypeConfiguration<Tire>
    {
        public void Configure(EntityTypeBuilder<Tire> builder)
        {
            builder.ToTable("tire");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Diameter).HasColumnName("diameter");
            builder.Property(c => c.Width).HasColumnName("width");
            builder.Property(c => c.AspectRatio).HasColumnName("aspect_ratio");
            builder.Property(c => c.TireType).HasColumnName("tire_type");
            builder.Property(c => c.CarModelId).HasColumnName("car_model_id");
        }
    }
}
