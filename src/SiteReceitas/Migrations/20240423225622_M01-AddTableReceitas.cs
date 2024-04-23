using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteReceitas.Migrations
{
    /// <inheritdoc />
    public partial class M01AddTableReceitas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeReceita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModoPreparo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receitas");
        }
    }
}
