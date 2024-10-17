namespace Nupre_API.Entidades
{
    public class Detalle_Profesional_Solicitudes_DTO
    {
        public int Solicitud_Numero { get; set; }
        public DateTime Solicitud_Fecha { get; set; }

        public string Profesional_Cedula { get; set; } = null!;


        //Numero de relacion con el documento scaneado de la cedula 
        public int Profesional_Documento_Cedula_Numero { get; set; } = 0!;

        /// <summary>
        /// Es nombre completo (Nombres  y Apellidos) de cada persona registrada en el padrón de ciudadanos de la TSS.
        /// </summary>
        public string Profesional_Nombre_Completo { get; set; } = null!;

        
        public string Profesional_Exequatur { get; set; } = null!;

        public int Profesional_Exequatur_Numero { get; set; } = 0!;


         
        public string Profesional_Telefono1 { get; set; } = null!;

        public string? Profesional_Telefono2 { get; set; }

        public string? Profesional_Telefono3 { get; set; }

        public string Profesional_Mail { get; set; } = null!;

        public byte Solicitud_Estado_Numero { get; set; }

        public string? Solicitud_Estado_Nota { get; set; }

        public string Solicitud_Usuario_Cuenta { get; set; } = null!;

        public int? Asociacion_Registro_Patronal { get; set; }

        public byte? Motivo_Numero { get; set; }

        public string? Solicitud_Certificado_Numero { get; set; } = null!;

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
