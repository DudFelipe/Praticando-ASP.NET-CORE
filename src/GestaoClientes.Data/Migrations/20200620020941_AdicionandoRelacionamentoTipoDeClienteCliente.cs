using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoClientes.Data.Migrations
{
    public partial class AdicionandoRelacionamentoTipoDeClienteCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TiposDeClientesId",
                table: "Cliente",
                nullable: false,
                defaultValue: new Guid("b93f8f74-07f7-4104-8f6a-2a8c3fd262e4"));

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_TiposDeClientesId",
                table: "Cliente",
                column: "TiposDeClientesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_TiposDeClientes_TiposDeClientesId",
                table: "Cliente",
                column: "TiposDeClientesId",
                principalTable: "TiposDeClientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_TiposDeClientes_TiposDeClientesId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_TiposDeClientesId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "TiposDeClientesId",
                table: "Cliente");
        }
    }
}
