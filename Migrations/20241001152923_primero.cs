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
                name: "Comunes_Provincias_Cata",
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
                    table.PrimaryKey("PK_Comunes_Provincias_Cata", x => x.ProvinciaNumero);
                });

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
                name: "Profesionales_Documento_Masters",
                columns: table => new
                {
                    Documento_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_Documento = table.Column<int>(type: "int", nullable: false),
                    Documento_ruta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Documento_Masters", x => x.Documento_Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Profesionales_Especialidades_Cata",
                columns: table => new
                {
                    Especialidad_Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especialidad_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidad_Tipo_Numero = table.Column<byte>(type: "tinyint", nullable: false),
                    Especialidad_Profesion_Numero = table.Column<short>(type: "smallint", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Especialidades_Cata", x => x.Especialidad_Numero);
                });

            migrationBuilder.CreateTable(
                name: "Profesionales_Especialidades_Tipos_Cata",
                columns: table => new
                {
                    Especialidad_Tipo_Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especialidad_Tipo_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidad_Tipo_Explicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Especialidades_Tipos_Cata", x => x.Especialidad_Tipo_Numero);
                });

            migrationBuilder.CreateTable(
                name: "profesionales_Estados_Catas",
                columns: table => new
                {
                    Profesional_Estado_Numero = table.Column<byte>(type: "tinyint", nullable: false),
                    Profesional_EstadoDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profesional_Estado_Explicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profesional_Estado_Pendiente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Profesional_Estado_Nota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profesional_Estado_Mensaje = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profesionales_Estados_Catas", x => x.Profesional_Estado_Numero);
                });

            migrationBuilder.CreateTable(
                name: "Profesionales_Requerimientos_Cata",
                columns: table => new
                {
                    Requerimiento_Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requerimiento_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requerimiento_Orden = table.Column<int>(type: "int", nullable: false),
                    Requerimiento_Obligatorio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requerimiento_Fecha_Vencimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aplica_Numero = table.Column<int>(type: "int", nullable: false),
                    Requerimiento_Aplica_Renovacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Requerimientos_Cata", x => x.Requerimiento_Numero);
                });

            migrationBuilder.CreateTable(
                name: "Profesionales_Solicitudes_Actividades_Trans",
                columns: table => new
                {
                    Actividad_Secuencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Solicitud_Numero = table.Column<int>(type: "int", nullable: false),
                    Solicitud_Tipo_Numero = table.Column<int>(type: "int", nullable: false),
                    Actividad_Numero = table.Column<int>(type: "int", nullable: false),
                    Actividad_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Actividad_Contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sometimiento_Secuencia = table.Column<int>(type: "int", nullable: false),
                    RegistroEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroFecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Solicitudes_Actividades_Trans", x => x.Actividad_Secuencia);
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
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Solicitudes_Asociaciones_Trans", x => x.Solicitud_Numero);
                });

            migrationBuilder.CreateTable(
                name: "Profesionales_Solicitudes_Localidades_Trans",
                columns: table => new
                {
                    Solicitud_Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Localidad_Secuencia = table.Column<int>(type: "int", nullable: false),
                    Prestadora_Numero = table.Column<int>(type: "int", nullable: false),
                    Municipio_Numero = table.Column<short>(type: "smallint", nullable: false),
                    Localidad_Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad_Detalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad_Telefono1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad_Telefono2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad_Prestadora_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Solicitudes_Localidades_Trans", x => x.Solicitud_Numero);
                });

            migrationBuilder.CreateTable(
                name: "Profesionales_Solicitudes_Trans",
                columns: table => new
                {
                    Solicitud_Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Solicitud_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Profesional_Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profesional_Nombre_Completo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidad_Numero = table.Column<short>(type: "smallint", nullable: false),
                    Profesional_Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profesional_Exequatur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profesional_Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Municipio_Numero = table.Column<short>(type: "smallint", nullable: false),
                    Profesional_Telefono1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profesional_Telefono2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profesional_Telefono3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profesional_Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Solicitud_Estado_Numero = table.Column<byte>(type: "tinyint", nullable: false),
                    Solicitud_Estado_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Solicitud_Estado_Nota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Solicitud_Usuario_Cuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Solicitud_Actualizar_Datos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asociacion_Registro_Patronal = table.Column<int>(type: "int", nullable: true),
                    Motivo_Numero = table.Column<byte>(type: "tinyint", nullable: true),
                    Solicitud_Certificado_Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Solicitudes_Trans", x => x.Solicitud_Numero);
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
                name: "TSS_Nacionalidades_Cata",
                columns: table => new
                {
                    Nacionalidad_Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nacionalidad_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidad_Pais_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSS_Nacionalidades_Cata", x => x.Nacionalidad_Numero);
                });

            migrationBuilder.CreateTable(
                name: "TSS_Trabajadores_Trans",
                columns: table => new
                {
                    Empleador_Registro_Patronal = table.Column<int>(type: "int", nullable: false),
                    Trabajador_Nss = table.Column<long>(type: "bigint", nullable: false),
                    Trabajador_Fecha_Registro_Tss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trabajador_Fecha_Actualizacion_Tss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trabajador_Estatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSS_Trabajadores_Trans", x => new { x.Trabajador_Nss, x.Empleador_Registro_Patronal });
                });

            migrationBuilder.CreateTable(
                name: "Comunes_Municipios_Cata",
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
                    table.PrimaryKey("PK_Comunes_Municipios_Cata", x => x.MunicipioNumero);
                    table.ForeignKey(
                        name: "FK_Comunes_Municipios_Cata_Comunes_Provincias_Cata_ComunesProvinciasCatumProvinciaNumero",
                        column: x => x.ComunesProvinciasCatumProvinciaNumero,
                        principalTable: "Comunes_Provincias_Cata",
                        principalColumn: "ProvinciaNumero");
                });

            migrationBuilder.CreateTable(
                name: "Profesionales_Solicitudes_Especialidades_Trans",
                columns: table => new
                {
                    Solicitud_Numero = table.Column<int>(type: "int", nullable: false),
                    Especialidad_Numero = table.Column<short>(type: "smallint", nullable: false),
                    Especialidad_Tipo_Numero = table.Column<byte>(type: "tinyint", nullable: false),
                    Especialidad_Periodo = table.Column<int>(type: "int", nullable: false),
                    Documento_Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidad_Estado_Numero = table.Column<byte>(type: "tinyint", nullable: false),
                    Especialidad_Estado_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Especialidad_Estado_Nota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disposicion_Numero = table.Column<short>(type: "smallint", nullable: true),
                    Motivo_Numero = table.Column<byte>(type: "tinyint", nullable: true),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Especialidades_CataEspecialidad_Numero = table.Column<int>(type: "int", nullable: false),
                    Profesionales_Solicitudes_TranSolicitud_Numero = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Solicitudes_Especialidades_Trans", x => new { x.Solicitud_Numero, x.Especialidad_Numero });
                    table.ForeignKey(
                        name: "FK_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Especialidades_Cata_Especialidades_CataEspecialidad_Numero",
                        column: x => x.Especialidades_CataEspecialidad_Numero,
                        principalTable: "Profesionales_Especialidades_Cata",
                        principalColumn: "Especialidad_Numero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Solicitudes_Trans_Profesionales_Solicitudes_TranSolicitud_Numero",
                        column: x => x.Profesionales_Solicitudes_TranSolicitud_Numero,
                        principalTable: "Profesionales_Solicitudes_Trans",
                        principalColumn: "Solicitud_Numero");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comunes_Municipios_Cata_ComunesProvinciasCatumProvinciaNumero",
                table: "Comunes_Municipios_Cata",
                column: "ComunesProvinciasCatumProvinciaNumero");

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_Especialidades_CataEspecialidad_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "Especialidades_CataEspecialidad_Numero");

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Solicitudes_TranSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "Profesionales_Solicitudes_TranSolicitud_Numero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comunes_Municipios_Cata");

            migrationBuilder.DropTable(
                name: "Profesionales_Asociaciones_Catas");

            migrationBuilder.DropTable(
                name: "Profesionales_Documento_Masters");

            migrationBuilder.DropTable(
                name: "Profesionales_Especialidades_Tipos_Cata");

            migrationBuilder.DropTable(
                name: "profesionales_Estados_Catas");

            migrationBuilder.DropTable(
                name: "Profesionales_Requerimientos_Cata");

            migrationBuilder.DropTable(
                name: "Profesionales_Solicitudes_Actividades_Trans");

            migrationBuilder.DropTable(
                name: "Profesionales_Solicitudes_Asociaciones_Trans");

            migrationBuilder.DropTable(
                name: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropTable(
                name: "Profesionales_Solicitudes_Localidades_Trans");

            migrationBuilder.DropTable(
                name: "TSS_Ciudadanos_Master");

            migrationBuilder.DropTable(
                name: "TSS_Empleadores_Master");

            migrationBuilder.DropTable(
                name: "TSS_Nacionalidades_Cata");

            migrationBuilder.DropTable(
                name: "TSS_Trabajadores_Trans");

            migrationBuilder.DropTable(
                name: "Comunes_Provincias_Cata");

            migrationBuilder.DropTable(
                name: "Profesionales_Especialidades_Cata");

            migrationBuilder.DropTable(
                name: "Profesionales_Solicitudes_Trans");
        }
    }
}
