namespace Nupre_API.Entidades
{
    public class Profesionales_Solicitudes_Localidades_Tran
    {


        /// <summary>
        /// Número único de la Solicitud.
        /// </summary>
        public int Solicitud_Numero { get; set; }

        public int Localidad_Secuencia { get; set; }

        /// <summary>
        /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
        /// </summary>
        public int Prestadora_Numero { get; set; }

        /// <summary>
        /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
        /// </summary>
        public short Municipio_Numero { get; set; }

        public string Localidad_Direccion { get; set; } = null!;

        public string Localidad_Detalle { get; set; } = null!;

        public string Localidad_Telefono1 { get; set; } = null!;

        public string Localidad_Telefono2 { get; set; } = null!;

        public string Localidad_Prestadora_Nombre { get; set; } = null!;

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
