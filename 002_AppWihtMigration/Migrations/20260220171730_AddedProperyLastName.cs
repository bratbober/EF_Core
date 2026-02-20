using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _002_AppWihtMigration.Migrations
{
    /// <inheritdoc />
    public partial class AddedProperyLastName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "People");
        }
    }
}
