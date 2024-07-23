namespace Nupre_API.Entidades
{
    public class ProfesionalesMaster
    {
        /// <summary>
        /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
        /// </summary>
        public int ProfesionalNumero { get; set; }

        public string ProfesionalDocumento { get; set; } = null!;

        public long ProfesionalNss { get; set; }

        /// <summary>
        /// Es nombre completo (Nombres  y Apellidos) de cada persona registrada en el padrón de ciudadanos de la TSS.
        /// </summary>
        public string ProfesionalNombreCompleto { get; set; } = null!;

        /// <summary>
        /// Número único que representa la nacionalidad de la persona o afiliado.
        /// </summary>
        public short NacionalidadNumero { get; set; }

        /// <summary>
        /// Sexo de la persona (Afiliado)  (F=femenino, M=masculino).
        /// </summary>
        public string ProfesionalSexo { get; set; } = null!;

        /// <summary>
        /// Número de Exequátur del Médico.
        /// </summary>
        public string ProfesionalExequatur { get; set; } = null!;

        public string ProfesionalDireccion { get; set; } = null!;

        /// <summary>
        /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
        /// </summary>
        public short MunicipioNumero { get; set; }

        public string ProfesionalTelefono1 { get; set; } = null!;

        public string ProfesionalTelefono2 { get; set; } = null!;

        public string ProfesionalTelefono3 { get; set; } = null!;

        public string ProfesionalMail { get; set; } = null!;

        public byte ProfesionalEstadoNumero { get; set; }

        public DateTime ProfesionalEstadoFecha { get; set; }

        public DateTime? ProfesionalAcreditadoFecha { get; set; }

        public int? SolicitudNumero { get; set; }

        public string ProfesionalAuditor { get; set; } = null!;

        public DateTime? ProfesionalAuditorAcreditadoFecha { get; set; }

        public int? SolicitudAuditorNumero { get; set; }

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