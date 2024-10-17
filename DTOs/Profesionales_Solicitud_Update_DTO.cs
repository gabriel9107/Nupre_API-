namespace Nupre_API.DTOs
{
    public class Profesionales_Solicitud_Update_DTO
    {
        public int Solicitud_Numero { get; set; }
        
        public string Profesional_Cedula { get; set; } = null!;


        //Numero de relacion con el documento scaneado de la cedula 
        public int Profesional_Documento_Cedula_Numero { get; set; } = 0!;

        /// <summary>
        /// Es nombre completo (Nombres  y Apellidos) de cada persona registrada en el padrón de ciudadanos de la TSS.
        /// </summary>
        public string Profesional_Nombre_Completo { get; set; } = null!;

        /// <summary> 
        /// </summary>
        public short Nacionalidad_Numero { get; set; }

        /// <summary>
        /// Sexo de la persona (Afiliado)  (F=femenino, M=masculino).
        /// </summary>
        public string Profesional_Sexo { get; set; } = null!;

        /// <summary>
        /// Número de Exequátur del Médico.
        /// </summary>
        public string Profesional_Exequatur { get; set; } = null!;

        public int Profesional_Exequatur_Numero { get; set; } = 0!;



        public string Profesional_Direccion { get; set; } = null!;

        /// <summary>
        /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
        /// </summary>
        public short Municipio_Numero { get; set; }

        public string Profesional_Telefono1 { get; set; } = null!;

        public string? Profesional_Telefono2 { get; set; }

        public string? Profesional_Telefono3 { get; set; }

        public string Profesional_Mail { get; set; } = null!;

        public byte Solicitud_Estado_Numero { get; set; }

        public DateTime Solicitud_Estado_Fecha { get; set; }

        public string? Solicitud_Estado_Nota { get; set; }

        public string Solicitud_Usuario_Cuenta { get; set; } = null!;

        public string? Solicitud_Actualizar_Datos { get; set; }

        public int? Asociacion_Registro_Patronal { get; set; }

        public byte? Motivo_Numero { get; set; }

        public string? Solicitud_Certificado_Numero { get; set; } = null!;

        
        public string Registro_Usuario { get; set; } = null!;

    }
}
