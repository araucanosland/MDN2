using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MDN.Dotacion.Api.Data.Migrations
{
    public partial class CamposNoObligatorios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificadoEn",
                schema: "dotacion",
                table: "DotacionAutorizadas",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaHasta",
                schema: "dotacion",
                table: "DotacionAsignadas",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificadoEn",
                schema: "dotacion",
                table: "DotacionAutorizadas",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaHasta",
                schema: "dotacion",
                table: "DotacionAsignadas",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
