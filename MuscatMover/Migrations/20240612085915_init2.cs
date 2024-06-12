using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using MuscatMover.Models;

#nullable disable

namespace MuscatMover.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        private object table;

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    uname = table.Column<string>(type: "varchar(450)", nullable: false),
                    pass = table.Column<string>(type: "varchar(450)", nullable: false),
                },

                constraints: table =>
                {
                    table.PrimaryKey("pk_login", x =>x.uname);
                });
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "login");
        }
    }
}
