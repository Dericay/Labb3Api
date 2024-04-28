using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb3Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    InterestsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterestsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterestsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.InterestsID);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    LinkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.LinkID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "UserConnection",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    InterestsID = table.Column<int>(type: "int", nullable: false),
                    LinksID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserConnection", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserConnection_Interests_InterestsID",
                        column: x => x.InterestsID,
                        principalTable: "Interests",
                        principalColumn: "InterestsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserConnection_Links_LinksID",
                        column: x => x.LinksID,
                        principalTable: "Links",
                        principalColumn: "LinkID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserConnection_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "InterestsID", "InterestsDescription", "InterestsName" },
                values: new object[,]
                {
                    { 1, "C# is a programing language that are used in coding.", "C#" },
                    { 2, "Reading different kinds of books", "Read" },
                    { 3, "Kick a ball around and try to score", "Football" },
                    { 4, "Wooden board with wheels", "Skateboarding" },
                    { 5, "Coffee is made out of roasted beans, fun to make and drink", "Coffee" }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "LinkID", "Link" },
                values: new object[,]
                {
                    { 1, "https://en.wikipedia.org/wiki/C_Sharp_(programming_language)" },
                    { 2, "https://www.amazon.com/books-used-books-textbooks/b?ie=UTF8&node=283155" },
                    { 3, "https://sv.wikipedia.org/wiki/Football" },
                    { 4, "https://en.wikipedia.org/wiki/Skateboarding" },
                    { 5, "https://en.wikipedia.org/wiki/Coffee" },
                    { 6, "https://www.britannica.com/topic/coffee" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Anas", "Qlok", "023329248" },
                    { 2, "Maureen", "Larsson", "072362462" },
                    { 3, "Sara", "Sarasson", "2099425498" }
                });

            migrationBuilder.InsertData(
                table: "UserConnection",
                columns: new[] { "ID", "InterestsID", "LinksID", "UserID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 2, 2 },
                    { 3, 3, 3, 3 },
                    { 4, 3, 3, 2 },
                    { 5, 4, 4, 3 },
                    { 6, 5, 5, 3 },
                    { 7, 5, 6, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserConnection_InterestsID",
                table: "UserConnection",
                column: "InterestsID");

            migrationBuilder.CreateIndex(
                name: "IX_UserConnection_LinksID",
                table: "UserConnection",
                column: "LinksID");

            migrationBuilder.CreateIndex(
                name: "IX_UserConnection_UserID",
                table: "UserConnection",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserConnection");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
