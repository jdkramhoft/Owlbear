using Microsoft.EntityFrameworkCore.Migrations;

namespace Owlbear.Migrations
{
    public partial class InitialTwitter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TwitterId",
                table: "Creators",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Twitter",
                columns: table => new
                {
                    TwitterId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RemoteId = table.Column<string>(type: "TEXT", nullable: false),
                    Handle = table.Column<string>(type: "TEXT", nullable: false),
                    Followers = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Twitter", x => x.TwitterId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Creators_TwitterId",
                table: "Creators",
                column: "TwitterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Creators_Twitter_TwitterId",
                table: "Creators",
                column: "TwitterId",
                principalTable: "Twitter",
                principalColumn: "TwitterId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Creators_Twitter_TwitterId",
                table: "Creators");

            migrationBuilder.DropTable(
                name: "Twitter");

            migrationBuilder.DropIndex(
                name: "IX_Creators_TwitterId",
                table: "Creators");

            migrationBuilder.DropColumn(
                name: "TwitterId",
                table: "Creators");
        }
    }
}
