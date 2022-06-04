using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _430testmvc.Migrations
{
    /// <inheritdoc />
    public partial class Books : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    book_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    book_name = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    author = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    publicsh = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    book_borrow_ID = table.Column<int>(type: "int", nullable: false),
                    user_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.book_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
