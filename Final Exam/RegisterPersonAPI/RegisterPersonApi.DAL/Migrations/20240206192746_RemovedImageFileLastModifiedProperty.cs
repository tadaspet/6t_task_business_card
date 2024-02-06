using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegisterPersonApi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemovedImageFileLastModifiedProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "ImageFiles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "ImageFiles",
                type: "datetime2",
                nullable: true);
        }
    }
}
