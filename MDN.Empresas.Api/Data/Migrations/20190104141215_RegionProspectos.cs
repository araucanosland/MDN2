using Microsoft.EntityFrameworkCore.Migrations;

namespace MDN.Empresas.Api.Data.Migrations
{
    public partial class RegionProspectos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresasProspectoGestiones_EmpresasProspecto_empresaProspectoRut",
                schema: "empresas",
                table: "EmpresasProspectoGestiones");

            migrationBuilder.RenameColumn(
                name: "empresaProspectoRut",
                schema: "empresas",
                table: "EmpresasProspectoGestiones",
                newName: "EmpresaProspectoRut");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresasProspectoGestiones_empresaProspectoRut",
                schema: "empresas",
                table: "EmpresasProspectoGestiones",
                newName: "IX_EmpresasProspectoGestiones_EmpresaProspectoRut");

            migrationBuilder.AddColumn<string>(
                name: "Region",
                schema: "empresas",
                table: "EmpresasProspecto",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresasProspectoGestiones_EmpresasProspecto_EmpresaProspectoRut",
                schema: "empresas",
                table: "EmpresasProspectoGestiones",
                column: "EmpresaProspectoRut",
                principalSchema: "empresas",
                principalTable: "EmpresasProspecto",
                principalColumn: "Rut",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresasProspectoGestiones_EmpresasProspecto_EmpresaProspectoRut",
                schema: "empresas",
                table: "EmpresasProspectoGestiones");

            migrationBuilder.DropColumn(
                name: "Region",
                schema: "empresas",
                table: "EmpresasProspecto");

            migrationBuilder.RenameColumn(
                name: "EmpresaProspectoRut",
                schema: "empresas",
                table: "EmpresasProspectoGestiones",
                newName: "empresaProspectoRut");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresasProspectoGestiones_EmpresaProspectoRut",
                schema: "empresas",
                table: "EmpresasProspectoGestiones",
                newName: "IX_EmpresasProspectoGestiones_empresaProspectoRut");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresasProspectoGestiones_EmpresasProspecto_empresaProspectoRut",
                schema: "empresas",
                table: "EmpresasProspectoGestiones",
                column: "empresaProspectoRut",
                principalSchema: "empresas",
                principalTable: "EmpresasProspecto",
                principalColumn: "Rut",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
