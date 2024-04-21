using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteReceitas.Migrations
{
    /// <inheritdoc />
    public partial class M03Ingrediente_Receita : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IngredientesReceita",
                columns: table => new
                {
                    IdIngredienteReceita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantidadeIngrediente = table.Column<int>(type: "int", nullable: false),
                    IdReceita = table.Column<int>(type: "int", nullable: false),
                    ReceitaIdReceita = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientesReceita", x => x.IdIngredienteReceita);
                    table.ForeignKey(
                        name: "FK_IngredientesReceita_Receitas_ReceitaIdReceita",
                        column: x => x.ReceitaIdReceita,
                        principalTable: "Receitas",
                        principalColumn: "IdReceita");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesReceita_ReceitaIdReceita",
                table: "IngredientesReceita",
                column: "ReceitaIdReceita");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientesReceita");
        }
    }
}
