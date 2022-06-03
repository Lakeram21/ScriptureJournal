using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyScriptureJournal.Migrations
{
    public partial class updatedthemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Scripture",
                newName: "Notes");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Scripture",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Scripture");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Scripture",
                newName: "Text");
        }
    }
}
