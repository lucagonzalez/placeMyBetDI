using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiApp.Migrations
{
    public partial class mi1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2020, 2, 17, 11, 44, 6, 473, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2020, 2, 17, 11, 44, 6, 475, DateTimeKind.Local).AddTicks(9728));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2020, 2, 17, 11, 35, 33, 441, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2020, 2, 17, 11, 35, 33, 449, DateTimeKind.Local).AddTicks(4978));
        }
    }
}
