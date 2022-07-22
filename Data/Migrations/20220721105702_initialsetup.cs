using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommunityCare.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolunteerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedule");
        }
    }
}
