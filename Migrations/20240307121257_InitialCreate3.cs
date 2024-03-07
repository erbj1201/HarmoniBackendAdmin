using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HarmoniBackendAdmin.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApiKeyReq",
                table: "Treatments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ApiKeyReq",
                table: "Treatments",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
