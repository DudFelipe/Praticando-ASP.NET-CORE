using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoClientes.Data.Migrations
{
    public partial class AdicionandoCampoAtivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Cliente",
                nullable: false,
                defaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Cliente");
        }
    }
}
