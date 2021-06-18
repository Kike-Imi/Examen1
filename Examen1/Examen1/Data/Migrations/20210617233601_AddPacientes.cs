using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen1.Data.Migrations
{
    public partial class AddPacientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteSegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteCorreo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteAcompañanteNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteAcompañanteApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteDireccionCalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteDireccionCalleLinea2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteCiudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteProvincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteCodigoPostal = table.Column<int>(type: "int", nullable: false),
                    PacienteCodigoArea = table.Column<int>(type: "int", nullable: false),
                    PacienteNumeroTelefono = table.Column<int>(type: "int", nullable: false),
                    PacienteNumeroCelular = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacientes", x => x.PacienteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pacientes");
        }
    }
}
