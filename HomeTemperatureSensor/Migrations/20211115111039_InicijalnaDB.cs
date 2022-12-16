using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeTemperatureSensor.Migrations
{
    public partial class InicijalnaDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sobe",
                columns: table => new
                {
                    SobaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivSobe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sobe", x => x.SobaID);
                });

            migrationBuilder.CreateTable(
                name: "podaci",
                columns: table => new
                {
                    RedniBrojID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemperaturaCelzijusa = table.Column<float>(nullable: false),
                    TemperaturaFarenhajta = table.Column<float>(nullable: false),
                    SobaID = table.Column<int>(nullable: false),
                    Vrijeme = table.Column<DateTime>(nullable: false),
                    StatusAlarma = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_podaci", x => x.RedniBrojID);
                    table.ForeignKey(
                        name: "FK_podaci_sobe_SobaID",
                        column: x => x.SobaID,
                        principalTable: "sobe",
                        principalColumn: "SobaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_podaci_SobaID",
                table: "podaci",
                column: "SobaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "podaci");

            migrationBuilder.DropTable(
                name: "sobe");
        }
    }
}
