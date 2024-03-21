using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Course_API.Migrations
{
    /// <inheritdoc />
    public partial class u3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Courses");

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Groups",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Groups");

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Courses",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
