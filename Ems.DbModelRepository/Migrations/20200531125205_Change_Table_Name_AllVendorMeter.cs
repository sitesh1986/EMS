using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS.DbModelRepository.Migrations
{
    public partial class Change_Table_Name_AllVendorMeter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Venlite1",
                table: "Venlite1");

            migrationBuilder.RenameTable(
                name: "Venlite1",
                newName: "AllVendorMeter");

            migrationBuilder.AddColumn<string>(
                name: "ModelName",
                table: "AllVendorMeter",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AllVendorMeter",
                table: "AllVendorMeter",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AllVendorMeter",
                table: "AllVendorMeter");

            migrationBuilder.DropColumn(
                name: "ModelName",
                table: "AllVendorMeter");

            migrationBuilder.RenameTable(
                name: "AllVendorMeter",
                newName: "Venlite1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venlite1",
                table: "Venlite1",
                column: "Id");
        }
    }
}
