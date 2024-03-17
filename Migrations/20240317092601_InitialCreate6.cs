using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HarmoniBackendAdmin.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TreatmentImageName",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "StaffImageName",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "ProductImageName",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TreatmentImageName",
                table: "Treatments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffImageName",
                table: "Staffs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductImageName",
                table: "Products",
                type: "TEXT",
                nullable: true);
        }
    }
}
