namespace Nupre_API.DTOs
{
    public class CrearDocumentoComun_DTO
    {
        
       public int? id {  get; set; }
        public int solicitud_numero { get;set; }
        public string Nombre { get; set; }
        
        public string Documento_ruta { get; set; }

        public int? Tipo_Documento { get; set; } 
        

    }
}
