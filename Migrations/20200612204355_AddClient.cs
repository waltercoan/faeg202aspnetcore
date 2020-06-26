using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace faegtodo.Migrations
{
    public partial class AddClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "Birthday", "Name" },
                values: new object[] { 1, "Rua lalalal 1000", new DateTime(2020, 6, 12, 20, 43, 55, 642, DateTimeKind.Local).AddTicks(367), "Zezinho" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "Birthday", "Name" },
                values: new object[] { 2, "Rua lulull 200", new DateTime(2020, 6, 12, 20, 43, 55, 643, DateTimeKind.Local).AddTicks(5590), "Huguinho" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
