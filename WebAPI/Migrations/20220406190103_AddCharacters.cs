using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class AddCharacters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "Items",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterClass = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_CharacterId",
                table: "Items",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Characters_CharacterId",
                table: "Items",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Characters_CharacterId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Items_CharacterId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Items");
        }
    }
}
