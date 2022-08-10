using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    public partial class firstone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "collisionChecks",
                columns: table => new
                {
                    CollisionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Meteor1X = table.Column<int>(type: "INTEGER", nullable: false),
                    Meteor1Y = table.Column<int>(type: "INTEGER", nullable: false),
                    Meteor2X = table.Column<int>(type: "INTEGER", nullable: false),
                    Meteor2Y = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_collisionChecks", x => x.CollisionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "collisionChecks");
        }
    }
}
