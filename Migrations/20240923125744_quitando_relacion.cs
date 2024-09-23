using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class quitando_relacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Especialidades_Tipos_Cata_Profesionales_Especialidades_Tipos_Ca~",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Solicitudes_Trans_SolicitudNumeroNavigationSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Especialidades_Tipos_CataEspecialidad_Tipo_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_SolicitudNumeroNavigationSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropColumn(
                name: "Profesionales_Especialidades_Tipos_CataEspecialidad_Tipo_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropColumn(
                name: "SolicitudNumeroNavigationSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.AddColumn<int>(
                name: "Profesionales_Solicitudes_TranSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Solicitudes_TranSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "Profesionales_Solicitudes_TranSolicitud_Numero");

            migrationBuilder.AddForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Solicitudes_Trans_Profesionales_Solicitudes_TranSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "Profesionales_Solicitudes_TranSolicitud_Numero",
                principalTable: "Profesionales_Solicitudes_Trans",
                principalColumn: "Solicitud_Numero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Solicitudes_Trans_Profesionales_Solicitudes_TranSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Solicitudes_TranSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropColumn(
                name: "Profesionales_Solicitudes_TranSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.AddColumn<int>(
                name: "Profesionales_Especialidades_Tipos_CataEspecialidad_Tipo_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SolicitudNumeroNavigationSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Especialidades_Tipos_CataEspecialidad_Tipo_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "Profesionales_Especialidades_Tipos_CataEspecialidad_Tipo_Numero");

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_SolicitudNumeroNavigationSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "SolicitudNumeroNavigationSolicitud_Numero");

            migrationBuilder.AddForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Especialidades_Tipos_Cata_Profesionales_Especialidades_Tipos_Ca~",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "Profesionales_Especialidades_Tipos_CataEspecialidad_Tipo_Numero",
                principalTable: "Profesionales_Especialidades_Tipos_Cata",
                principalColumn: "Especialidad_Tipo_Numero",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Solicitudes_Trans_SolicitudNumeroNavigationSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "SolicitudNumeroNavigationSolicitud_Numero",
                principalTable: "Profesionales_Solicitudes_Trans",
                principalColumn: "Solicitud_Numero",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
