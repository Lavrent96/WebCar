using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BuildSP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        -- Stored Procedure for GetCarModelWithDetails
        CREATE PROCEDURE GetCarModelWithDetails
        @Id INT
        AS
        BEGIN
            SELECT cm.*, cb.id AS brand_id, cb.name AS brand_name, cb.description AS brand_description, cb.logo_url AS brand_logo_url,
                   ts.id AS tire_id, ts.diameter, ts.width, ts.aspect_ratio, ts.tire_type
            FROM car_Model cm
            INNER JOIN car_brand cb ON cm.car_brand_id = cb.id
            LEFT JOIN tire_size ts ON cm.id = ts.car_model_id
            WHERE cm.id = @Id;
        END;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        -- Drop Stored Procedures
        DROP PROCEDURE IF EXISTS GetCarModelWithDetails;");
        }
    }
}
