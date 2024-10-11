namespace Nupre_API.DTOs
{
    public class Crear_Localidades_DTO
    {
        public int? Solicitud_Numero { get; set; }
        public int? Prestadora_Numero { get; set; }

        /// <summary>
        /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
        /// </summary>
        public short? Municipio_Numero { get; set; }

        public string Localidad_Direccion { get; set; } = null!;

        public string? Localidad_Detalle { get; set; } = null!;

        public string? Localidad_Telefono1 { get; set; } = null!;

        public string? Localidad_Telefono2 { get; set; }


    }
}
