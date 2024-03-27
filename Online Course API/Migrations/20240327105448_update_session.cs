using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Course_API.Migrations
{
    /// <inheritdoc />
    public partial class update_session : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OnlineVideo",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Zoom",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OnlineVideo",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Zoom",
                table: "Sessions");
        }
    }
}
