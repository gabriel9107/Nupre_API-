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
    [Migration("20240902195724_CambiosSolicitudes")]
    partial class CambiosSolicitudes
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

            modelBuilder.Entity("Nupre_API.Entidades.ProfesionalesEspecialidadesCata", b =>
                {
                    b.Property<int>("EspecialidadNumero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EspecialidadNumero"));

                    b.Property<string>("EspecialidadDescripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("EspecialidadProfesionNumero")
                        .HasColumnType("smallint");

                    b.Property<byte>("EspecialidadTipoNumero")
                        .HasColumnType("tinyint");

                    b.Property<string>("RegistroEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistroFecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistroUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EspecialidadNumero");

                    b.ToTable("profesionalesEspecialidadesCata");
                });

            modelBuilder.Entity("Nupre_API.Entidades.ProfesionalesSolicitudesTran", b =>
                {
                    b.Property<int>("SolicitudNumero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SolicitudNumero"));

                    b.Property<int?>("AsociacionRegistroPatronal")
                        .HasColumnType("int");

                    b.Property<byte?>("MotivoNumero")
                        .HasColumnType("tinyint");

                    b.Property<short>("MunicipioNumero")
                        .HasColumnType("smallint");

                    b.Property<short>("NacionalidadNumero")
                        .HasColumnType("smallint");

                    b.Property<string>("ProfesionalDireccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalExequatur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalNombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalTelefono1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalTelefono2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalTelefono3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistroEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistroFecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistroUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolicitudActualizarDatos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolicitudCertificadoNumero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SolicitudEstadoFecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("SolicitudEstadoNota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("SolicitudEstadoNumero")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("SolicitudFecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("SolicitudUsuarioCuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SolicitudNumero");

                    b.ToTable("profesionalesSolicitudesTrans");
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

                    b.HasKey("Documento_Codigo");

                    b.ToTable("Profesionales_Documento_Masters");
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
                    b.Property<long>("TrabajadorNss")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TrabajadorNss"));

                    b.Property<int>("EmpleadorRegistroPatronal")
                        .HasColumnType("int");

                    b.Property<string>("RegistroEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistroFecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistroUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrabajadorEstatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TrabajadorFechaActualizacionTss")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TrabajadorFechaRegistroTss")
                        .HasColumnType("datetime2");

                    b.Property<long>("TrabajadorNssNavigationCiudadanoNss")
                        .HasColumnType("bigint");

                    b.HasKey("TrabajadorNss");

                    b.HasIndex("TrabajadorNssNavigationCiudadanoNss");

                    b.ToTable("TSS_Trabajadores_Trans");
                });

            modelBuilder.Entity("Nupre_API.Entidades.ComunesMunicipiosCatum", b =>
                {
                    b.HasOne("Nupre_API.Entidades.ComunesProvinciasCatum", null)
                        .WithMany("ComunesMunicipiosCata")
                        .HasForeignKey("ComunesProvinciasCatumProvinciaNumero");
                });

            modelBuilder.Entity("Nupre_API.Entidades.TssTrabajadoresTran", b =>
                {
                    b.HasOne("Nupre_API.Entidades.TssCiudadanosMaster", "TrabajadorNssNavigation")
                        .WithMany()
                        .HasForeignKey("TrabajadorNssNavigationCiudadanoNss")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrabajadorNssNavigation");
                });

            modelBuilder.Entity("Nupre_API.Entidades.ComunesProvinciasCatum", b =>
                {
                    b.Navigation("ComunesMunicipiosCata");
                });
#pragma warning restore 612, 618
        }
    }
}