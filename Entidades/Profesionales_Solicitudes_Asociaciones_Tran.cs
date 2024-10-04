 

namespace Nupre_API.Entidades
{
    public class Profesionales_Solicitudes_Asociaciones_Tran
    {
        public int Asociacion_ID { get; set; }
        public int Solicitud_Numero { get; set; }

        public int Asociacion_Registro_Patronal { get; set; }

        public string Profesional_Asociacion_Codigo { get; set; } = null!;

        public string Documento_Codigo { get; set; } = null!;

        public byte Asociacion_Asociado_Estado_Numero { get; set; }

        public DateTime Asociacion_Asociado_Estado_Fecha { get; set; }

        public string Asociacion_Asociado_Estado_Nota { get; set; } = null!;

        public byte Motivo_Numero { get; set; }

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

        //public virtual ProfesionalesAsociacionesEstadosCatum AsociacionAsociadoEstadoNumeroNavigation { get; set; } = null!;

        //public virtual ProfesionalesAsociacionesMaster AsociacionRegistroPatronalNavigation { get; set; } = null!;

        //public virtual ICollection<ProfesionalesSolicitudesAsociacionesHistorico> ProfesionalesSolicitudesAsociacionesHistoricos { get; set; } = new List<ProfesionalesSolicitudesAsociacionesHistorico>();

        //public virtual Profesionales_Solicitudes_Tran   SolicitudNumeroNavigation { get; set; } = null!;
    }
}
