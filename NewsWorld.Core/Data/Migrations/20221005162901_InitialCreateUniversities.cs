using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorldNewsApp.Data.Migrations
{
    public partial class InitialCreateUniversities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alpha_Two_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateProvince = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UniversitiesDomains",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniversityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversitiesDomains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UniversitiesDomains_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UniversitiesWebPages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniversityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversitiesWebPages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UniversitiesWebPages_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UniversitiesDomains_UniversityId",
                table: "UniversitiesDomains",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_UniversitiesWebPages_UniversityId",
                table: "UniversitiesWebPages",
                column: "UniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniversitiesDomains");

            migrationBuilder.DropTable(
                name: "UniversitiesWebPages");

            migrationBuilder.DropTable(
                name: "Universities");
        }
    }
}
