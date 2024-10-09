
using System.ComponentModel.DataAnnotations;

namespace Nupre_API.Entidades
{
    public class Profesionales_Solicitudes_Especialidades_Trans
    {
        public int Solicitud_Numero { get; set; }

        /// <summary>
        /// Numero de la especialidad médica. 
        /// </summary>
        public short Especialidad_Numero { get; set; }

        public byte Especialidad_Tipo_Numero { get; set; }
        
        public string? Especialidad_Periodo { get; set; }

        public string Documento_Codigo { get; set; } = null!;

        public byte Especialidad_Estado_Numero { get; set; }
        
        public DateTime Especialidad_Estado_Fecha { get; set; }

        public string? Especialidad_Estado_Nota { get; set; }

        public short? Disposicion_Numero { get; set; }

        public byte? Motivo_Numero { get; set; }

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

        //public string EspecialidadesCata { get; set; }= null!;

        public Profesionales_Especialidades_Cata Especialidades_Cata { get; set; }

        //public virtual Profesionales_Solicitudes_Tran SolicitudNumeroNavigation { get; set; } = null!;

        //public virtual Profesionales_Especialidades_Tipos_Cata Profesionales_Especialidades_Tipos_Cata { get; set; } = null!;


        
        //public virtual ProfesionalesEspecialidadesEstadosCatum EspecialidadEstadoNumeroNavigation { get; set; } = null!;

        //public virtual ProfesionalesSolicitudesTran SolicitudNumeroNavigation { get; set; } = null!;
        //public virtual ProfesionalesEspecialidadesEstadosCatum EspecialidadEstadoNumeroNavigation { get; set; } = null!;

        //public virtual ICollection<ProfesionalesSolicitudesEspecialidadesHistorico> ProfesionalesSolicitudesEspecialidadesHistoricos { get; set; } = new List<ProfesionalesSolicitudesEspecialidadesHistorico>();


    }
}
