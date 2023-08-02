using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "car_brand",
                columns: new[] { "id", "description", "logo_url", "name" },
                values: new object[,]
                {
                    { 1, "Luxury car manufacturer", "https://example.com/brand1-logo.png", "Mercedes-Benz" },
                    { 2, "Sporty and performance-focused cars", "https://example.com/brand2-logo.png", "Porsche" },
                    { 3, "Iconic American automaker", "https://example.com/brand3-logo.png", "Ford" },
                    { 4, "Japanese automobile manufacturer", "https://example.com/brand4-logo.png", "Toyota" },
                    { 5, "Italian luxury sports cars", "https://example.com/brand5-logo.png", "Ferrari" },
                    { 6, "German luxury and high-performance vehicles", "https://example.com/brand6-logo.png", "BMW" },
                    { 7, "Swedish manufacturer known for safety", "https://example.com/brand7-logo.png", "Volvo" },
                    { 8, "American luxury electric vehicles", "https://example.com/brand8-logo.png", "Tesla" },
                    { 9, "Japanese motorcycle manufacturer", "https://example.com/brand9-logo.png", "Honda" },
                    { 10, "British luxury sports cars", "https://example.com/brand10-logo.png", "Aston Martin" }
                });

            migrationBuilder.InsertData(
                table: "car_model",
                columns: new[] { "id", "car_brand_id", "description", "engine_type", "name", "price", "year" },
                values: new object[,]
                {
                    { 1, 1, "A stylish and compact car", 6, "Model A", 30000.00m, 2023 },
                    { 2, 9, "Efficient and reliable urban vehicle", 3, "Civic", 25000.00m, 2023 },
                    { 3, 6, "Luxurious SUV with advanced features", 1, "X5", 60000.00m, 2023 },
                    { 4, 3, "Iconic American muscle car", 0, "Mustang", 40000.00m, 2023 },
                    { 5, 8, "High-performance electric sedan", 2, "Model S", 80000.00m, 2023 },
                    { 6, 2, "Legendary sports car", 0, "911", 120000.00m, 2023 },
                    { 7, 1, "Elegant luxury sedan", 0, "C-Class", 45000.00m, 2023 },
                    { 8, 8, "Affordable electric compact", 2, "Model 3", 35000.00m, 2023 },
                    { 9, 9, "Reliable and spacious family car", 3, "Accord", 28000.00m, 2023 },
                    { 10, 7, "Compact luxury SUV", 1, "E-Pace", 40000.00m, 2023 }
                });

            migrationBuilder.InsertData(
                table: "tire_size",
                columns: new[] { "Id", "aspect_ratio", "car_model_id", "diameter", "tire_type", "width" },
                values: new object[,]
                {
                    { 1, 65, 2, 15, 0, 195 },
                    { 2, 60, 2, 16, 0, 205 },
                    { 3, 55, 2, 17, 0, 215 },
                    { 4, 50, 5, 17, 1, 225 },
                    { 5, 45, 5, 18, 1, 235 },
                    { 6, 40, 5, 19, 1, 245 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "car_brand",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "car_brand",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "car_brand",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "car_model",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "car_model",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "car_model",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "car_model",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "car_model",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "car_model",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "car_model",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "car_model",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "tire_size",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tire_size",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tire_size",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tire_size",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tire_size",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tire_size",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "car_brand",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "car_brand",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "car_brand",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "car_brand",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "car_brand",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "car_model",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "car_model",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "car_brand",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "car_brand",
                keyColumn: "id",
                keyValue: 9);
        }
    }
}
