using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiApp.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    EventoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(nullable: false),
                    EquipoLocal = table.Column<string>(nullable: true),
                    EquipoVisitante = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.EventoId);
                });

            migrationBuilder.CreateTable(
                name: "Mercados",
                columns: table => new
                {
                    MercadoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<double>(nullable: false),
                    CuotaOver = table.Column<double>(nullable: false),
                    CuotaUnder = table.Column<double>(nullable: false),
                    ApostadoOver = table.Column<double>(nullable: false),
                    ApostadoUnder = table.Column<double>(nullable: false),
                    EventoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercados", x => x.MercadoId);
                    table.ForeignKey(
                        name: "FK_Mercados_Eventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Eventos",
                        principalColumn: "EventoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "EventoId", "EquipoLocal", "EquipoVisitante", "Fecha" },
                values: new object[] { 1, "Valencia", "Espanyol", new DateTime(2020, 2, 17, 11, 35, 33, 441, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "EventoId", "EquipoLocal", "EquipoVisitante", "Fecha" },
                values: new object[] { 2, "Barcelona", "Madrid", new DateTime(2020, 2, 17, 11, 35, 33, 449, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.InsertData(
                table: "Mercados",
                columns: new[] { "MercadoId", "ApostadoOver", "ApostadoUnder", "CuotaOver", "CuotaUnder", "EventoId", "Tipo" },
                values: new object[,]
                {
                    { 1, 100.0, 100.0, 1.8999999999999999, 2.5, 1, 1.5 },
                    { 2, 100.0, 100.0, 2.5, 1.8999999999999999, 1, 2.5 },
                    { 3, 100.0, 100.0, 3.0, 1.8999999999999999, 1, 3.3999999999999999 },
                    { 4, 100.0, 100.0, 1.8999999999999999, 2.5, 2, 1.5 },
                    { 5, 100.0, 100.0, 2.5, 1.8999999999999999, 2, 2.5 },
                    { 6, 100.0, 100.0, 3.0, 1.8999999999999999, 2, 3.3999999999999999 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mercados_EventoId",
                table: "Mercados",
                column: "EventoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mercados");

            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
