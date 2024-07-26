using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro con los detalles de los planes del PDSS y sus versiones, así como los planes alternativos de salud (Complementarios, Especiales, Voluntarios, etc.), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PlanesMaster
{
    /// <summary>
    /// Código único de la versión del Plan de servicios de Salud (PDSS) al cual pertenece el Subgrupo.
    /// </summary>
    public string PlanNumero { get; set; } = null!;

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Nombre del Plan de Salud.
    /// </summary>
    public string PlanNombre { get; set; } = null!;

    /// <summary>
    /// Número único  del estado en que se encuentra un Plan de Salud A=Activo (Puede ser vendido y cargado por la ARS), I=Inactivo (Solo puede ser cargado por la ARS) y N=Nulo (No permite actividad), para futuras conversiones hacia el DATA WAREHOUSE.
    /// </summary>
    public byte PlanEstadoNumero { get; set; }

    /// <summary>
    /// Número único asignado a cada tipo de plan de salud.
    /// </summary>
    public byte PlanTipoNumero { get; set; }

    /// <summary>
    /// Numero único que identifica la modalidad del plan de salud, representa si el plan es Individual o Colectivo.
    /// </summary>
    public byte PlanModalidadNumero { get; set; }

    /// <summary>
    /// Descripción del plan de salud.
    /// </summary>
    public string PlanDescripcion { get; set; } = null!;

    /// <summary>
    /// Fecha en que fue aprobado el plan de salud.
    /// </summary>
    public DateTime PlanFechaAprobacion { get; set; }

    /// <summary>
    /// Fecha en que inicia la aplicación del plan de salud.
    /// </summary>
    public DateTime PlanFechaInicioAplicacion { get; set; }

    /// <summary>
    /// Fecha en que termino la vigencia del plan de salud.
    /// </summary>
    public DateTime PlanFechaTerminoAplicacion { get; set; }

    /// <summary>
    /// Monto de la Prima Anual establecida y autorizada para el plan de salud.
    /// </summary>
    public decimal PlanPrimaAnual { get; set; }

    public decimal PlanPrimaColectiva { get; set; }

    public int PlanRangoPersonasInicio { get; set; }

    public int PlanRangoPersonasTope { get; set; }

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

    public virtual ICollection<AfiliadosDependientesPlanesVoluntariosTran> AfiliadosDependientesPlanesVoluntariosTrans { get; set; } = new List<AfiliadosDependientesPlanesVoluntariosTran>();

    public virtual ICollection<AfiliadosPlanesComplementariosTran> AfiliadosPlanesComplementariosTrans { get; set; } = new List<AfiliadosPlanesComplementariosTran>();

    public virtual ICollection<AfiliadosTitularesPlanesVoluntariosTran> AfiliadosTitularesPlanesVoluntariosTrans { get; set; } = new List<AfiliadosTitularesPlanesVoluntariosTran>();

    public virtual ICollection<AfiliadosVoluntariosEspecialesTran> AfiliadosVoluntariosEspecialesTrans { get; set; } = new List<AfiliadosVoluntariosEspecialesTran>();

    public virtual ICollection<FinancierosPagosComisionesTran> FinancierosPagosComisionesTrans { get; set; } = new List<FinancierosPagosComisionesTran>();

    public virtual ICollection<FinancierosReclamacionesArsTran> FinancierosReclamacionesArsTrans { get; set; } = new List<FinancierosReclamacionesArsTran>();

    public virtual PlanesEstadosCatum PlanEstadoNumeroNavigation { get; set; } = null!;

    public virtual PlanesModalidadCatum PlanModalidadNumeroNavigation { get; set; } = null!;

    public virtual ICollection<PlanesDocumentosTran> PlanesDocumentosTrans { get; set; } = new List<PlanesDocumentosTran>();

    public virtual ICollection<PlanesGruposMaster> PlanesGruposMasters { get; set; } = new List<PlanesGruposMaster>();

    public virtual ICollection<PlanesPrimasEdadesCatum> PlanesPrimasEdadesCata { get; set; } = new List<PlanesPrimasEdadesCatum>();

    public virtual ICollection<PlanesPrimasTran> PlanesPrimasTrans { get; set; } = new List<PlanesPrimasTran>();

    public virtual ICollection<PlanesSubgruposMaster> PlanesSubgruposMasters { get; set; } = new List<PlanesSubgruposMaster>();

    public virtual ICollection<PrestadorasServiciosSaludArsPlanesTran> PrestadorasServiciosSaludArsPlanesTrans { get; set; } = new List<PrestadorasServiciosSaludArsPlanesTran>();

    public virtual ICollection<PrestadorasServiciosSaludArsTran> PrestadorasServiciosSaludArsTrans { get; set; } = new List<PrestadorasServiciosSaludArsTran>();
}
