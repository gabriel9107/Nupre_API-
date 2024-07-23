namespace Nupre_API.Entidades
{
    public class ProfesionalesEspecialidadesCata
    {

        /// <summary>
        /// Numero de la especialidad médica. 
        /// </summary>
        public int EspecialidadNumero { get; set; }

        /// <summary>
        /// Descripción de la especialidad médica.
        /// </summary>
        public string EspecialidadDescripcion { get; set; } = null!;

        public byte EspecialidadTipoNumero { get; set; }

        public short EspecialidadProfesionNumero { get; set; }

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
