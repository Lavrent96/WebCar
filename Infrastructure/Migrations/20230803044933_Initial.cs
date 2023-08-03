using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "car_brand",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    logo_url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car_brand", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "car_model",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    engine_type = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    car_brand_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car_model", x => x.id);
                    table.ForeignKey(
                        name: "FK_car_model_car_brand_car_brand_id",
                        column: x => x.car_brand_id,
                        principalTable: "car_brand",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tire_size",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diameter = table.Column<int>(type: "int", nullable: false),
                    width = table.Column<int>(type: "int", nullable: false),
                    aspect_ratio = table.Column<int>(type: "int", nullable: false),
                    tire_type = table.Column<int>(type: "int", nullable: false),
                    car_model_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tire_size", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tire_size_car_model_car_model_id",
                        column: x => x.car_model_id,
                        principalTable: "car_model",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "car_brand",
                columns: new[] { "id", "description", "logo_url", "name" },
                values: new object[,]
                {
                    { 1, "Luxury car manufacturer", "https://example.com/brand1-logo.png", "Mercedes-Benz" },
                    { 2, "Sporty and performance-focused cars", "https://example.com/brand2-logo.png", "Porsche" },
                    { 3, "German luxury and high-performance vehicles", "https://example.com/brand6-logo.png", "BMW" }
                });

            migrationBuilder.InsertData(
                table: "car_model",
                columns: new[] { "id", "car_brand_id", "description", "engine_type", "name", "price", "year" },
                values: new object[,]
                {
                    { 1, 1, "A stylish and compact car", 6, "Model A", 30000.00m, 2023 },
                    { 2, 1, "Efficient and reliable urban vehicle", 3, "C-Class", 25000.00m, 2023 },
                    { 3, 3, "Luxurious SUV with advanced features", 1, "X5", 60000.00m, 2023 },
                    { 4, 3, "Luxurious SUV with advanced features", 0, "X6", 40000.00m, 2023 },
                    { 5, 2, "High-performance electric sedan", 2, "Model S", 80000.00m, 2023 },
                    { 6, 2, "Legendary sports car", 0, "911", 120000.00m, 2023 },
                    { 7, 1, "Compact luxury SUV", 1, "E-Pace", 40000.00m, 2023 }
                });

            migrationBuilder.InsertData(
                table: "tire_size",
                columns: new[] { "Id", "aspect_ratio", "car_model_id", "diameter", "tire_type", "width" },
                values: new object[,]
                {
                    { 1, 65, 1, 15, 0, 195 },
                    { 2, 60, 1, 16, 0, 205 },
                    { 3, 55, 1, 17, 0, 215 },
                    { 4, 65, 2, 15, 0, 195 },
                    { 5, 60, 2, 16, 0, 205 },
                    { 6, 55, 2, 17, 0, 215 },
                    { 7, 50, 3, 17, 1, 225 },
                    { 8, 45, 3, 18, 1, 235 },
                    { 9, 45, 4, 18, 1, 235 },
                    { 10, 45, 5, 18, 1, 235 },
                    { 11, 45, 6, 18, 1, 235 },
                    { 12, 45, 7, 18, 1, 235 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_car_model_car_brand_id",
                table: "car_model",
                column: "car_brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_tire_size_car_model_id",
                table: "tire_size",
                column: "car_model_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tire_size");

            migrationBuilder.DropTable(
                name: "car_model");

            migrationBuilder.DropTable(
                name: "car_brand");
        }
    }
}
