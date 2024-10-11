using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class localidadestrans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Profesionales_Solicitudes_Localidades_Trans",
            //    table: "Profesionales_Solicitudes_Localidades_Trans");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Localidad_Secuencia",
            //    table: "Profesionales_Solicitudes_Localidades_Trans",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .Annotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Solicitud_Numero",
            //    table: "Profesionales_Solicitudes_Localidades_Trans",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Profesionales_Solicitudes_Localidades_Trans",
            //    table: "Profesionales_Solicitudes_Localidades_Trans",
            //    column: "Localidad_Secuencia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Profesionales_Solicitudes_Localidades_Trans",
            //    table: "Profesionales_Solicitudes_Localidades_Trans");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Solicitud_Numero",
            //    table: "Profesionales_Solicitudes_Localidades_Trans",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .Annotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Localidad_Secuencia",
            //    table: "Profesionales_Solicitudes_Localidades_Trans",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Profesionales_Solicitudes_Localidades_Trans",
            //    table: "Profesionales_Solicitudes_Localidades_Trans",
            //    column: "Solicitud_Numero");
        }
    }
}
