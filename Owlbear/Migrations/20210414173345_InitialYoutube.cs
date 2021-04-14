using Microsoft.EntityFrameworkCore.Migrations;

namespace Owlbear.Migrations
{
    public partial class InitialYoutube : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YoutubeId",
                table: "Creators",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Youtube",
                columns: table => new
                {
                    YoutubeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TotalViews = table.Column<long>(type: "INTEGER", nullable: false),
                    Subscribers = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Youtube", x => x.YoutubeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Creators_YoutubeId",
                table: "Creators",
                column: "YoutubeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Creators_Youtube_YoutubeId",
                table: "Creators",
                column: "YoutubeId",
                principalTable: "Youtube",
                principalColumn: "YoutubeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Creators_Youtube_YoutubeId",
                table: "Creators");

            migrationBuilder.DropTable(
                name: "Youtube");

            migrationBuilder.DropIndex(
                name: "IX_Creators_YoutubeId",
                table: "Creators");

            migrationBuilder.DropColumn(
                name: "YoutubeId",
                table: "Creators");
        }
    }
}
