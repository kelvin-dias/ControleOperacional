using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Inicial_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OcorrenciaIteracoes");

            migrationBuilder.CreateTable(
                name: "Iteracoes",
                columns: table => new
                {
                    IteracaoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TextoIteracao = table.Column<string>(nullable: true),
                    DataHoraIteracao = table.Column<DateTime>(nullable: false),
                    Assinatura = table.Column<string>(nullable: true),
                    OcorrenciaId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iteracoes", x => x.IteracaoId);
                    table.ForeignKey(
                        name: "FK_Iteracoes_Ocorrencias_OcorrenciaId",
                        column: x => x.OcorrenciaId,
                        principalTable: "Ocorrencias",
                        principalColumn: "OcorrenciaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Iteracoes_OcorrenciaId",
                table: "Iteracoes",
                column: "OcorrenciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iteracoes");

            migrationBuilder.CreateTable(
                name: "OcorrenciaIteracoes",
                columns: table => new
                {
                    OcorrenciaIteracaoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Assinatura = table.Column<string>(nullable: true),
                    DataHoraIteracao = table.Column<DateTime>(nullable: false),
                    Iteracao = table.Column<string>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OcorrenciaIteracoes_OcorrenciaId1",
                table: "OcorrenciaIteracoes",
                column: "OcorrenciaId1");
        }
    }
}
