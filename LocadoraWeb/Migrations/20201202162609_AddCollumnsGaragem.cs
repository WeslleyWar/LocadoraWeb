using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraWeb.Migrations
{
    public partial class AddCollumnsGaragem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Garagem");

            migrationBuilder.AddColumn<string>(
                name: "Localidade",
                table: "Garagem",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Uf",
                table: "Garagem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Localidade",
                table: "Garagem");

            migrationBuilder.DropColumn(
                name: "Uf",
                table: "Garagem");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Garagem",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
