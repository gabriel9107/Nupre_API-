using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "profesionalesEspecialidadesCata",
                columns: table => new
                {
                    EspecialidadNumero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EspecialidadDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EspecialidadTipoNumero = table.Column<byte>(type: "tinyint", nullable: false),
                    EspecialidadProfesionNumero = table.Column<short>(type: "smallint", nullable: false),
                    RegistroEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroFecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profesionalesEspecialidadesCata", x => x.EspecialidadNumero);
                });

            migrationBuilder.CreateTable(
                name: "profesionalesSolicitudesTrans",
                columns: table => new
                {
                    SolicitudNumero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitudFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfesionalDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfesionalNombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NacionalidadNumero = table.Column<short>(type: "smallint", nullable: false),
                    ProfesionalSexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfesionalExequatur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfesionalDireccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MunicipioNumero = table.Column<short>(type: "smallint", nullable: false),
                    ProfesionalTelefono1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfesionalTelefono2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfesionalTelefono3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfesionalMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SolicitudEstadoNumero = table.Column<byte>(type: "tinyint", nullable: false),
                    SolicitudEstadoFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SolicitudEstadoNota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolicitudUsuarioCuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SolicitudActualizarDatos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsociacionRegistroPatronal = table.Column<int>(type: "int", nullable: true),
                    MotivoNumero = table.Column<byte>(type: "tinyint", nullable: true),
                    SolicitudCertificadoNumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistroEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroFecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profesionalesSolicitudesTrans", x => x.SolicitudNumero);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "profesionalesEspecialidadesCata");

            migrationBuilder.DropTable(
                name: "profesionalesSolicitudesTrans");
        }
    }
}
