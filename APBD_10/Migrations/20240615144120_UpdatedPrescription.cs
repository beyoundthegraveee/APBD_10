using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APBD_10.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPrescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPresctiprion",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 15, 16, 41, 20, 244, DateTimeKind.Local).AddTicks(8700), new DateTime(2024, 7, 15, 16, 41, 20, 244, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPresctiprion",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 15, 16, 41, 20, 244, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 7, 15, 16, 41, 20, 244, DateTimeKind.Local).AddTicks(8747) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PrescriptionMedicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Description", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "Take once daily", 1 },
                    { 2, 2, "Take twice daily", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPresctiprion",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 14, 0, 54, 50, 825, DateTimeKind.Local).AddTicks(5670), new DateTime(2024, 7, 14, 0, 54, 50, 825, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPresctiprion",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 14, 0, 54, 50, 825, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 7, 14, 0, 54, 50, 825, DateTimeKind.Local).AddTicks(5722) });
        }
    }
}
