namespace Nupre_API.DTOs
{
    public class DetalleSolicitudDTO
    {
        public string Nombre { get; set; }
        public string ProfesionalDocumento { get; set; }
        public string ProfesionalTelefono1 { get; set; } = null!;

        public string? ProfesionalTelefono2 { get; set; }

        public string? ProfesionalTelefono3 { get; set; }

        public string ProfesionalMail { get; set; } = null!;
        public byte SolicitudEstadoNumero { get; set; }

        public DateTime SolicitudEstadoFecha { get; set; }
        public string? SolicitudEstadoNota { get; set; }
        public string RegistroEstado { get; set; } = null!;

        public DateTime RegistroFecha { get; set; }

    }
}
