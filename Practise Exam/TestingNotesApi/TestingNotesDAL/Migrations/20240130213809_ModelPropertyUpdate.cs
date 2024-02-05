using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingNotesDAL.Migrations
{
    /// <inheritdoc />
    public partial class ModelPropertyUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Notes",
                newName: "LastModifiedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Notes",
                newName: "ModifiedDate");
        }
    }
}
