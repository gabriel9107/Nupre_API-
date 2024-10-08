﻿namespace Nupre_API.Entidades
{
    public class Profesionales_Asociaciones_Estados_Cata
    {
        public byte AsociacionEstadoNumero { get; set; }

        public string AsociacionEstadoDescripcion { get; set; } = null!;

        public string AsociacionEstadoExplicacion { get; set; } = null!;

        public string AsociacionEstadoPendiente { get; set; } = null!;

        public string AsociacionEstadoNota { get; set; } = null!;

        public string AsociacionEstadoMensaje { get; set; } = null!;

        public string AsociacionEstadoAsociadoMensaje { get; set; } = null!;

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

        public virtual ICollection<Profesionales_Asociaciones_Master> ProfesionalesAsociacionesMasters { get; set; } = new List<Profesionales_Asociaciones_Master>();

        public virtual ICollection<Profesionales_Solicitudes_Asociaciones_Tran> ProfesionalesSolicitudesAsociacionesTrans { get; set; } = new List<Profesionales_Solicitudes_Asociaciones_Tran>();
    }
}
