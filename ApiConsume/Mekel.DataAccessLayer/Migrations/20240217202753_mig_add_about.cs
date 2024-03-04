using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mekel.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_about : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "About",
                newName: "Description4");

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "About",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "About",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "About",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "About");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "About");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "About");

            migrationBuilder.RenameColumn(
                name: "Description4",
                table: "About",
                newName: "Description");
        }
    }
}
