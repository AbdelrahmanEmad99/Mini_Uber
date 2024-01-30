using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mini_Uber.Migrations
{
    /// <inheritdoc />
    public partial class aadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "kiloMeters",
                table: "Destinatons",
                newName: "KiloMeters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KiloMeters",
                table: "Destinatons",
                newName: "kiloMeters");
        }
    }
}
