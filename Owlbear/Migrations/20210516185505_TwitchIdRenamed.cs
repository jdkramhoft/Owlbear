using Microsoft.EntityFrameworkCore.Migrations;

namespace Owlbear.Migrations
{
    public partial class TwitchIdRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatorArchive_Twitch_TwitchTwitterId",
                table: "CreatorArchive");

            migrationBuilder.DropForeignKey(
                name: "FK_Creators_Twitch_TwitchTwitterId",
                table: "Creators");

            migrationBuilder.RenameColumn(
                name: "TwitterId",
                table: "Twitch",
                newName: "TwitchId");

            migrationBuilder.RenameColumn(
                name: "TwitchTwitterId",
                table: "Creators",
                newName: "TwitchId");

            migrationBuilder.RenameIndex(
                name: "IX_Creators_TwitchTwitterId",
                table: "Creators",
                newName: "IX_Creators_TwitchId");

            migrationBuilder.RenameColumn(
                name: "TwitchTwitterId",
                table: "CreatorArchive",
                newName: "TwitchId");

            migrationBuilder.RenameIndex(
                name: "IX_CreatorArchive_TwitchTwitterId",
                table: "CreatorArchive",
                newName: "IX_CreatorArchive_TwitchId");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatorArchive_Twitch_TwitchId",
                table: "CreatorArchive",
                column: "TwitchId",
                principalTable: "Twitch",
                principalColumn: "TwitchId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Creators_Twitch_TwitchId",
                table: "Creators",
                column: "TwitchId",
                principalTable: "Twitch",
                principalColumn: "TwitchId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatorArchive_Twitch_TwitchId",
                table: "CreatorArchive");

            migrationBuilder.DropForeignKey(
                name: "FK_Creators_Twitch_TwitchId",
                table: "Creators");

            migrationBuilder.RenameColumn(
                name: "TwitchId",
                table: "Twitch",
                newName: "TwitterId");

            migrationBuilder.RenameColumn(
                name: "TwitchId",
                table: "Creators",
                newName: "TwitchTwitterId");

            migrationBuilder.RenameIndex(
                name: "IX_Creators_TwitchId",
                table: "Creators",
                newName: "IX_Creators_TwitchTwitterId");

            migrationBuilder.RenameColumn(
                name: "TwitchId",
                table: "CreatorArchive",
                newName: "TwitchTwitterId");

            migrationBuilder.RenameIndex(
                name: "IX_CreatorArchive_TwitchId",
                table: "CreatorArchive",
                newName: "IX_CreatorArchive_TwitchTwitterId");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatorArchive_Twitch_TwitchTwitterId",
                table: "CreatorArchive",
                column: "TwitchTwitterId",
                principalTable: "Twitch",
                principalColumn: "TwitterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Creators_Twitch_TwitchTwitterId",
                table: "Creators",
                column: "TwitchTwitterId",
                principalTable: "Twitch",
                principalColumn: "TwitterId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
