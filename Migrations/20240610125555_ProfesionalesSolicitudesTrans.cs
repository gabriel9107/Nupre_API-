using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class ProfesionalesSolicitudesTrans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "profesionalesSolicitudesTrans",
                columns: table => new
                {
                    ProfesionalesSolicitudesTranId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitudNumero = table.Column<int>(type: "int", nullable: false),
                    SolicitudFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfesionalDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfesionalNombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NacionalidadNumero = table.Column<short>(type: "smallint", nullable: false),
                    ProfesionalSexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfesionalExequatur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfesionalDireccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MunicipioNumero = table.Column<short>(type: "smallint", nullable: false),
                    ProfesionalTelefono1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfesionalTelefono2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfesionalTelefono3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfesionalMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SolicitudEstadoNumero = table.Column<byte>(type: "tinyint", nullable: false),
                    SolicitudEstadoFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SolicitudEstadoNota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SolicitudUsuarioCuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SolicitudActualizarDatos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AsociacionRegistroPatronal = table.Column<int>(type: "int", nullable: false),
                    MotivoNumero = table.Column<byte>(type: "tinyint", nullable: false),
                    SolicitudCertificadoNumero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroFecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profesionalesSolicitudesTrans", x => x.ProfesionalesSolicitudesTranId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "profesionalesSolicitudesTrans");
        }
    }
}
