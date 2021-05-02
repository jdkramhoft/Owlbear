using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Owlbear.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Twitch",
                columns: table => new
                {
                    TwitterId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RemoteId = table.Column<int>(type: "INTEGER", nullable: false),
                    RemoteLogin = table.Column<string>(type: "TEXT", nullable: false),
                    Handle = table.Column<string>(type: "TEXT", nullable: false),
                    Followers = table.Column<int>(type: "INTEGER", nullable: false),
                    Views = table.Column<long>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ProfileImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    OfflineImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Twitch", x => x.TwitterId);
                });

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

            migrationBuilder.CreateTable(
                name: "Youtube",
                columns: table => new
                {
                    YoutubeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RemoteId = table.Column<string>(type: "TEXT", nullable: false),
                    TotalViews = table.Column<long>(type: "INTEGER", nullable: false),
                    Subscribers = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Youtube", x => x.YoutubeId);
                });

            migrationBuilder.CreateTable(
                name: "Tweet",
                columns: table => new
                {
                    TweetId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RemoteId = table.Column<string>(type: "TEXT", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "CreatorArchive",
                columns: table => new
                {
                    CreatorRecordId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    TwitterId = table.Column<int>(type: "INTEGER", nullable: true),
                    TwitchTwitterId = table.Column<int>(type: "INTEGER", nullable: true),
                    YoutubeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatorArchive", x => x.CreatorRecordId);
                    table.ForeignKey(
                        name: "FK_CreatorArchive_Twitch_TwitchTwitterId",
                        column: x => x.TwitchTwitterId,
                        principalTable: "Twitch",
                        principalColumn: "TwitterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CreatorArchive_Twitter_TwitterId",
                        column: x => x.TwitterId,
                        principalTable: "Twitter",
                        principalColumn: "TwitterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CreatorArchive_Youtube_YoutubeId",
                        column: x => x.YoutubeId,
                        principalTable: "Youtube",
                        principalColumn: "YoutubeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Creators",
                columns: table => new
                {
                    CreatorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    TwitterId = table.Column<int>(type: "INTEGER", nullable: true),
                    TwitchTwitterId = table.Column<int>(type: "INTEGER", nullable: true),
                    YoutubeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creators", x => x.CreatorId);
                    table.ForeignKey(
                        name: "FK_Creators_Twitch_TwitchTwitterId",
                        column: x => x.TwitchTwitterId,
                        principalTable: "Twitch",
                        principalColumn: "TwitterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Creators_Twitter_TwitterId",
                        column: x => x.TwitterId,
                        principalTable: "Twitter",
                        principalColumn: "TwitterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Creators_Youtube_YoutubeId",
                        column: x => x.YoutubeId,
                        principalTable: "Youtube",
                        principalColumn: "YoutubeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreatorArchive_TwitchTwitterId",
                table: "CreatorArchive",
                column: "TwitchTwitterId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatorArchive_TwitterId",
                table: "CreatorArchive",
                column: "TwitterId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatorArchive_YoutubeId",
                table: "CreatorArchive",
                column: "YoutubeId");

            migrationBuilder.CreateIndex(
                name: "IX_Creators_TwitchTwitterId",
                table: "Creators",
                column: "TwitchTwitterId");

            migrationBuilder.CreateIndex(
                name: "IX_Creators_TwitterId",
                table: "Creators",
                column: "TwitterId");

            migrationBuilder.CreateIndex(
                name: "IX_Creators_YoutubeId",
                table: "Creators",
                column: "YoutubeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tweet_TwitterId",
                table: "Tweet",
                column: "TwitterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreatorArchive");

            migrationBuilder.DropTable(
                name: "Creators");

            migrationBuilder.DropTable(
                name: "Tweet");

            migrationBuilder.DropTable(
                name: "Twitch");

            migrationBuilder.DropTable(
                name: "Youtube");

            migrationBuilder.DropTable(
                name: "Twitter");
        }
    }
}
