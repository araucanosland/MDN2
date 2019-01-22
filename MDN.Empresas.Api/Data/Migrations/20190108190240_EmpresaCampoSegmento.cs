using Microsoft.EntityFrameworkCore.Migrations;

namespace MDN.Empresas.Api.Data.Migrations
{
    public partial class EmpresaCampoSegmento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Segmento",
                schema: "empresas",
                table: "Empresas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Segmento",
                schema: "empresas",
                table: "Empresas");
        }
    }
}
