using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VatClinic.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ailments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Symtoms = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ailments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Doses = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<int>(maxLength: 20, nullable: false),
                    ClinicNo = table.Column<string>(maxLength: 10, nullable: false),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resolves",
                columns: table => new
                {
                    AilmentId = table.Column<long>(nullable: false),
                    MedicationId = table.Column<long>(nullable: false),
                    AilmentId1 = table.Column<int>(nullable: true),
                    MedicationId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resolves", x => new { x.MedicationId, x.AilmentId });
                    table.ForeignKey(
                        name: "FK_Resolves_Ailments_AilmentId1",
                        column: x => x.AilmentId1,
                        principalTable: "Ailments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resolves_Medications_MedicationId1",
                        column: x => x.MedicationId1,
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    PatientId = table.Column<long>(nullable: false),
                    AilmentId = table.Column<long>(nullable: false),
                    PatientId1 = table.Column<int>(nullable: true),
                    AilmentId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => new { x.PatientId, x.AilmentId });
                    table.ForeignKey(
                        name: "FK_Contracts_Ailments_AilmentId1",
                        column: x => x.AilmentId1,
                        principalTable: "Ailments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_Patients_PatientId1",
                        column: x => x.PatientId1,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Administers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContractPatientId = table.Column<long>(nullable: true),
                    ContractAilmentId = table.Column<long>(nullable: true),
                    ResolveMedicationId = table.Column<long>(nullable: true),
                    ResolveAilmentId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administers_Contracts_ContractPatientId_ContractAilmentId",
                        columns: x => new { x.ContractPatientId, x.ContractAilmentId },
                        principalTable: "Contracts",
                        principalColumns: new[] { "PatientId", "AilmentId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Administers_Resolves_ResolveMedicationId_ResolveAilmentId",
                        columns: x => new { x.ResolveMedicationId, x.ResolveAilmentId },
                        principalTable: "Resolves",
                        principalColumns: new[] { "MedicationId", "AilmentId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administers_ContractPatientId_ContractAilmentId",
                table: "Administers",
                columns: new[] { "ContractPatientId", "ContractAilmentId" });

            migrationBuilder.CreateIndex(
                name: "IX_Administers_ResolveMedicationId_ResolveAilmentId",
                table: "Administers",
                columns: new[] { "ResolveMedicationId", "ResolveAilmentId" });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_AilmentId1",
                table: "Contracts",
                column: "AilmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_PatientId1",
                table: "Contracts",
                column: "PatientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Resolves_AilmentId1",
                table: "Resolves",
                column: "AilmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Resolves_MedicationId1",
                table: "Resolves",
                column: "MedicationId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administers");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Resolves");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Ailments");

            migrationBuilder.DropTable(
                name: "Medications");
        }
    }
}
