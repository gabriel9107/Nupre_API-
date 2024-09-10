using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class EspecialidadesTrans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesionales_Solicitudes_Especialidades_Trans",
                columns: table => new
                {
                    Solicitud_Numero = table.Column<int>(type: "int", nullable: false),
                    Especialidad_Numero = table.Column<short>(type: "smallint", nullable: false),
                    Especialidad_Periodo = table.Column<int>(type: "int", nullable: false),
                    Documento_Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidad_Estado_Numero = table.Column<byte>(type: "tinyint", nullable: false),
                    Especialidad_Estado_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Especialidad_Estado_Nota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disposicion_Numero = table.Column<short>(type: "smallint", nullable: false),
                    Motivo_Numero = table.Column<byte>(type: "tinyint", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Solicitud_Numero_NavigationSolicitudNumero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Solicitudes_Especialidades_Trans", x => new { x.Solicitud_Numero, x.Especialidad_Numero });
                    table.ForeignKey(
                        name: "FK_Profesionales_Solicitudes_Especialidades_Trans_profesionalesSolicitudesTrans_Solicitud_Numero_NavigationSolicitudNumero",
                        column: x => x.Solicitud_Numero_NavigationSolicitudNumero,
                        principalTable: "profesionalesSolicitudesTrans",
                        principalColumn: "SolicitudNumero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_Solicitud_Numero_NavigationSolicitudNumero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "Solicitud_Numero_NavigationSolicitudNumero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profesionales_Solicitudes_Especialidades_Trans");
        }
    }
}
