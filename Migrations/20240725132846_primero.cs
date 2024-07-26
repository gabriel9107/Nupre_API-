using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class primero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "comunesProvinciasCata",
                columns: table => new
                {
                    ProvinciaNumero = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinciaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionSaludNumero = table.Column<byte>(type: "tinyint", nullable: false),
                    RegistroEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroFecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comunesProvinciasCata", x => x.ProvinciaNumero);
                });

            migrationBuilder.CreateTable(
                name: "TSS_Ciudadanos_Master",
                columns: table => new
                {
                    CiudadanoNss = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CiudadanoNombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoPrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoSegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoCivilCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoFechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoFechaNacimientoDti = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CiudadanoNoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentoTipoCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoSexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinciaNumero = table.Column<short>(type: "smallint", nullable: false),
                    SangreTipoNumero = table.Column<byte>(type: "tinyint", nullable: false),
                    CausaInhabilidadNumero = table.Column<short>(type: "smallint", nullable: false),
                    NacionalidadNumero = table.Column<short>(type: "smallint", nullable: false),
                    CiudadanoNoDocumentoAnterior = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoNssEstatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CausaTipoCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoActaNacimientoMunicipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoActaNacimientoAnio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoActaNacimientoNumero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoActaNacimientoFolio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoActaNacimientoLibro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoActaNacimientoOficialia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaActualizacionTss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CiudadanoCedulaFormateada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoNombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadanoActaNacimientoUnida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroFecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSS_Ciudadanos_Master", x => x.CiudadanoNss);
                });

            migrationBuilder.CreateTable(
                name: "TSS_Empleadores_Master",
                columns: table => new
                {
                    EmpleadorRegistroPatronal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpleadorRncOCedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadorRazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadorNombreComercial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadorDireccionCalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadorDireccionNumero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadorDireccionEdificio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadorDireccionPiso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadorDireccionSector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MunicipioNumero = table.Column<short>(type: "smallint", nullable: false),
                    EmpleadorTelefono1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadorTelefono2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActividadEconomicaNumero = table.Column<int>(type: "int", nullable: false),
                    CategoriaRiesgo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpresaTipoCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadorTotalTrabajadores = table.Column<int>(type: "int", nullable: false),
                    EmpleadorSalarioSeguridadSocial = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmpleadorFechaRegistroTss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadorFechaActualizacionTss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadorEstatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntidadRecaudadoraNumero = table.Column<byte>(type: "tinyint", nullable: false),
                    EmpleadorCuentaBanco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadorRncOCedulaSfs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadorTipoCuenta = table.Column<byte>(type: "tinyint", nullable: false),
                    SectorEconomicoNumero = table.Column<byte>(type: "tinyint", nullable: false),
                    SectorSalarialNumero = table.Column<byte>(type: "tinyint", nullable: false),
                    RegistroEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroFecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSS_Empleadores_Master", x => x.EmpleadorRegistroPatronal);
                });

            migrationBuilder.CreateTable(
                name: "comunesMunicipiosCata",
                columns: table => new
                {
                    MunicipioNumero = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MunicipioNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinciaNumero = table.Column<short>(type: "smallint", nullable: false),
                    MunicipioProvinciaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComunesProvinciasCatumProvinciaNumero = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comunesMunicipiosCata", x => x.MunicipioNumero);
                    table.ForeignKey(
                        name: "FK_comunesMunicipiosCata_comunesProvinciasCata_ComunesProvinciasCatumProvinciaNumero",
                        column: x => x.ComunesProvinciasCatumProvinciaNumero,
                        principalTable: "comunesProvinciasCata",
                        principalColumn: "ProvinciaNumero");
                });

            migrationBuilder.CreateTable(
                name: "TSS_Trabajadores_Trans",
                columns: table => new
                {
                    TrabajadorNss = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpleadorRegistroPatronal = table.Column<int>(type: "int", nullable: false),
                    TrabajadorFechaRegistroTss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrabajadorFechaActualizacionTss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrabajadorEstatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrabajadorNssNavigationCiudadanoNss = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSS_Trabajadores_Trans", x => x.TrabajadorNss);
                    table.ForeignKey(
                        name: "FK_TSS_Trabajadores_Trans_TSS_Ciudadanos_Master_TrabajadorNssNavigationCiudadanoNss",
                        column: x => x.TrabajadorNssNavigationCiudadanoNss,
                        principalTable: "TSS_Ciudadanos_Master",
                        principalColumn: "CiudadanoNss",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comunesMunicipiosCata_ComunesProvinciasCatumProvinciaNumero",
                table: "comunesMunicipiosCata",
                column: "ComunesProvinciasCatumProvinciaNumero");

            migrationBuilder.CreateIndex(
                name: "IX_TSS_Trabajadores_Trans_TrabajadorNssNavigationCiudadanoNss",
                table: "TSS_Trabajadores_Trans",
                column: "TrabajadorNssNavigationCiudadanoNss");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comunesMunicipiosCata");

            migrationBuilder.DropTable(
                name: "TSS_Empleadores_Master");

            migrationBuilder.DropTable(
                name: "TSS_Trabajadores_Trans");

            migrationBuilder.DropTable(
                name: "comunesProvinciasCata");

            migrationBuilder.DropTable(
                name: "TSS_Ciudadanos_Master");
        }
    }
}
