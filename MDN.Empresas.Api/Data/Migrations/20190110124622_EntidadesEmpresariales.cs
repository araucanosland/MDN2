using Microsoft.EntityFrameworkCore.Migrations;

namespace MDN.Empresas.Api.Data.Migrations
{
    public partial class EntidadesEmpresariales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntidadesEmpresariales",
                schema: "empresas",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Rut = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Segmento = table.Column<string>(nullable: true),
                    TipoEntidad = table.Column<int>(nullable: false),
                    PadreId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadesEmpresariales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntidadesEmpresariales_EntidadesEmpresariales_PadreId",
                        column: x => x.PadreId,
                        principalSchema: "empresas",
                        principalTable: "EntidadesEmpresariales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntidadesEmpresariales_PadreId",
                schema: "empresas",
                table: "EntidadesEmpresariales",
                column: "PadreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntidadesEmpresariales",
                schema: "empresas");
        }
    }
}
