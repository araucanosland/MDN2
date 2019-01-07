using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MDN.Empresas.Api.Data.Migrations
{
    public partial class Prospectos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "empresas");

            migrationBuilder.CreateTable(
                name: "EmpresasProspecto",
                schema: "empresas",
                columns: table => new
                {
                    Rut = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Comuna = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    CajaOrigen = table.Column<string>(nullable: true),
                    CantidadTrabajadores = table.Column<int>(nullable: false),
                    Rubro = table.Column<string>(nullable: true),
                    Segmento = table.Column<string>(nullable: true),
                    Categoria = table.Column<string>(nullable: true),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    Oficina = table.Column<int>(nullable: false),
                    Ejecutivo = table.Column<string>(nullable: true),
                    RutHolding = table.Column<string>(nullable: true),
                    NombreHolding = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresasProspecto", x => x.Rut);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaProspectoContactos",
                schema: "empresas",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    TipoContacto = table.Column<string>(nullable: true),
                    NombreContacto = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Oficina = table.Column<int>(nullable: false),
                    Ejecutivo = table.Column<string>(nullable: true),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    EmpresaProspectoRut = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaProspectoContactos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaProspectoContactos_EmpresasProspecto_EmpresaProspectoRut",
                        column: x => x.EmpresaProspectoRut,
                        principalSchema: "empresas",
                        principalTable: "EmpresasProspecto",
                        principalColumn: "Rut",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpresasProspectoGestiones",
                schema: "empresas",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FechaGestion = table.Column<DateTime>(nullable: false),
                    FechaProximaGestion = table.Column<DateTime>(nullable: false),
                    Etapa = table.Column<string>(nullable: true),
                    Comentarios = table.Column<string>(nullable: true),
                    empresaProspectoRut = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresasProspectoGestiones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresasProspectoGestiones_EmpresasProspecto_empresaProspectoRut",
                        column: x => x.empresaProspectoRut,
                        principalSchema: "empresas",
                        principalTable: "EmpresasProspecto",
                        principalColumn: "Rut",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaProspectoContactos_EmpresaProspectoRut",
                schema: "empresas",
                table: "EmpresaProspectoContactos",
                column: "EmpresaProspectoRut");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresasProspectoGestiones_empresaProspectoRut",
                schema: "empresas",
                table: "EmpresasProspectoGestiones",
                column: "empresaProspectoRut");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpresaProspectoContactos",
                schema: "empresas");

            migrationBuilder.DropTable(
                name: "EmpresasProspectoGestiones",
                schema: "empresas");

            migrationBuilder.DropTable(
                name: "EmpresasProspecto",
                schema: "empresas");
        }
    }
}
