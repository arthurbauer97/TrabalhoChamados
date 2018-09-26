using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrabalhoChamados.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomecliente = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Situacoes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tiposituacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situacoes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Chamados",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    data = table.Column<DateTime>(nullable: false),
                    descricao = table.Column<string>(nullable: true),
                    datasolucao = table.Column<DateTime>(nullable: false),
                    horainicio = table.Column<TimeSpan>(nullable: false),
                    horafinal = table.Column<TimeSpan>(nullable: false),
                    duracao = table.Column<TimeSpan>(nullable: false),
                    clienteid = table.Column<int>(nullable: true),
                    tiposituacaoid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamados", x => x.id);
                    table.ForeignKey(
                        name: "FK_Chamados_Clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chamados_Situacoes_tiposituacaoid",
                        column: x => x.tiposituacaoid,
                        principalTable: "Situacoes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_clienteid",
                table: "Chamados",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_tiposituacaoid",
                table: "Chamados",
                column: "tiposituacaoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chamados");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Situacoes");
        }
    }
}
