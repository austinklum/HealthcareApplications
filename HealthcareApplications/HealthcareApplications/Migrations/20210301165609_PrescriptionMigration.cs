using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthcareApplications.Migrations
{
    public partial class PrescriptionMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Patients_PatientId",
                table: "Prescription");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Prescription",
                newName: "PrescribingPhysicianId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescription_PatientId",
                table: "Prescription",
                newName: "IX_Prescription_PrescribingPhysicianId");

            migrationBuilder.AddColumn<string>(
                name: "Dosage",
                table: "Prescription",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Prescription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PrescribedDrugId",
                table: "Prescription",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrescribedPatientId",
                table: "Prescription",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Prescription",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RefillCount",
                table: "Prescription",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Prescription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Drug",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drug", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_PrescribedDrugId",
                table: "Prescription",
                column: "PrescribedDrugId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_PrescribedPatientId",
                table: "Prescription",
                column: "PrescribedPatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Drug_PrescribedDrugId",
                table: "Prescription",
                column: "PrescribedDrugId",
                principalTable: "Drug",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Patients_PrescribedPatientId",
                table: "Prescription",
                column: "PrescribedPatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Physician_PrescribingPhysicianId",
                table: "Prescription",
                column: "PrescribingPhysicianId",
                principalTable: "Physician",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Drug_PrescribedDrugId",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Patients_PrescribedPatientId",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Physician_PrescribingPhysicianId",
                table: "Prescription");

            migrationBuilder.DropTable(
                name: "Drug");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_PrescribedDrugId",
                table: "Prescription");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_PrescribedPatientId",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "Dosage",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "PrescribedDrugId",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "PrescribedPatientId",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "RefillCount",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Prescription");

            migrationBuilder.RenameColumn(
                name: "PrescribingPhysicianId",
                table: "Prescription",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescription_PrescribingPhysicianId",
                table: "Prescription",
                newName: "IX_Prescription_PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Patients_PatientId",
                table: "Prescription",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
