﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nupre_API;

#nullable disable

namespace Nupre_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241002140921_solicitudes")]
    partial class solicitudes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Nupre_API.Entidades.ComunesMunicipiosCatum", b =>
                {
                    b.Property<short>("MunicipioNumero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("MunicipioNumero"));

                    b.Property<short?>("ComunesProvinciasCatumProvinciaNumero")
                        .HasColumnType("smallint");

                    b.Property<string>("MunicipioNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MunicipioProvinciaNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("ProvinciaNumero")
                        .HasColumnType("smallint");

                    b.Property<string>("RegistroEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistroFecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistroUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MunicipioNumero");

                    b.HasIndex("ComunesProvinciasCatumProvinciaNumero");

                    b.ToTable("Comunes_Municipios_Cata");
                });

            modelBuilder.Entity("Nupre_API.Entidades.ComunesProvinciasCatum", b =>
                {
                    b.Property<short>("ProvinciaNumero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ProvinciaNumero"));

                    b.Property<string>("ProvinciaNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("RegionSaludNumero")
                        .HasColumnType("tinyint");

                    b.Property<string>("RegistroEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistroFecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistroUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinciaNumero");

                    b.ToTable("Comunes_Provincias_Cata");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Profesionales_Asociaciones_Tipo_Cata", b =>
                {
                    b.Property<int>("Asociacion_Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Asociacion_Numero"));

                    b.Property<string>("Asociacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registro_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registro_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Registro_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Asociacion_Numero");

                    b.ToTable("Profesionales_Asociaciones_Catas");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Profesionales_Documento_Master", b =>
                {
                    b.Property<int>("Documento_Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Documento_Codigo"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento_ruta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registro_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registro_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Registro_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo_Documento")
                        .HasColumnType("int");

                    b.HasKey("Documento_Codigo");

                    b.ToTable("Profesionales_Documento_Masters");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Profesionales_Especialidades_Cata", b =>
                {
                    b.Property<int>("Especialidad_Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Especialidad_Numero"));

                    b.Property<string>("Especialidad_Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Especialidad_Profesion_Numero")
                        .HasColumnType("smallint");

                    b.Property<byte>("Especialidad_Tipo_Numero")
                        .HasColumnType("tinyint");

                    b.Property<string>("Registro_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registro_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Registro_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Especialidad_Numero");

                    b.ToTable("Profesionales_Especialidades_Cata");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Profesionales_Especialidades_Tipos_Cata", b =>
                {
                    b.Property<int>("Especialidad_Tipo_Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Especialidad_Tipo_Numero"));

                    b.Property<string>("Especialidad_Tipo_Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad_Tipo_Explicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registro_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registro_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Registro_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Especialidad_Tipo_Numero");

                    b.ToTable("Profesionales_Especialidades_Tipos_Cata");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Profesionales_Estados_Cata", b =>
                {
                    b.Property<byte>("Profesional_Estado_Numero")
                        .HasColumnType("tinyint");

                    b.Property<string>("Profesional_EstadoDescripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesional_Estado_Explicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesional_Estado_Mensaje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesional_Estado_Nota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesional_Estado_Pendiente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registro_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registro_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Registro_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Profesional_Estado_Numero");

                    b.ToTable("profesionales_Estados_Catas");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Profesionales_Requerimiento_Cata", b =>
                {
                    b.Property<int>("Requerimiento_Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Requerimiento_Numero"));

                    b.Property<int>("Aplica_Numero")
                        .HasColumnType("int");

                    b.Property<string>("Registro_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registro_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Requerimiento_Aplica_Renovacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requerimiento_Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requerimiento_Fecha_Vencimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requerimiento_Obligatorio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Requerimiento_Orden")
                        .HasColumnType("int");

                    b.HasKey("Requerimiento_Numero");

                    b.ToTable("Profesionales_Requerimientos_Cata");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Profesionales_Solicitudes_Asociaciones_Tran", b =>
                {
                    b.Property<int>("Solicitud_Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Solicitud_Numero"));

                    b.Property<DateTime>("Asociacion_Asociado_Estado_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Asociacion_Asociado_Estado_Nota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Asociacion_Asociado_Estado_Numero")
                        .HasColumnType("tinyint");

                    b.Property<int>("Asociacion_Registro_Patronal")
                        .HasColumnType("int");

                    b.Property<string>("Documento_Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Motivo_Numero")
                        .HasColumnType("tinyint");

                    b.Property<string>("Profesional_Asociacion_Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registro_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registro_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Registro_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Solicitud_Numero");

                    b.ToTable("Profesionales_Solicitudes_Asociaciones_Trans");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Profesionales_Solicitudes_Especialidades_Trans", b =>
                {
                    b.Property<int>("Solicitud_Numero")
                        .HasColumnType("int");

                    b.Property<short>("Especialidad_Numero")
                        .HasColumnType("smallint");

                    b.Property<short?>("Disposicion_Numero")
                        .HasColumnType("smallint");

                    b.Property<string>("Documento_Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Especialidad_Estado_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Especialidad_Estado_Nota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Especialidad_Estado_Numero")
                        .HasColumnType("tinyint");

                    b.Property<int>("Especialidad_Periodo")
                        .HasColumnType("int");

                    b.Property<byte>("Especialidad_Tipo_Numero")
                        .HasColumnType("tinyint");

                    b.Property<int>("Especialidades_CataEspecialidad_Numero")
                        .HasColumnType("int");

                    b.Property<byte?>("Motivo_Numero")
                        .HasColumnType("tinyint");

                    b.Property<string>("Registro_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registro_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Registro_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Solicitud_Numero", "Especialidad_Numero");

                    b.HasIndex("Especialidades_CataEspecialidad_Numero");

                    b.ToTable("Profesionales_Solicitudes_Especialidades_Trans");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Profesionales_Solicitudes_Localidades_Tran", b =>
                {
                    b.Property<int>("Solicitud_Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Solicitud_Numero"));

                    b.Property<string>("Localidad_Detalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidad_Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidad_Prestadora_Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Localidad_Secuencia")
                        .HasColumnType("int");

                    b.Property<string>("Localidad_Telefono1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidad_Telefono2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Municipio_Numero")
                        .HasColumnType("smallint");

                    b.Property<int>("Prestadora_Numero")
                        .HasColumnType("int");

                    b.Property<string>("Registro_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registro_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Registro_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Solicitud_Numero");

                    b.ToTable("Profesionales_Solicitudes_Localidades_Trans");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Profesionales_Solicitudes_Tran", b =>
                {
                    b.Property<int>("Solicitud_Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Solicitud_Numero"));

                    b.Property<int?>("Asociacion_Registro_Patronal")
                        .HasColumnType("int");

                    b.Property<byte?>("Motivo_Numero")
                        .HasColumnType("tinyint");

                    b.Property<short>("Municipio_Numero")
                        .HasColumnType("smallint");

                    b.Property<short>("Nacionalidad_Numero")
                        .HasColumnType("smallint");

                    b.Property<string>("Profesional_Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesional_Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Profesional_Documento_Cedula_Numero")
                        .HasColumnType("int");

                    b.Property<string>("Profesional_Exequatur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Profesional_Exequatur_Numero")
                        .HasColumnType("int");

                    b.Property<string>("Profesional_Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesional_Nombre_Completo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesional_Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesional_Telefono1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesional_Telefono2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesional_Telefono3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registro_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registro_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Registro_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("SolicitudEstadoNumeroNavigationProfesional_Estado_Numero")
                        .HasColumnType("tinyint");

                    b.Property<string>("Solicitud_Actualizar_Datos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Solicitud_Certificado_Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Solicitud_Estado_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Solicitud_Estado_Nota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Solicitud_Estado_Numero")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("Solicitud_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Solicitud_Usuario_Cuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Solicitud_Numero");

                    b.HasIndex("SolicitudEstadoNumeroNavigationProfesional_Estado_Numero");

                    b.ToTable("Profesionales_Solicitudes_Trans");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Solicitudes_Actividades_Trans", b =>
                {
                    b.Property<int>("Actividad_Secuencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Actividad_Secuencia"));

                    b.Property<string>("Actividad_Contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Actividad_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Actividad_Numero")
                        .HasColumnType("int");

                    b.Property<string>("RegistroEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistroFecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistroUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Solicitud_Numero")
                        .HasColumnType("int");

                    b.Property<int>("Solicitud_Tipo_Numero")
                        .HasColumnType("int");

                    b.Property<int>("Sometimiento_Secuencia")
                        .HasColumnType("int");

                    b.HasKey("Actividad_Secuencia");

                    b.ToTable("Profesionales_Solicitudes_Actividades_Trans");
                });

            modelBuilder.Entity("Nupre_API.Entidades.TSSNacionalidadesCata", b =>
                {
                    b.Property<int>("Nacionalidad_Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Nacionalidad_Numero"));

                    b.Property<string>("Nacionalidad_Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidad_Pais_Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registro_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registro_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Registro_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nacionalidad_Numero");

                    b.ToTable("TSS_Nacionalidades_Cata");
                });

            modelBuilder.Entity("Nupre_API.Entidades.TssCiudadanosMaster", b =>
                {
                    b.Property<long>("CiudadanoNss")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CiudadanoNss"));

                    b.Property<short>("CausaInhabilidadNumero")
                        .HasColumnType("smallint");

                    b.Property<string>("CausaTipoCodigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoActaNacimientoAnio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoActaNacimientoFolio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoActaNacimientoLibro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoActaNacimientoMunicipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoActaNacimientoNumero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoActaNacimientoOficialia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoActaNacimientoUnida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoCedulaFormateada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoFechaNacimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CiudadanoFechaNacimientoDti")
                        .HasColumnType("datetime2");

                    b.Property<string>("CiudadanoNoDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoNoDocumentoAnterior")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoNombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoNombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoNssEstatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoPrimerApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoSegundoApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadanoSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentoTipoCodigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoCivilCodigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaActualizacionTss")
                        .HasColumnType("datetime2");

                    b.Property<short>("NacionalidadNumero")
                        .HasColumnType("smallint");

                    b.Property<short>("ProvinciaNumero")
                        .HasColumnType("smallint");

                    b.Property<string>("RegistroEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistroFecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistroUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("SangreTipoNumero")
                        .HasColumnType("tinyint");

                    b.HasKey("CiudadanoNss");

                    b.ToTable("TSS_Ciudadanos_Master");
                });

            modelBuilder.Entity("Nupre_API.Entidades.TssEmpleadoresMaster", b =>
                {
                    b.Property<int>("EmpleadorRegistroPatronal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpleadorRegistroPatronal"));

                    b.Property<int>("ActividadEconomicaNumero")
                        .HasColumnType("int");

                    b.Property<string>("CategoriaRiesgo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpleadorCuentaBanco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpleadorDireccionCalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpleadorDireccionEdificio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpleadorDireccionNumero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpleadorDireccionPiso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpleadorDireccionSector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpleadorEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpleadorEstatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EmpleadorFechaActualizacionTss")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EmpleadorFechaRegistroTss")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmpleadorNombreComercial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpleadorRazonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpleadorRncOCedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpleadorRncOCedulaSfs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("EmpleadorSalarioSeguridadSocial")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("EmpleadorTelefono1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpleadorTelefono2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("EmpleadorTipoCuenta")
                        .HasColumnType("tinyint");

                    b.Property<int>("EmpleadorTotalTrabajadores")
                        .HasColumnType("int");

                    b.Property<string>("EmpresaTipoCodigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("EntidadRecaudadoraNumero")
                        .HasColumnType("tinyint");

                    b.Property<short>("MunicipioNumero")
                        .HasColumnType("smallint");

                    b.Property<string>("RegistroEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistroFecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistroUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("SectorEconomicoNumero")
                        .HasColumnType("tinyint");

                    b.Property<byte>("SectorSalarialNumero")
                        .HasColumnType("tinyint");

                    b.HasKey("EmpleadorRegistroPatronal");

                    b.ToTable("TSS_Empleadores_Master");
                });

            modelBuilder.Entity("Nupre_API.Entidades.TssTrabajadoresTran", b =>
                {
                    b.Property<long>("Trabajador_Nss")
                        .HasColumnType("bigint");

                    b.Property<int>("Empleador_Registro_Patronal")
                        .HasColumnType("int");

                    b.Property<string>("Registro_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registro_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Registro_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trabajador_Estatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Trabajador_Fecha_Actualizacion_Tss")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Trabajador_Fecha_Registro_Tss")
                        .HasColumnType("datetime2");

                    b.HasKey("Trabajador_Nss", "Empleador_Registro_Patronal");

                    b.ToTable("TSS_Trabajadores_Trans");
                });

            modelBuilder.Entity("Nupre_API.Entidades.ComunesMunicipiosCatum", b =>
                {
                    b.HasOne("Nupre_API.Entidades.ComunesProvinciasCatum", null)
                        .WithMany("ComunesMunicipiosCata")
                        .HasForeignKey("ComunesProvinciasCatumProvinciaNumero");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Profesionales_Solicitudes_Especialidades_Trans", b =>
                {
                    b.HasOne("Nupre_API.Entidades.Profesionales_Especialidades_Cata", "Especialidades_Cata")
                        .WithMany()
                        .HasForeignKey("Especialidades_CataEspecialidad_Numero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidades_Cata");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Profesionales_Solicitudes_Tran", b =>
                {
                    b.HasOne("Nupre_API.Entidades.Profesionales_Estados_Cata", "SolicitudEstadoNumeroNavigation")
                        .WithMany("Profesionales_Solicitudes_trans")
                        .HasForeignKey("SolicitudEstadoNumeroNavigationProfesional_Estado_Numero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SolicitudEstadoNumeroNavigation");
                });

            modelBuilder.Entity("Nupre_API.Entidades.ComunesProvinciasCatum", b =>
                {
                    b.Navigation("ComunesMunicipiosCata");
                });

            modelBuilder.Entity("Nupre_API.Entidades.Profesionales_Estados_Cata", b =>
                {
                    b.Navigation("Profesionales_Solicitudes_trans");
                });
#pragma warning restore 612, 618
        }
    }
}