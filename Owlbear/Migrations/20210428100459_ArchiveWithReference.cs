using Microsoft.EntityFrameworkCore.Migrations;

namespace Owlbear.Migrations
{
    public partial class ArchiveWithReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "CreatorArchive",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "CreatorArchive");
        }
    }
}
