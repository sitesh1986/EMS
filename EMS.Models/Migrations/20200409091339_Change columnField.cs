using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS.ModelsRepository.Migrations
{
    public partial class ChangecolumnField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmsDate",
                table: "emsMaster");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEms",
                table: "emsMaster",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEms",
                table: "emsMaster");

            migrationBuilder.AddColumn<DateTime>(
                name: "EmsDate",
                table: "emsMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
