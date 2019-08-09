using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ocorrencias",
                columns: table => new
                {
                    OcorrenciaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero_Ocorrencia = table.Column<long>(nullable: false),
                    Titulo = table.Column<string>(nullable: false),
                    DataHora = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Criticidade = table.Column<int>(nullable: false),
                    Solucao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocorrencias", x => x.OcorrenciaId);
                });

            migrationBuilder.CreateTable(
                name: "Rotinas",
                columns: table => new
                {
                    RotinaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    OrdemDeServico = table.Column<int>(nullable: false),
                    Execucao = table.Column<int>(nullable: false),
                    ResponsavelDaRotina = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotinas", x => x.RotinaId);
                });

            migrationBuilder.CreateTable(
                name: "Servidores",
                columns: table => new
                {
                    ServidorId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Ambiente = table.Column<int>(nullable: false),
                    ServidorIp = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servidores", x => x.ServidorId);
                });

            migrationBuilder.CreateTable(
                name: "OcorrenciaIteracoes",
                columns: table => new
                {
                    OcorrenciaIteracaoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Iteracao = table.Column<string>(nullable: true),
                    DataHoraIteracao = table.Column<DateTime>(nullable: false),
                    Assinatura = table.Column<string>(nullable: true),
                    OcorrenciaId = table.Column<int>(nullable: false),
                    OcorrenciaId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcorrenciaIteracoes", x => x.OcorrenciaIteracaoId);
                    table.ForeignKey(
                        name: "FK_OcorrenciaIteracoes_Ocorrencias_OcorrenciaId1",
                        column: x => x.OcorrenciaId1,
                        principalTable: "Ocorrencias",
                        principalColumn: "OcorrenciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OcorrenciaIteracoes_OcorrenciaId1",
                table: "OcorrenciaIteracoes",
                column: "OcorrenciaId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OcorrenciaIteracoes");

            migrationBuilder.DropTable(
                name: "Rotinas");

            migrationBuilder.DropTable(
                name: "Servidores");

            migrationBuilder.DropTable(
                name: "Ocorrencias");
        }
    }
}
