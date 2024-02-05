using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingNotesDAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "NoteCategories",
                newName: "LastModifiedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "NoteCategories",
                newName: "ModifiedDate");
        }
    }
}
