﻿// <auto-generated />
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(WebCarDbContext))]
    [Migration("20230803161205_GetAllCarBrands")]
    partial class GetAllCarBrands
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.CarBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("logo_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("car_brand", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Luxury car manufacturer",
                            LogoUrl = "https://example.com/brand1-logo.png",
                            Name = "Mercedes-Benz"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Sporty and performance-focused cars",
                            LogoUrl = "https://example.com/brand2-logo.png",
                            Name = "Porsche"
                        },
                        new
                        {
                            Id = 3,
                            Description = "German luxury and high-performance vehicles",
                            LogoUrl = "https://example.com/brand6-logo.png",
                            Name = "BMW"
                        });
                });

            modelBuilder.Entity("Domain.Entities.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarBrandId")
                        .HasColumnType("int")
                        .HasColumnName("car_brand_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("EngineType")
                        .HasColumnType("int")
                        .HasColumnName("engine_type");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("price");

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.HasIndex("CarBrandId");

                    b.ToTable("car_model", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarBrandId = 1,
                            Description = "A stylish and compact car",
                            EngineType = 6,
                            Name = "Model A",
                            Price = 30000.00m,
                            Year = 2023
                        },
                        new
                        {
                            Id = 2,
                            CarBrandId = 1,
                            Description = "Efficient and reliable urban vehicle",
                            EngineType = 3,
                            Name = "C-Class",
                            Price = 25000.00m,
                            Year = 2023
                        },
                        new
                        {
                            Id = 3,
                            CarBrandId = 3,
                            Description = "Luxurious SUV with advanced features",
                            EngineType = 1,
                            Name = "X5",
                            Price = 60000.00m,
                            Year = 2023
                        },
                        new
                        {
                            Id = 4,
                            CarBrandId = 3,
                            Description = "Luxurious SUV with advanced features",
                            EngineType = 0,
                            Name = "X6",
                            Price = 40000.00m,
                            Year = 2023
                        },
                        new
                        {
                            Id = 5,
                            CarBrandId = 2,
                            Description = "High-performance electric sedan",
                            EngineType = 2,
                            Name = "Model S",
                            Price = 80000.00m,
                            Year = 2023
                        },
                        new
                        {
                            Id = 6,
                            CarBrandId = 2,
                            Description = "Legendary sports car",
                            EngineType = 0,
                            Name = "911",
                            Price = 120000.00m,
                            Year = 2023
                        },
                        new
                        {
                            Id = 7,
                            CarBrandId = 1,
                            Description = "Compact luxury SUV",
                            EngineType = 1,
                            Name = "E-Pace",
                            Price = 40000.00m,
                            Year = 2023
                        });
                });

            modelBuilder.Entity("Domain.Entities.TireSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AspectRatio")
                        .HasColumnType("int")
                        .HasColumnName("aspect_ratio");

                    b.Property<int>("CarModelId")
                        .HasColumnType("int")
                        .HasColumnName("car_model_id");

                    b.Property<int>("Diameter")
                        .HasColumnType("int")
                        .HasColumnName("diameter");

                    b.Property<int>("TireType")
                        .HasColumnType("int")
                        .HasColumnName("tire_type");

                    b.Property<int>("Width")
                        .HasColumnType("int")
                        .HasColumnName("width");

                    b.HasKey("Id");

                    b.HasIndex("CarModelId");

                    b.ToTable("tire_size", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AspectRatio = 65,
                            CarModelId = 1,
                            Diameter = 15,
                            TireType = 0,
                            Width = 195
                        },
                        new
                        {
                            Id = 2,
                            AspectRatio = 60,
                            CarModelId = 1,
                            Diameter = 16,
                            TireType = 0,
                            Width = 205
                        },
                        new
                        {
                            Id = 3,
                            AspectRatio = 55,
                            CarModelId = 1,
                            Diameter = 17,
                            TireType = 0,
                            Width = 215
                        },
                        new
                        {
                            Id = 4,
                            AspectRatio = 65,
                            CarModelId = 2,
                            Diameter = 15,
                            TireType = 0,
                            Width = 195
                        },
                        new
                        {
                            Id = 5,
                            AspectRatio = 60,
                            CarModelId = 2,
                            Diameter = 16,
                            TireType = 0,
                            Width = 205
                        },
                        new
                        {
                            Id = 6,
                            AspectRatio = 55,
                            CarModelId = 2,
                            Diameter = 17,
                            TireType = 0,
                            Width = 215
                        },
                        new
                        {
                            Id = 7,
                            AspectRatio = 50,
                            CarModelId = 3,
                            Diameter = 17,
                            TireType = 1,
                            Width = 225
                        },
                        new
                        {
                            Id = 8,
                            AspectRatio = 45,
                            CarModelId = 3,
                            Diameter = 18,
                            TireType = 1,
                            Width = 235
                        },
                        new
                        {
                            Id = 9,
                            AspectRatio = 45,
                            CarModelId = 4,
                            Diameter = 18,
                            TireType = 1,
                            Width = 235
                        },
                        new
                        {
                            Id = 10,
                            AspectRatio = 45,
                            CarModelId = 5,
                            Diameter = 18,
                            TireType = 1,
                            Width = 235
                        },
                        new
                        {
                            Id = 11,
                            AspectRatio = 45,
                            CarModelId = 6,
                            Diameter = 18,
                            TireType = 1,
                            Width = 235
                        },
                        new
                        {
                            Id = 12,
                            AspectRatio = 45,
                            CarModelId = 7,
                            Diameter = 18,
                            TireType = 1,
                            Width = 235
                        });
                });

            modelBuilder.Entity("Domain.Entities.CarModel", b =>
                {
                    b.HasOne("Domain.Entities.CarBrand", "CarBrand")
                        .WithMany("Models")
                        .HasForeignKey("CarBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarBrand");
                });

            modelBuilder.Entity("Domain.Entities.TireSize", b =>
                {
                    b.HasOne("Domain.Entities.CarModel", "CarModel")
                        .WithMany("Tires")
                        .HasForeignKey("CarModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarModel");
                });

            modelBuilder.Entity("Domain.Entities.CarBrand", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Domain.Entities.CarModel", b =>
                {
                    b.Navigation("Tires");
                });
#pragma warning restore 612, 618
        }
    }
}
