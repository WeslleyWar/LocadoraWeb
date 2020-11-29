using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraWeb.Migrations
{
    public partial class AddTableItensLocacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItensLocacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    VeiculoId = table.Column<int>(nullable: true),
                    QntdDiasLocacao = table.Column<int>(nullable: false),
                    Preco = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensLocacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensLocacao_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItensLocacao_VeiculoId",
                table: "ItensLocacao",
                column: "VeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensLocacao");
        }
    }
}
