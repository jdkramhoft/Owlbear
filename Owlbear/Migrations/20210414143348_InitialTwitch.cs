using Microsoft.EntityFrameworkCore.Migrations;

namespace Owlbear.Migrations
{
    public partial class InitialTwitch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Creators_Twitter_TwitterId",
                table: "Creators");

            migrationBuilder.AlterColumn<int>(
                name: "TwitterId",
                table: "Creators",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "TwitchTwitterId",
                table: "Creators",
                type: "INTEGER",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Creators_TwitchTwitterId",
                table: "Creators",
                column: "TwitchTwitterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Creators_Twitch_TwitchTwitterId",
                table: "Creators",
                column: "TwitchTwitterId",
                principalTable: "Twitch",
                principalColumn: "TwitterId",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Creators_Twitch_TwitchTwitterId",
                table: "Creators");

            migrationBuilder.DropForeignKey(
                name: "FK_Creators_Twitter_TwitterId",
                table: "Creators");

            migrationBuilder.DropTable(
                name: "Twitch");

            migrationBuilder.DropIndex(
                name: "IX_Creators_TwitchTwitterId",
                table: "Creators");

            migrationBuilder.DropColumn(
                name: "TwitchTwitterId",
                table: "Creators");

            migrationBuilder.AlterColumn<int>(
                name: "TwitterId",
                table: "Creators",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Creators_Twitter_TwitterId",
                table: "Creators",
                column: "TwitterId",
                principalTable: "Twitter",
                principalColumn: "TwitterId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
