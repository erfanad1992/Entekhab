using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entekhab.Infrastructure.EfPersistance.Migrations
{
    /// <inheritdoc />
    public partial class add7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrackingCode",
                table: "Resid",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrackingCode",
                table: "Mojavez",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrackingCode",
                table: "Resid");

            migrationBuilder.DropColumn(
                name: "TrackingCode",
                table: "Mojavez");
        }
    }
}
