using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mekel.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class contact_mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageCategoryID",
                table: "Contact",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MessageCategorie",
                columns: table => new
                {
                    MessageCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageCategorie", x => x.MessageCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "SendMessage",
                columns: table => new
                {
                    SendMessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendMessage", x => x.SendMessageID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_MessageCategoryID",
                table: "Contact",
                column: "MessageCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_MessageCategorie_MessageCategoryID",
                table: "Contact",
                column: "MessageCategoryID",
                principalTable: "MessageCategorie",
                principalColumn: "MessageCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_MessageCategorie_MessageCategoryID",
                table: "Contact");

            migrationBuilder.DropTable(
                name: "MessageCategorie");

            migrationBuilder.DropTable(
                name: "SendMessage");

            migrationBuilder.DropIndex(
                name: "IX_Contact_MessageCategoryID",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "MessageCategoryID",
                table: "Contact");
        }
    }
}
