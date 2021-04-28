using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Owlbear.Migrations
{
    public partial class InitialArchiveTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Creators");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Creators");

            migrationBuilder.CreateTable(
                name: "CreatorArchive",
                columns: table => new
                {
                    CreatorRecordId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreatorArchive");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Creators",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Creators",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
