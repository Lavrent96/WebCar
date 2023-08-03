using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class GetAllTireSizes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"   
        CREATE PROCEDURE GetAllTireSizes
        AS
        BEGIN
            SELECT * FROM tire_size;
        END;  ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        -- Drop Stored Procedures
        DROP PROCEDURE IF EXISTS GetAllTireSizes;");
        }
    }
}
