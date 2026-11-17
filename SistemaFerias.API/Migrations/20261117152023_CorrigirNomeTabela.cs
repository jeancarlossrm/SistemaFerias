using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaFerias.API.Migrations
{
    /// <inheritdoc />
    public partial class CorrigirNomeTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SolitacoesFerias",
                table: "SolitacoesFerias");

            migrationBuilder.RenameTable(
                name: "SolitacoesFerias",
                newName: "SolicitacoesFerias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SolicitacoesFerias",
                table: "SolicitacoesFerias",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SolicitacoesFerias",
                table: "SolicitacoesFerias");

            migrationBuilder.RenameTable(
                name: "SolicitacoesFerias",
                newName: "SolitacoesFerias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SolitacoesFerias",
                table: "SolitacoesFerias",
                column: "Id");
        }
    }
}
