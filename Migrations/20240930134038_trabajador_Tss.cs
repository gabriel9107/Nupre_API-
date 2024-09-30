using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class trabajador_Tss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profesionales_Solicitudes_Asociaciones_Trans_Profesionales_Solicitudes_Trans_SolicitudNumeroNavigationSolicitud_Numero",
                table: "Profesionales_Solicitudes_Asociaciones_Trans");

            migrationBuilder.DropForeignKey(
                name: "FK_TSS_Trabajadores_Trans_TSS_Ciudadanos_Master_TrabajadorNssNavigationCiudadanoNss",
                table: "TSS_Trabajadores_Trans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TSS_Trabajadores_Trans",
                table: "TSS_Trabajadores_Trans");

            migrationBuilder.DropIndex(
                name: "IX_TSS_Trabajadores_Trans_TrabajadorNssNavigationCiudadanoNss",
                table: "TSS_Trabajadores_Trans");

            migrationBuilder.DropIndex(
                name: "IX_Profesionales_Solicitudes_Asociaciones_Trans_SolicitudNumeroNavigationSolicitud_Numero",
                table: "Profesionales_Solicitudes_Asociaciones_Trans");

            migrationBuilder.DropColumn(
                name: "TrabajadorNss",
                table: "TSS_Trabajadores_Trans");

            migrationBuilder.DropColumn(
                name: "SolicitudNumeroNavigationSolicitud_Numero",
                table: "Profesionales_Solicitudes_Asociaciones_Trans");

            migrationBuilder.RenameColumn(
                name: "TrabajadorNssNavigationCiudadanoNss",
                table: "TSS_Trabajadores_Trans",
                newName: "Trabajador_Nss");

            migrationBuilder.RenameColumn(
                name: "TrabajadorFechaRegistroTss",
                table: "TSS_Trabajadores_Trans",
                newName: "Trabajador_Fecha_Actualizacion_Tss");

            migrationBuilder.RenameColumn(
                name: "TrabajadorFechaActualizacionTss",
                table: "TSS_Trabajadores_Trans",
                newName: "Trabajador_FechaRegistro_Tss");

            migrationBuilder.RenameColumn(
                name: "TrabajadorEstatus",
                table: "TSS_Trabajadores_Trans",
                newName: "Trabajador_Estatus");

            migrationBuilder.RenameColumn(
                name: "RegistroUsuario",
                table: "TSS_Trabajadores_Trans",
                newName: "Registro_Usuario");

            migrationBuilder.RenameColumn(
                name: "RegistroFecha",
                table: "TSS_Trabajadores_Trans",
                newName: "Registro_Fecha");

            migrationBuilder.RenameColumn(
                name: "RegistroEstado",
                table: "TSS_Trabajadores_Trans",
                newName: "Registro_Estado");

            migrationBuilder.RenameColumn(
                name: "EmpleadorRegistroPatronal",
                table: "TSS_Trabajadores_Trans",
                newName: "Empleador_Registro_Patronal");

            migrationBuilder.AlterColumn<long>(
                name: "Trabajador_Nss",
                table: "TSS_Trabajadores_Trans",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TSS_Trabajadores_Trans",
                table: "TSS_Trabajadores_Trans",
                column: "Trabajador_Nss");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TSS_Trabajadores_Trans",
                table: "TSS_Trabajadores_Trans");

            migrationBuilder.RenameColumn(
                name: "Trabajador_Fecha_Actualizacion_Tss",
                table: "TSS_Trabajadores_Trans",
                newName: "TrabajadorFechaRegistroTss");

            migrationBuilder.RenameColumn(
                name: "Trabajador_FechaRegistro_Tss",
                table: "TSS_Trabajadores_Trans",
                newName: "TrabajadorFechaActualizacionTss");

            migrationBuilder.RenameColumn(
                name: "Trabajador_Estatus",
                table: "TSS_Trabajadores_Trans",
                newName: "TrabajadorEstatus");

            migrationBuilder.RenameColumn(
                name: "Registro_Usuario",
                table: "TSS_Trabajadores_Trans",
                newName: "RegistroUsuario");

            migrationBuilder.RenameColumn(
                name: "Registro_Fecha",
                table: "TSS_Trabajadores_Trans",
                newName: "RegistroFecha");

            migrationBuilder.RenameColumn(
                name: "Registro_Estado",
                table: "TSS_Trabajadores_Trans",
                newName: "RegistroEstado");

            migrationBuilder.RenameColumn(
                name: "Empleador_Registro_Patronal",
                table: "TSS_Trabajadores_Trans",
                newName: "EmpleadorRegistroPatronal");

            migrationBuilder.RenameColumn(
                name: "Trabajador_Nss",
                table: "TSS_Trabajadores_Trans",
                newName: "TrabajadorNssNavigationCiudadanoNss");

            migrationBuilder.AlterColumn<long>(
                name: "TrabajadorNssNavigationCiudadanoNss",
                table: "TSS_Trabajadores_Trans",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "TrabajadorNss",
                table: "TSS_Trabajadores_Trans",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SolicitudNumeroNavigationSolicitud_Numero",
                table: "Profesionales_Solicitudes_Asociaciones_Trans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TSS_Trabajadores_Trans",
                table: "TSS_Trabajadores_Trans",
                column: "TrabajadorNss");

            migrationBuilder.CreateIndex(
                name: "IX_TSS_Trabajadores_Trans_TrabajadorNssNavigationCiudadanoNss",
                table: "TSS_Trabajadores_Trans",
                column: "TrabajadorNssNavigationCiudadanoNss");

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_Solicitudes_Asociaciones_Trans_SolicitudNumeroNavigationSolicitud_Numero",
                table: "Profesionales_Solicitudes_Asociaciones_Trans",
                column: "SolicitudNumeroNavigationSolicitud_Numero");

            migrationBuilder.AddForeignKey(
                name: "FK_Profesionales_Solicitudes_Asociaciones_Trans_Profesionales_Solicitudes_Trans_SolicitudNumeroNavigationSolicitud_Numero",
                table: "Profesionales_Solicitudes_Asociaciones_Trans",
                column: "SolicitudNumeroNavigationSolicitud_Numero",
                principalTable: "Profesionales_Solicitudes_Trans",
                principalColumn: "Solicitud_Numero",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TSS_Trabajadores_Trans_TSS_Ciudadanos_Master_TrabajadorNssNavigationCiudadanoNss",
                table: "TSS_Trabajadores_Trans",
                column: "TrabajadorNssNavigationCiudadanoNss",
                principalTable: "TSS_Ciudadanos_Master",
                principalColumn: "CiudadanoNss",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
