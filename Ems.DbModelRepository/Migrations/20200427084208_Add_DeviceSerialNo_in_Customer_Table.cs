using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS.DbModelRepository.Migrations
{
    public partial class Add_DeviceSerialNo_in_Customer_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeviceSerialNumber",
                table: "customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeviceSerialNumber",
                table: "customers");
        }
    }
}
