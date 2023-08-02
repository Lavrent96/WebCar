using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tire_car_model_car_model_id",
                table: "tire");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tire",
                table: "tire");

            migrationBuilder.RenameTable(
                name: "tire",
                newName: "tire_size");

            migrationBuilder.RenameIndex(
                name: "IX_tire_car_model_id",
                table: "tire_size",
                newName: "IX_tire_size_car_model_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tire_size",
                table: "tire_size",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tire_size_car_model_car_model_id",
                table: "tire_size",
                column: "car_model_id",
                principalTable: "car_model",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tire_size_car_model_car_model_id",
                table: "tire_size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tire_size",
                table: "tire_size");

            migrationBuilder.RenameTable(
                name: "tire_size",
                newName: "tire");

            migrationBuilder.RenameIndex(
                name: "IX_tire_size_car_model_id",
                table: "tire",
                newName: "IX_tire_car_model_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tire",
                table: "tire",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tire_car_model_car_model_id",
                table: "tire",
                column: "car_model_id",
                principalTable: "car_model",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
