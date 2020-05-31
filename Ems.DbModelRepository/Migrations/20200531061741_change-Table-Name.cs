using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS.DbModelRepository.Migrations
{
    public partial class changeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PM520L",
                table: "PM520L");

            migrationBuilder.RenameTable(
                name: "PM520L",
                newName: "Venlite1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venlite1",
                table: "Venlite1",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Venlite1",
                table: "Venlite1");

            migrationBuilder.RenameTable(
                name: "Venlite1",
                newName: "PM520L");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PM520L",
                table: "PM520L",
                column: "Id");
        }
    }
}
