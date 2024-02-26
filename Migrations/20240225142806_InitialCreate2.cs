using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HarmoniBackendAdmin.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_Bookings_BookingId",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Treatments_BookingId",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Treatments");

            migrationBuilder.AlterColumn<string>(
                name: "StaffImageName",
                table: "Staffs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "TreatmentId",
                table: "Bookings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_TreatmentId",
                table: "Bookings",
                column: "TreatmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Treatments_TreatmentId",
                table: "Bookings",
                column: "TreatmentId",
                principalTable: "Treatments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Treatments_TreatmentId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_TreatmentId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "TreatmentId",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Treatments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "StaffImageName",
                table: "Staffs",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_BookingId",
                table: "Treatments",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_Bookings_BookingId",
                table: "Treatments",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
