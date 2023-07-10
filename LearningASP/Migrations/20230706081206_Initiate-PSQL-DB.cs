using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningASP.Migrations
{
    /// <inheritdoc />
    public partial class InitiatePSQLDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Chapters",
                newName: "AuthorName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Chapters",
                newName: "Author");
        }
    }
}
