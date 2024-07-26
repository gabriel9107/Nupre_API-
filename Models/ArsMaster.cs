using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro que contiene las informaciones de cada una de las ARS/ARL que han existido a nivel de sistema, está estrechamente ligada a la tabla Instituciones Máster,  su fuente de alimentación es de la vista estadística de UNIPAGO.
/// </summary>
public partial class ArsMaster
{
    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Nombre de la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public string ArsNombre { get; set; } = null!;

    /// <summary>
    /// Número de la institución que es o a la que pertenece la ARS.
    /// </summary>
    public int InstitucionNumero { get; set; }

    /// <summary>
    /// Número único que identifica cada uno de los regímenes definidos en la ley 87-01, (Contributivo, Subsidiado y Contributivo Subsidiado).
    /// </summary>
    public byte RegimenNumero { get; set; }

    /// <summary>
    /// Código que representa el Tipo de empresa según el sector al que pertenece (Pública centralizada, Pública No Centralizada, Privada y Mixta).
    /// </summary>
    public string EmpresaTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Clasifica las ARS en Públicas, Privadas y Auto gestionada.
    /// </summary>
    public string ArsCategoriaCodigo { get; set; } = null!;

    /// <summary>
    /// Número con el cual de habilito la ARS mediante resolución para su funcionamiento en el SFS.
    /// </summary>
    public string ArsHabilitacionNumero { get; set; } = null!;

    /// <summary>
    /// Código único que representa la calsificación de las ARS en Públicas, Privadas y Auto gestionada.
    /// </summary>
    public byte ArsAsociacionNumero { get; set; }

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

    public virtual ICollection<AccidentesTransitoArsTran> AccidentesTransitoArsTrans { get; set; } = new List<AccidentesTransitoArsTran>();

    public virtual ICollection<AcreditacionesPersonasMaster> AcreditacionesPersonasMasters { get; set; } = new List<AcreditacionesPersonasMaster>();

    public virtual ICollection<AfiliadosPlanesComplementariosTran> AfiliadosPlanesComplementariosTrans { get; set; } = new List<AfiliadosPlanesComplementariosTran>();

    public virtual ICollection<AfiliadosSfsMaster> AfiliadosSfsMasters { get; set; } = new List<AfiliadosSfsMaster>();

    public virtual ICollection<AfiliadosTitularesPlanesVoluntariosTran> AfiliadosTitularesPlanesVoluntariosTrans { get; set; } = new List<AfiliadosTitularesPlanesVoluntariosTran>();

    public virtual ICollection<AfiliadosVoluntariosEspecialesTran> AfiliadosVoluntariosEspecialesTrans { get; set; } = new List<AfiliadosVoluntariosEspecialesTran>();

    public virtual ArsAsociacionesCatum ArsAsociacionNumeroNavigation { get; set; } = null!;

    public virtual ArsCategoriaCatum ArsCategoriaCodigoNavigation { get; set; } = null!;

    public virtual ICollection<ArsReportesTran> ArsReportesTrans { get; set; } = new List<ArsReportesTran>();

    public virtual ICollection<AtAutorizacionCalendarioTran> AtAutorizacionCalendarioTrans { get; set; } = new List<AtAutorizacionCalendarioTran>();

    public virtual ICollection<AtEventosTran> AtEventosTrans { get; set; } = new List<AtEventosTran>();

    public virtual ICollection<AtMaster> AtMasters { get; set; } = new List<AtMaster>();

    public virtual ICollection<AtNotificacionNoCargaTran> AtNotificacionNoCargaTrans { get; set; } = new List<AtNotificacionNoCargaTran>();

    public virtual ICollection<AuditoresMaster> AuditoresMasters { get; set; } = new List<AuditoresMaster>();

    public virtual ComunesEmpresasTipoCatum EmpresaTipoCodigoNavigation { get; set; } = null!;

    public virtual ICollection<FinancierosEstadosTran> FinancierosEstadosTrans { get; set; } = new List<FinancierosEstadosTran>();

    public virtual ICollection<FinancierosReclamacionesArsTran> FinancierosReclamacionesArsTrans { get; set; } = new List<FinancierosReclamacionesArsTran>();

    public virtual InstitucionesMaster InstitucionNumeroNavigation { get; set; } = null!;

    public virtual ICollection<PrestadorasInstitucionalesArsServiciosTran> PrestadorasInstitucionalesArsServiciosTrans { get; set; } = new List<PrestadorasInstitucionalesArsServiciosTran>();

    public virtual ICollection<PrestadorasInstitucionalesArsTran> PrestadorasInstitucionalesArsTrans { get; set; } = new List<PrestadorasInstitucionalesArsTran>();

    public virtual ICollection<PrestadorasMedicosArsTran> PrestadorasMedicosArsTrans { get; set; } = new List<PrestadorasMedicosArsTran>();

    public virtual ICollection<PrestadorasServiciosSaludArsTran> PrestadorasServiciosSaludArsTrans { get; set; } = new List<PrestadorasServiciosSaludArsTran>();

    public virtual ICollection<PrestadorasSolicitudTran> PrestadorasSolicitudTrans { get; set; } = new List<PrestadorasSolicitudTran>();

    public virtual ICollection<PromotoresMaster> PromotoresMasters { get; set; } = new List<PromotoresMaster>();

    public virtual ICollection<PypPoblacionesAnualesTran> PypPoblacionesAnualesTrans { get; set; } = new List<PypPoblacionesAnualesTran>();

    public virtual ICollection<PypServiciosTran> PypServiciosTrans { get; set; } = new List<PypServiciosTran>();

    public virtual ComunesRegimenesCatum RegimenNumeroNavigation { get; set; } = null!;

    public virtual ICollection<TraspasosMaster> TraspasosMasterArsDestinoNavigations { get; set; } = new List<TraspasosMaster>();

    public virtual ICollection<TraspasosMaster> TraspasosMasterArsOrigenNavigations { get; set; } = new List<TraspasosMaster>();
}
