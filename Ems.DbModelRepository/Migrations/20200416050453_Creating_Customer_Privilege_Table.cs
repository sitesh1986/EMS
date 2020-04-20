using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS.DbModelRepository.Migrations
{
    public partial class Creating_Customer_Privilege_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customerprivileges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    PrivilegeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerprivileges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    UserPassword = table.Column<string>(nullable: true),
                    NoOfPlants = table.Column<int>(nullable: false),
                    PlantAddress = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    SocialMedia = table.Column<string>(nullable: true),
                    HeadOffice = table.Column<string>(nullable: true),
                    ContatctPerson = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true),
                    GSTNumber = table.Column<string>(nullable: true),
                    PAN = table.Column<string>(nullable: true),
                    RRNumber = table.Column<string>(nullable: true),
                    TAN = table.Column<string>(nullable: true),
                    CIN = table.Column<string>(nullable: true),
                    UAM = table.Column<string>(nullable: true),
                    Activity = table.Column<string>(nullable: true),
                    Incomers = table.Column<int>(nullable: false),
                    DG = table.Column<int>(nullable: false),
                    Solar = table.Column<int>(nullable: false),
                    Demand = table.Column<int>(nullable: false),
                    DemandCharges = table.Column<int>(nullable: false),
                    PenaltyCharges = table.Column<int>(nullable: false),
                    NoOfTransformers = table.Column<int>(nullable: false),
                    Transformer1Rating = table.Column<int>(nullable: false),
                    Transformer2Rating = table.Column<int>(nullable: false),
                    Transformer3Rating = table.Column<int>(nullable: false),
                    Transformer4Rating = table.Column<int>(nullable: false),
                    Transformer5Rating = table.Column<int>(nullable: false),
                    NoOfMachine = table.Column<int>(nullable: false),
                    Unit = table.Column<int>(nullable: false),
                    LicenceExpiry = table.Column<DateTime>(nullable: false),
                    Monitoring = table.Column<bool>(nullable: false),
                    Controlling = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "priviliges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    PrivilegeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_priviliges", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customerprivileges");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "priviliges");
        }
    }
}
