using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteReceitas.Migrations
{
    /// <inheritdoc />
    public partial class M02AcerteiTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SobreNome",
                table: "UsuariosTeste");

            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "Perfil",
                table: "UsuariosTeste",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SobreNome",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "UsuariosTeste");

            migrationBuilder.DropColumn(
                name: "SobreNome",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "SobreNome",
                table: "UsuariosTeste",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Perfil",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
