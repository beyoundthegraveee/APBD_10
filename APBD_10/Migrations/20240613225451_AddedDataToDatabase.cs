﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APBD_10.Migrations
{
    /// <inheritdoc />
    public partial class AddedDataToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John", "Doe" },
                    { 2, "jane.smith@example.com", "Jane", "Smith" }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "MedicamentDescription", "MedicamentName", "Type" },
                values: new object[,]
                {
                    { 1, "DescriptionA", "MedicamentA", "TypeA" },
                    { 2, "DescriptionB", "MedicamentB", "TypeB" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", "Johnson" },
                    { 2, new DateTime(1990, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob", "Williams" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPresctiprion", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 14, 0, 54, 50, 825, DateTimeKind.Local).AddTicks(5670), new DateTime(2024, 7, 14, 0, 54, 50, 825, DateTimeKind.Local).AddTicks(5714), 1, 1 },
                    { 2, new DateTime(2024, 6, 14, 0, 54, 50, 825, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 7, 14, 0, 54, 50, 825, DateTimeKind.Local).AddTicks(5722), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "PrescriptionMedicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Description", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "Take once daily", 1 },
                    { 2, 2, "Take twice daily", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPresctiprion",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPresctiprion",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2);
        }
    }
}