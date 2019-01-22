using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MDN.Empresas.Api.Data.Migrations
{
    public partial class CarteraEmpresasInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                schema: "empresas",
                columns: table => new
                {
                    Rut = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Holding = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Rut);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaAnexos",
                schema: "empresas",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Comuna = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    EsMatriz = table.Column<bool>(nullable: false),
                    CreadoEn = table.Column<DateTime>(nullable: false),
                    ModificadoEn = table.Column<DateTime>(nullable: true),
                    EmpresaRut = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaAnexos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaAnexos_Empresas_EmpresaRut",
                        column: x => x.EmpresaRut,
                        principalSchema: "empresas",
                        principalTable: "Empresas",
                        principalColumn: "Rut",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AsignacionesAnexoSucursal",
                schema: "empresas",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CodigoSucursal = table.Column<int>(nullable: false),
                    EmpresaAnexoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionesAnexoSucursal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsignacionesAnexoSucursal_EmpresaAnexos_EmpresaAnexoId",
                        column: x => x.EmpresaAnexoId,
                        principalSchema: "empresas",
                        principalTable: "EmpresaAnexos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EjecutivosEncargados",
                schema: "empresas",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Rut = table.Column<string>(nullable: true),
                    AsignacionAnexoSucrsalId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EjecutivosEncargados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EjecutivosEncargados_AsignacionesAnexoSucursal_AsignacionAnexoSucrsalId",
                        column: x => x.AsignacionAnexoSucrsalId,
                        principalSchema: "empresas",
                        principalTable: "AsignacionesAnexoSucursal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesAnexoSucursal_EmpresaAnexoId",
                schema: "empresas",
                table: "AsignacionesAnexoSucursal",
                column: "EmpresaAnexoId");

            migrationBuilder.CreateIndex(
                name: "IX_EjecutivosEncargados_AsignacionAnexoSucrsalId",
                schema: "empresas",
                table: "EjecutivosEncargados",
                column: "AsignacionAnexoSucrsalId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaAnexos_EmpresaRut",
                schema: "empresas",
                table: "EmpresaAnexos",
                column: "EmpresaRut");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EjecutivosEncargados",
                schema: "empresas");

            migrationBuilder.DropTable(
                name: "AsignacionesAnexoSucursal",
                schema: "empresas");

            migrationBuilder.DropTable(
                name: "EmpresaAnexos",
                schema: "empresas");

            migrationBuilder.DropTable(
                name: "Empresas",
                schema: "empresas");
        }
    }
}
