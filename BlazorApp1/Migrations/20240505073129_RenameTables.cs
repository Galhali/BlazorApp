using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class RenameTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocena_Zapisania_ZapisanieId",
                table: "Ocena");

            migrationBuilder.DropForeignKey(
                name: "FK_Zapisania_Przedmiot_PrzedmiotId",
                table: "Zapisania");

            migrationBuilder.DropForeignKey(
                name: "FK_Zapisania_Students_StudentId",
                table: "Zapisania");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Przedmiot",
                table: "Przedmiot");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ocena",
                table: "Ocena");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Studenci");

            migrationBuilder.RenameTable(
                name: "Przedmiot",
                newName: "Przedmioty");

            migrationBuilder.RenameTable(
                name: "Ocena",
                newName: "Oceny");

            migrationBuilder.RenameIndex(
                name: "IX_Ocena_ZapisanieId",
                table: "Oceny",
                newName: "IX_Oceny_ZapisanieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studenci",
                table: "Studenci",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Przedmioty",
                table: "Przedmioty",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Oceny",
                table: "Oceny",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Oceny_Zapisania_ZapisanieId",
                table: "Oceny",
                column: "ZapisanieId",
                principalTable: "Zapisania",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zapisania_Przedmioty_PrzedmiotId",
                table: "Zapisania",
                column: "PrzedmiotId",
                principalTable: "Przedmioty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zapisania_Studenci_StudentId",
                table: "Zapisania",
                column: "StudentId",
                principalTable: "Studenci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oceny_Zapisania_ZapisanieId",
                table: "Oceny");

            migrationBuilder.DropForeignKey(
                name: "FK_Zapisania_Przedmioty_PrzedmiotId",
                table: "Zapisania");

            migrationBuilder.DropForeignKey(
                name: "FK_Zapisania_Studenci_StudentId",
                table: "Zapisania");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Studenci",
                table: "Studenci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Przedmioty",
                table: "Przedmioty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Oceny",
                table: "Oceny");

            migrationBuilder.RenameTable(
                name: "Studenci",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Przedmioty",
                newName: "Przedmiot");

            migrationBuilder.RenameTable(
                name: "Oceny",
                newName: "Ocena");

            migrationBuilder.RenameIndex(
                name: "IX_Oceny_ZapisanieId",
                table: "Ocena",
                newName: "IX_Ocena_ZapisanieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Przedmiot",
                table: "Przedmiot",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ocena",
                table: "Ocena",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocena_Zapisania_ZapisanieId",
                table: "Ocena",
                column: "ZapisanieId",
                principalTable: "Zapisania",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zapisania_Przedmiot_PrzedmiotId",
                table: "Zapisania",
                column: "PrzedmiotId",
                principalTable: "Przedmiot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zapisania_Students_StudentId",
                table: "Zapisania",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
