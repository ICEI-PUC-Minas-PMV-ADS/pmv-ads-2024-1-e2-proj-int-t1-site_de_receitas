using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteReceitas.Migrations
{
    /// <inheritdoc />
    public partial class TableIngredientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeIngrediente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeReceita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModoPreparo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IngredienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receitas_Ingredientes_IngredienteId",
                        column: x => x.IngredienteId,
                        principalTable: "Ingredientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_IngredienteId",
                table: "Receitas",
                column: "IngredienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receitas");

            migrationBuilder.DropTable(
                name: "Ingredientes");
        }
    }
}
