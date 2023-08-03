using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class GetAllCarModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
          CREATE PROCEDURE GetAllCarModels
        AS
        BEGIN
            SELECT * FROM car_model;
        END;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        -- Drop Stored Procedures
        DROP PROCEDURE IF EXISTS GetAllCarModels;");
        }
    }
}
