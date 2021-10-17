using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DogNet.Migrations
{
    public partial class fulldb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CPF = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Situacao = table.Column<int>(type: "INTEGER", nullable: false),
                    Endereco_Logradouro = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Endereco_Numero = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Endereco_Complemento = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Endereco_Bairro = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Endereco_Cidade = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Endereco_Estado = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true),
                    Endereco_CEP = table.Column<string>(type: "TEXT", maxLength: 8, nullable: true),
                    Endereco_Referencia = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Instituicoes",
                columns: table => new
                {
                    IdInstituicoes = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Pix = table.Column<string>(type: "TEXT", nullable: false),
                    CNPJ = table.Column<string>(type: "TEXT", maxLength: 14, nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Endereco_Logradouro = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Endereco_Numero = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Endereco_Complemento = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Endereco_Bairro = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Endereco_Cidade = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Endereco_Estado = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    Endereco_CEP = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    Endereco_Referencia = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicoes", x => x.IdInstituicoes);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Preco = table.Column<double>(type: "REAL", nullable: false),
                    Estoque = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.IdProduto);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataHoraPedido = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValorTotal = table.Column<double>(type: "REAL", nullable: false),
                    Situacao = table.Column<int>(type: "INTEGER", nullable: false),
                    IdCliente = table.Column<int>(type: "INTEGER", nullable: true),
                    IdCarrinho = table.Column<string>(type: "TEXT", nullable: true),
                    Endereco_Logradouro = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Endereco_Numero = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Endereco_Complemento = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Endereco_Bairro = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Endereco_Cidade = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Endereco_Estado = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true),
                    Endereco_CEP = table.Column<string>(type: "TEXT", maxLength: 8, nullable: true),
                    Endereco_Referencia = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItensPedido",
                columns: table => new
                {
                    IdPedido = table.Column<int>(type: "INTEGER", nullable: false),
                    IdProduto = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantidade = table.Column<float>(type: "REAL", nullable: false),
                    ValorUnitario = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensPedido", x => new { x.IdPedido, x.IdProduto });
                    table.ForeignKey(
                        name: "FK_ItensPedido_Pedidos_IdPedido",
                        column: x => x.IdPedido,
                        principalTable: "Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItensPedido_Produtos_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produtos",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItensPedido_IdProduto",
                table: "ItensPedido",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_IdCliente",
                table: "Pedidos",
                column: "IdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instituicoes");

            migrationBuilder.DropTable(
                name: "ItensPedido");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
