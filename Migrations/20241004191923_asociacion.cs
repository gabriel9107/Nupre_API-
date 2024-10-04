using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class asociacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Profesionales_Solicitudes_Asociaciones_Trans",
            //    table: "Profesionales_Solicitudes_Asociaciones_Trans");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Solicitud_Numero",
            //    table: "Profesionales_Solicitudes_Asociaciones_Trans",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Asociacion_ID",
                table: "Profesionales_Solicitudes_Asociaciones_Trans",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profesionales_Solicitudes_Asociaciones_Trans",
                table: "Profesionales_Solicitudes_Asociaciones_Trans",
                column: "Asociacion_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Profesionales_Solicitudes_Asociaciones_Trans",
            //    table: "Profesionales_Solicitudes_Asociaciones_Trans");

            migrationBuilder.DropColumn(
                name: "Asociacion_ID",
                table: "Profesionales_Solicitudes_Asociaciones_Trans");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Solicitud_Numero",
            //    table: "Profesionales_Solicitudes_Asociaciones_Trans",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profesionales_Solicitudes_Asociaciones_Trans",
                table: "Profesionales_Solicitudes_Asociaciones_Trans",
                column: "Solicitud_Numero");
        }
    }
}
