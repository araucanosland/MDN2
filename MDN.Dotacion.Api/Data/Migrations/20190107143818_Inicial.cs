using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MDN.Dotacion.Api.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dotacion");

            migrationBuilder.CreateTable(
                name: "Ausentismos",
                schema: "dotacion",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    Comentarios = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ausentismos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colaboradores",
                schema: "dotacion",
                columns: table => new
                {
                    Rut = table.Column<string>(nullable: false),
                    Apellidos = table.Column<string>(nullable: true),
                    Nombres = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradores", x => x.Rut);
                });

            migrationBuilder.CreateTable(
                name: "DotacionAutorizadas",
                schema: "dotacion",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Sucursal = table.Column<int>(nullable: false),
                    Cargo = table.Column<string>(nullable: true),
                    CreadoEn = table.Column<DateTime>(nullable: false),
                    ModificadoEn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DotacionAutorizadas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DotacionAsignadas",
                schema: "dotacion",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Periodo = table.Column<int>(nullable: false),
                    TipoContrato = table.Column<string>(nullable: true),
                    FechaDesde = table.Column<DateTime>(nullable: false),
                    FechaHasta = table.Column<DateTime>(nullable: false),
                    ReemplazoId = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    ColaboradorAsignadoRut = table.Column<string>(nullable: true),
                    CargoAsignadoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DotacionAsignadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DotacionAsignadas_DotacionAutorizadas_CargoAsignadoId",
                        column: x => x.CargoAsignadoId,
                        principalSchema: "dotacion",
                        principalTable: "DotacionAutorizadas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DotacionAsignadas_Colaboradores_ColaboradorAsignadoRut",
                        column: x => x.ColaboradorAsignadoRut,
                        principalSchema: "dotacion",
                        principalTable: "Colaboradores",
                        principalColumn: "Rut",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DotacionAsignadas_CargoAsignadoId",
                schema: "dotacion",
                table: "DotacionAsignadas",
                column: "CargoAsignadoId");

            migrationBuilder.CreateIndex(
                name: "IX_DotacionAsignadas_ColaboradorAsignadoRut",
                schema: "dotacion",
                table: "DotacionAsignadas",
                column: "ColaboradorAsignadoRut");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ausentismos",
                schema: "dotacion");

            migrationBuilder.DropTable(
                name: "DotacionAsignadas",
                schema: "dotacion");

            migrationBuilder.DropTable(
                name: "DotacionAutorizadas",
                schema: "dotacion");

            migrationBuilder.DropTable(
                name: "Colaboradores",
                schema: "dotacion");
        }
    }
}
