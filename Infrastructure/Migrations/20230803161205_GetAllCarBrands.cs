using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class GetAllCarBrands : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        CREATE PROCEDURE GetAllCarBrands
        AS
        BEGIN
            SELECT * FROM car_brand;
        END;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        -- Drop Stored Procedures
        DROP PROCEDURE IF EXISTS GetAllCarBrands;");
        }
    }
}
