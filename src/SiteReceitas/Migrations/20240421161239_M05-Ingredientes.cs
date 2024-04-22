using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteReceitas.Migrations
{
    /// <inheritdoc />
    public partial class M05Ingredientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdIngrediente",
                table: "IngredientesReceita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IngredienteIdIngrediente",
                table: "IngredientesReceita",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    IdIngrediente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeIngrediente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnidadeMedida = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.IdIngrediente);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesReceita_IngredienteIdIngrediente",
                table: "IngredientesReceita",
                column: "IngredienteIdIngrediente");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientesReceita_Ingredientes_IngredienteIdIngrediente",
                table: "IngredientesReceita",
                column: "IngredienteIdIngrediente",
                principalTable: "Ingredientes",
                principalColumn: "IdIngrediente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientesReceita_Ingredientes_IngredienteIdIngrediente",
                table: "IngredientesReceita");

            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropIndex(
                name: "IX_IngredientesReceita_IngredienteIdIngrediente",
                table: "IngredientesReceita");

            migrationBuilder.DropColumn(
                name: "IdIngrediente",
                table: "IngredientesReceita");

            migrationBuilder.DropColumn(
                name: "IngredienteIdIngrediente",
                table: "IngredientesReceita");
        }
    }
}
