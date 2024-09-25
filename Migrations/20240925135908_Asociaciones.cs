using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class Asociaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesionales_Asociaciones_Catas",
                columns: table => new
                {
                    Asociacion_Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asociacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Asociaciones_Catas", x => x.Asociacion_Numero);
                });

            migrationBuilder.CreateTable(
                name: "Profesionales_Solicitudes_Asociaciones_Trans",
                columns: table => new
                {
                    Solicitud_Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asociacion_Registro_Patronal = table.Column<int>(type: "int", nullable: false),
                    Profesional_Asociacion_Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documento_Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Asociacion_Asociado_Estado_Numero = table.Column<byte>(type: "tinyint", nullable: false),
                    Asociacion_Asociado_Estado_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Asociacion_Asociado_Estado_Nota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Motivo_Numero = table.Column<byte>(type: "tinyint", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SolicitudNumeroNavigationSolicitud_Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Solicitudes_Asociaciones_Trans", x => x.Solicitud_Numero);
                    table.ForeignKey(
                        name: "FK_Profesionales_Solicitudes_Asociaciones_Trans_Profesionales_Solicitudes_Trans_SolicitudNumeroNavigationSolicitud_Numero",
                        column: x => x.SolicitudNumeroNavigationSolicitud_Numero,
                        principalTable: "Profesionales_Solicitudes_Trans",
                        principalColumn: "Solicitud_Numero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_Solicitudes_Asociaciones_Trans_SolicitudNumeroNavigationSolicitud_Numero",
                table: "Profesionales_Solicitudes_Asociaciones_Trans",
                column: "SolicitudNumeroNavigationSolicitud_Numero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profesionales_Asociaciones_Catas");

            migrationBuilder.DropTable(
                name: "Profesionales_Solicitudes_Asociaciones_Trans");
        }
    }
}
