using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HarmoniBackendAdmin.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApiKeyReq",
                table: "Bookings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ApiKeyReq",
                table: "Bookings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
