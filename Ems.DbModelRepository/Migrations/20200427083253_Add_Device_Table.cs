using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS.DbModelRepository.Migrations
{
    public partial class Add_Device_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "deviceModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    DeviceSerialNumber = table.Column<string>(nullable: true),
                    MeterConnected = table.Column<int>(nullable: false),
                    MeterMake = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deviceModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "deviceModels");
        }
    }
}
