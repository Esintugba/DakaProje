using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mekel.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_contact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Contact_ContactId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_ContactId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Contact");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Contact",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ContactId",
                table: "Contact",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Contact_ContactId",
                table: "Contact",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id");
        }
    }
}
