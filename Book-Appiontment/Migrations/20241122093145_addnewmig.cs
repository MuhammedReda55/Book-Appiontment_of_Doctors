using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_Appiontment.Migrations
{
    /// <inheritdoc />
    public partial class addnewmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameDoctor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamePatient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppiontmenDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AppiontmenTime = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lists", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lists");
        }
    }
}
