namespace Nupre_API.Entidades
{
    public class Profesionales_Estados_Cata
    {
        public byte Profesional_Estado_Numero { get; set; }

        /// <summary>
        /// Es la descripción del tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos Especializado, Centro Ambulatorio General, Hospital General, etc.).
        /// </summary>
        public string Profesional_EstadoDescripcion { get; set; } = null!;

        /// <summary>
        /// Es la explicación del tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos Especializado, Centro Ambulatorio General, Hospital General, etc.).
        /// </summary>
        public string Profesional_Estado_Explicacion { get; set; } = null!;

        public string Profesional_Estado_Pendiente { get; set; } = null!;

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

        public string Profesional_Estado_Nota { get; set; } = null!;

        public string Profesional_Estado_Mensaje { get; set; } = null!;


        public virtual ICollection<Profesionales_Solicitudes_Tran> Profesionales_Solicitudes_trans { get; set; } = new List<Profesionales_Solicitudes_Tran>();
        //public virtual ICollection<ProfesionalesMaster> ProfesionalesMasters { get; set; } = new List<ProfesionalesMaster>();


    }
}
