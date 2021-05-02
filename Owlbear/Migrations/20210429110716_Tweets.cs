using Microsoft.EntityFrameworkCore.Migrations;

namespace Owlbear.Migrations
{
    public partial class Tweets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tweet",
                columns: table => new
                {
                    TweetId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    Likes = table.Column<int>(type: "INTEGER", nullable: false),
                    Retweets = table.Column<int>(type: "INTEGER", nullable: false),
                    Quotes = table.Column<int>(type: "INTEGER", nullable: false),
                    Replies = table.Column<int>(type: "INTEGER", nullable: false),
                    TwitterId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tweet", x => x.TweetId);
                    table.ForeignKey(
                        name: "FK_Tweet_Twitter_TwitterId",
                        column: x => x.TwitterId,
                        principalTable: "Twitter",
                        principalColumn: "TwitterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tweet_TwitterId",
                table: "Tweet",
                column: "TwitterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tweet");
        }
    }
}
