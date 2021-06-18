using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen1.Data.Migrations
{
    public partial class AddPacientes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PacienteCodigoArea",
                table: "pacientes",
                newName: "PacienteCodigoAreaTelefono");

            migrationBuilder.AddColumn<int>(
                name: "PacienteCodigoAreaCelular",
                table: "pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PacienteCodigoAreaCelular",
                table: "pacientes");

            migrationBuilder.RenameColumn(
                name: "PacienteCodigoAreaTelefono",
                table: "pacientes",
                newName: "PacienteCodigoArea");
        }
    }
}
