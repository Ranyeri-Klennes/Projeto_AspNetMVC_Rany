using Microsoft.EntityFrameworkCore.Migrations;

namespace MarcarConsulta.Migrations
{
    public partial class Consulta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExameId",
                table: "Pacientes");

            migrationBuilder.RenameColumn(
                name: "PacienteId",
                table: "TiposExames",
                newName: "ExameId");

            migrationBuilder.AddColumn<int>(
                name: "TipoExameId",
                table: "Exames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PacienteExame",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    ExameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacienteExame", x => new { x.ExameId, x.PacienteId });
                    table.ForeignKey(
                        name: "FK_PacienteExame_Exames_ExameId",
                        column: x => x.ExameId,
                        principalTable: "Exames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacienteExame_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PacienteExame_PacienteId",
                table: "PacienteExame",
                column: "PacienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PacienteExame");

            migrationBuilder.DropColumn(
                name: "TipoExameId",
                table: "Exames");

            migrationBuilder.RenameColumn(
                name: "ExameId",
                table: "TiposExames",
                newName: "PacienteId");

            migrationBuilder.AddColumn<int>(
                name: "ExameId",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
