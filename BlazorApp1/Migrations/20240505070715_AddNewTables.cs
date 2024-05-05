using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "wiek",
                table: "Students",
                newName: "Wiek");

            migrationBuilder.RenameColumn(
                name: "semestr",
                table: "Students",
                newName: "Semestr");

            migrationBuilder.RenameColumn(
                name: "nazwisko",
                table: "Students",
                newName: "Nazwisko");

            migrationBuilder.RenameColumn(
                name: "imie",
                table: "Students",
                newName: "Imie");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Students",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "avatar",
                table: "Students",
                newName: "Avatar");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Students",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Przedmiot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NazwaPrzedmiotu = table.Column<string>(type: "TEXT", nullable: false),
                    OpisPrzedmiotu = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przedmiot", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zapisania",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrzedmiotId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataZapisania = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zapisania", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zapisania_Przedmiot_PrzedmiotId",
                        column: x => x.PrzedmiotId,
                        principalTable: "Przedmiot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zapisania_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocena",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ZapisanieId = table.Column<int>(type: "INTEGER", nullable: false),
                    OcenaCwiczenia = table.Column<decimal>(type: "TEXT", nullable: false),
                    OcenaWyklady = table.Column<decimal>(type: "TEXT", nullable: false),
                    OcenaKoncowa = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocena", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ocena_Zapisania_ZapisanieId",
                        column: x => x.ZapisanieId,
                        principalTable: "Zapisania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ocena_ZapisanieId",
                table: "Ocena",
                column: "ZapisanieId");

            migrationBuilder.CreateIndex(
                name: "IX_Zapisania_PrzedmiotId",
                table: "Zapisania",
                column: "PrzedmiotId");

            migrationBuilder.CreateIndex(
                name: "IX_Zapisania_StudentId",
                table: "Zapisania",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ocena");

            migrationBuilder.DropTable(
                name: "Zapisania");

            migrationBuilder.DropTable(
                name: "Przedmiot");

            migrationBuilder.RenameColumn(
                name: "Wiek",
                table: "Students",
                newName: "wiek");

            migrationBuilder.RenameColumn(
                name: "Semestr",
                table: "Students",
                newName: "semestr");

            migrationBuilder.RenameColumn(
                name: "Nazwisko",
                table: "Students",
                newName: "nazwisko");

            migrationBuilder.RenameColumn(
                name: "Imie",
                table: "Students",
                newName: "imie");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Students",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Avatar",
                table: "Students",
                newName: "avatar");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "id");
        }
    }
}
