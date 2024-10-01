namespace Nupre_API.DTOs
{
    public class Solicitud_ListadoDTO
    {
        public int Solicitud_Numero { get; set; }
        public DateTime Solicitud_Fecha { get; set; }

        public string? Profesional_Documento { get; set; }

        /// <summary>
        /// Es nombre completo (Nombres  y Apellidos) de cada persona registrada en el padrón de ciudadanos de la TSS.
        /// </summary>
        public string Profesional_Nombre_Completo { get; set; } = null!;

        /// <summary> 
        /// </summary>
       
        public string Profesional_Sexo { get; set; } = null!;

        /// <summary>
        /// Número de Exequátur del Médico.
        /// </summary>
        public string Profesional_Exequatur { get; set; } = null!;
         
         
        public string Profesional_Telefono1 { get; set; } = null!;
 

        public string Profesional_Mail { get; set; } = null!;

        public byte Solicitud_Estado_Numero { get; set; }
        public string Solicitud_estado_Descripcion { get; set; }  = null!;
         

        public string? Solicitud_Estado_Nota { get; set; } 
         

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
