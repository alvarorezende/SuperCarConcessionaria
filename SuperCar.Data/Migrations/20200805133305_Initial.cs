using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCar.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cambios",
                columns: table => new
                {
                    CambioId = table.Column<Guid>(nullable: false),
                    TipoCambio = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cambios", x => x.CambioId);
                });

            migrationBuilder.CreateTable(
                name: "Combustiveis",
                columns: table => new
                {
                    CombustivelId = table.Column<Guid>(nullable: false),
                    TipoCombustivel = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combustiveis", x => x.CombustivelId);
                });

            migrationBuilder.CreateTable(
                name: "Cores",
                columns: table => new
                {
                    CorId = table.Column<Guid>(nullable: false),
                    NomeCor = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cores", x => x.CorId);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    MarcaId = table.Column<Guid>(nullable: false),
                    NomeMarca = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    VeiculoId = table.Column<Guid>(nullable: false),
                    Placa = table.Column<string>(type: "varchar(7)", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(200)", nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    AnoModelo = table.Column<int>(nullable: false),
                    KmRodado = table.Column<int>(nullable: false),
                    QtdPortas = table.Column<int>(nullable: false),
                    ObsVeiculo = table.Column<string>(type: "varchar(1000)", nullable: true),
                    MarcaId = table.Column<Guid>(nullable: true),
                    CambioId = table.Column<Guid>(nullable: true),
                    CombustivelId = table.Column<Guid>(nullable: true),
                    CorId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.VeiculoId);
                    table.ForeignKey(
                        name: "FK_Veiculos_Cambios_CambioId",
                        column: x => x.CambioId,
                        principalTable: "Cambios",
                        principalColumn: "CambioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculos_Combustiveis_CombustivelId",
                        column: x => x.CombustivelId,
                        principalTable: "Combustiveis",
                        principalColumn: "CombustivelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculos_Cores_CorId",
                        column: x => x.CorId,
                        principalTable: "Cores",
                        principalColumn: "CorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_CambioId",
                table: "Veiculos",
                column: "CambioId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_CombustivelId",
                table: "Veiculos",
                column: "CombustivelId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_CorId",
                table: "Veiculos",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_MarcaId",
                table: "Veiculos",
                column: "MarcaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Cambios");

            migrationBuilder.DropTable(
                name: "Combustiveis");

            migrationBuilder.DropTable(
                name: "Cores");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
