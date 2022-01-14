using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LowCodeProject.Migrations
{
    public partial class creat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FormatModel",
                table: "FormatModel");

            migrationBuilder.RenameTable(
                name: "FormatModel",
                newName: "tb_FormatModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_FormatModel",
                table: "tb_FormatModel",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_FormatModel",
                table: "tb_FormatModel");

            migrationBuilder.RenameTable(
                name: "tb_FormatModel",
                newName: "FormatModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormatModel",
                table: "FormatModel",
                column: "Id");
        }
    }
}
