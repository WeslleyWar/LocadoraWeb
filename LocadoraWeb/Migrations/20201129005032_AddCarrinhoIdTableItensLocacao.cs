using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraWeb.Migrations
{
    public partial class AddCarrinhoIdTableItensLocacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarrinhoId",
                table: "ItensLocacao",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarrinhoId",
                table: "ItensLocacao");
        }
    }
}
