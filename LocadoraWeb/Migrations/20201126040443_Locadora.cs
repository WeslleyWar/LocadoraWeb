using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraWeb.Migrations
{
    public partial class Locadora : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    CPF = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Endereço = table.Column<string>(nullable: true),
                    Habilitação = table.Column<int>(nullable: false),
                    Categoria = table.Column<string>(nullable: true),
                    Telefone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Placa = table.Column<string>(nullable: true),
                    Renavan = table.Column<string>(nullable: true),
                    TipoCategoria = table.Column<string>(nullable: true),
                    TipoCombustivel = table.Column<string>(nullable: true),
                    Cor = table.Column<string>(nullable: true),
                    QntdPortas = table.Column<int>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    Potencia = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
