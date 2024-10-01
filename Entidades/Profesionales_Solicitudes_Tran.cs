﻿namespace Nupre_API.Entidades
{
    public class Profesionales_Solicitudes_Tran
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
        public short Nacionalidad_Numero { get; set; }

        /// <summary>
        /// Sexo de la persona (Afiliado)  (F=femenino, M=masculino).
        /// </summary>
        public string Profesional_Sexo { get; set; } = null!;

        /// <summary>
        /// Número de Exequátur del Médico.
        /// </summary>
        public string Profesional_Exequatur { get; set; } = null!;

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



        //public virtual ICollection<Profesionales_Solicitudes_Especialidades_Trans> ProfesionalesSolicitudesEspecialidadesTrans { get; set; } = new List<Profesionales_Solicitudes_Especialidades_Trans>();

        //public virtual ComunesMunicipiosCatum MunicipioNumeroNavigation { get; set; } = null!;

        //public virtual TssNacionalidadesCatum NacionalidadNumeroNavigation { get; set; } = null!;

        //public virtual ICollection<ProfesionalesMaster> ProfesionalesMasters { get; set; } = new List<ProfesionalesMaster>();

        //public virtual ICollection<ProfesionalesSolicitudesAsociacionesTran> ProfesionalesSolicitudesAsociacionesTrans { get; set; } = new List<ProfesionalesSolicitudesAsociacionesTran>();


        //public virtual ICollection<ProfesionalesSolicitudesHistorico> ProfesionalesSolicitudesHistoricos { get; set; } = new List<ProfesionalesSolicitudesHistorico>();

        //public virtual ICollection<ProfesionalesSolicitudesRequerimientosTran> ProfesionalesSolicitudesRequerimientosTrans { get; set; } = new List<ProfesionalesSolicitudesRequerimientosTran>();

        public virtual Profesionales_Estados_Cata SolicitudEstadoNumeroNavigation { get; set; } = null!;
    }
}
