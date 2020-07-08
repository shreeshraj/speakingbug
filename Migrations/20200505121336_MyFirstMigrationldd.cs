using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreProject.Migrations
{
    public partial class MyFirstMigrationldd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_userEntities",
                table: "userEntities");

            migrationBuilder.RenameTable(
                name: "userEntities",
                newName: "tblUser");

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "tblUser",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblUser",
                table: "tblUser",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblUser",
                table: "tblUser");

            migrationBuilder.RenameTable(
                name: "tblUser",
                newName: "userEntities");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "userEntities",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_userEntities",
                table: "userEntities",
                column: "Id");
        }
    }
}
