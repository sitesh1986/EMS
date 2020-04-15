using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS.ModelBuilderRepository.Migrations
{
    public partial class Add_Table_Block : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Block",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    BlockName = table.Column<string>(nullable: true),
                    StartAddress = table.Column<int>(nullable: false),
                    ModBusFC = table.Column<int>(nullable: false),
                    TotalReg = table.Column<int>(nullable: false),
                    TotalParams = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Block", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Block");
        }
    }
}
