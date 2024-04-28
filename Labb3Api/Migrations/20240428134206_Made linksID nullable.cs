using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb3Api.Migrations
{
    public partial class MadelinksIDnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserConnection_Links_LinksID",
                table: "UserConnection");

            migrationBuilder.AlterColumn<int>(
                name: "LinksID",
                table: "UserConnection",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_UserConnection_Links_LinksID",
                table: "UserConnection",
                column: "LinksID",
                principalTable: "Links",
                principalColumn: "LinkID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserConnection_Links_LinksID",
                table: "UserConnection");

            migrationBuilder.AlterColumn<int>(
                name: "LinksID",
                table: "UserConnection",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserConnection_Links_LinksID",
                table: "UserConnection",
                column: "LinksID",
                principalTable: "Links",
                principalColumn: "LinkID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
