using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Farmacia.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FkIdMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicamentos_Marcas_MarcaId",
                table: "Medicamentos");

            migrationBuilder.DropIndex(
                name: "IX_Medicamentos_MarcaId",
                table: "Medicamentos");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Medicamentos");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamentos_IdMarca",
                table: "Medicamentos",
                column: "IdMarca");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicamentos_Marcas_IdMarca",
                table: "Medicamentos",
                column: "IdMarca",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicamentos_Marcas_IdMarca",
                table: "Medicamentos");

            migrationBuilder.DropIndex(
                name: "IX_Medicamentos_IdMarca",
                table: "Medicamentos");

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Medicamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Medicamentos_MarcaId",
                table: "Medicamentos",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicamentos_Marcas_MarcaId",
                table: "Medicamentos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
