using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mekel.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class contacttmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_MessageCategorie_MessageCategoryID",
                table: "Contact");

            migrationBuilder.AlterColumn<int>(
                name: "MessageCategoryID",
                table: "Contact",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_MessageCategorie_MessageCategoryID",
                table: "Contact",
                column: "MessageCategoryID",
                principalTable: "MessageCategorie",
                principalColumn: "MessageCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_MessageCategorie_MessageCategoryID",
                table: "Contact");

            migrationBuilder.AlterColumn<int>(
                name: "MessageCategoryID",
                table: "Contact",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_MessageCategorie_MessageCategoryID",
                table: "Contact",
                column: "MessageCategoryID",
                principalTable: "MessageCategorie",
                principalColumn: "MessageCategoryID");
        }
    }
}
