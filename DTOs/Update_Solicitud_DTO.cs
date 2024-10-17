namespace Nupre_API.DTOs
{
    public class Update_Solicitud_DTO
    {
        public int Solicitud_Numero {  get; set; }
        public string? Profesional_Telefono1 { get; set; }
        public string? Profesional_Telefono2 { get; set; }
        public string? Profesional_Telefono3 { get; set; }

        public string? Profesional_Mail { get; set; }    
        public int? Asociacion_Registro_Patronal { get; set; }   
        public string Solicitud_Usuario_Cuenta { get; set; }    
    }
}
