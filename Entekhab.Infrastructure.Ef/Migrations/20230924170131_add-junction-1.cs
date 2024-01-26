using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entekhab.Infrastructure.EfPersistance.Migrations
{
    /// <inheritdoc />
    public partial class addjunction1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Resid",
                newName: "ResidId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Mojavez",
                newName: "MojavezId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResidId",
                table: "Resid",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MojavezId",
                table: "Mojavez",
                newName: "Id");
        }
    }
}
