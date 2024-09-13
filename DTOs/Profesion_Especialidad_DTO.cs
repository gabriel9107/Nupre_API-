namespace Nupre_API.DTOs
{
    public class Profesion_Especialidad_DTO
    {
        public string TipoTitulo {  get; set; }
        public string Titulo {  get; set; }
        public string RegistroEstado { get; set; } = null!;

        public int Solicitud_Numero { get; set; }

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
