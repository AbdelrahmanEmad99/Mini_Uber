using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mini_Uber.Migrations
{
    /// <inheritdoc />
    public partial class AddingBalanceInuserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MoneyInCreditCard",
                table: "Users",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MoneyInPayPal",
                table: "Users",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoneyInCreditCard",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MoneyInPayPal",
                table: "Users");
        }
    }
}
