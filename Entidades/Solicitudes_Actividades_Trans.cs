namespace Nupre_API.Entidades
{
    public class Solicitudes_Actividades_Trans
    {
        public int Actividad_Secuencia { get; set; }
        public int Solicitud_Numero { get; set; }
        public int Solicitud_Tipo_Numero { get; set; }
        public int Actividad_Numero { get; set; }
        public DateTime Actividad_Fecha { get; set; }
        public string Actividad_Contenido { get; set; }
        public int Sometimiento_Secuencia { get; set; }

        /// <summary>
        /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
        /// </summary>
        public string RegistroEstado { get; set; } = null!;

        /// <summary>
        /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
        /// </summary>
        public string RegistroUsuario { get; set; } = null!;

        /// <summary>
        /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
        /// </summary>
        public DateTime RegistroFecha { get; set; }
         

    }
}
