namespace Nupre_API.Entidades
{
    public class ProfesionalesEspecialidadesCata
    {

        /// <summary>
        /// Numero de la especialidad médica. 
        /// </summary>
        public int Especialidad_Numero { get; set; }

        /// <summary>
        /// Descripción de la especialidad médica.
        /// </summary>
        public string Especialidad_Descripcion { get; set; } = null!;

        public byte Especialidad_Tipo_Numero { get; set; }

        public short Especialidad_Profesion_Numero { get; set; }

        /// <summary>
        /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
        /// </summary>
        public string Registro_Estado { get; set; } = null!;

        /// <summary>
        /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
        /// </summary>
        public string Registro_Usuario { get; set; } = null!;

        /// <summary>
        /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
        /// </summary>
        public DateTime Registro_Fecha { get; set; }
    }
}
