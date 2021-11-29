using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class prrs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "evaluacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Evaluacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evaluacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "migrantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero_identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais_origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_nacimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion_electronica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion_actual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Situacion_laboral = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_migrantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "necesidads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Salud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alimentacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Alimentacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empleo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Empleo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alojamiento_temporal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Alojamiento_temporal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alojamiento_permanente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Alojamiento_permanente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Educacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Educacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ayuda_legal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Ayuda_legal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_necesidads", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "evaluacion");

            migrationBuilder.DropTable(
                name: "migrantes");

            migrationBuilder.DropTable(
                name: "necesidads");
        }
    }
}
