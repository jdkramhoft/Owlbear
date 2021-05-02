using Microsoft.EntityFrameworkCore.Migrations;

namespace Owlbear.Migrations
{
    public partial class TweetsRemoteId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RemoteId",
                table: "Tweet",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemoteId",
                table: "Tweet");
        }
    }
}
