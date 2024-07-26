using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PrestadorasInstitucionalesArsTemporalTran
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// Fecha de inicio del contrato de la ARS con la PSS.
    /// </summary>
    public DateTime PrestadoraContratoDesde { get; set; }

    /// <summary>
    /// Fecha de Termino del contrato de la ARS con la PSS.
    /// </summary>
    public DateTime? PrestadoraContratoHasta { get; set; }

    /// <summary>
    /// Indica el Estado de la
    /// Prestadora. (A/ B/ C )
    /// </summary>
    public string PrestadoraEstatus { get; set; } = null!;

    /// <summary>
    /// Cantidad de médicos contratados que tiene la prestadora de servicios de salud (PSS).
    /// </summary>
    public short PrestadoraMedicos { get; set; }

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio
    /// contratado con la prestadora. Colocando
    /// S=SI o N=NO.
    /// </summary>
    public string PrestadoraServiciosPyp { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la
    /// Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosConsultaAmbulatoria { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la
    /// Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosOdontologicos { get; set; } = null!;

    /// <summary>
    /// Indica si la ARS tiene este servicio contratado con la Prestadora, Colocando
    /// S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosEmergencias { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio
    /// contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosUciQuemados { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosHospitalizacion { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosPartosCesarias { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio
    /// contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosCirugias { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosOtrosApoyosDiagnosticos { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosAtencionAltoCosto { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosRehabilitacion { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosFarmacia { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosTrasladoPacientes { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosUciNoQuemados { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosLaboratorios { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosImagenes { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrestadoraServiciosOptica { get; set; } = null!;

    /// <summary>
    /// Nos indica si la cobertura del PDSS puede ser entregada en el 1er. Nivel de atención de salud.
    /// </summary>
    public string PrestadoraPrimerNivel { get; set; } = null!;

    /// <summary>
    /// Nos indica si la cobertura del PDSS puede ser entregada en el 2do. Nivel de atención de salud.
    /// </summary>
    public string PrestadoraSegundoNivel { get; set; } = null!;

    /// <summary>
    /// Nos indica si la cobertura del PDSS puede ser entregada en el 3er. Nivel de atención de salud.
    /// </summary>
    public string PrestadoraTercerNivel { get; set; } = null!;

    /// <summary>
    /// Nos indica con (S/N) si el prestador de servicio de salud (PSS) contratado por la  ARS, fue contratado para presta servicios a sus afiliados bajo el Plan de Servicios de Salud (PDSS) o el PBS.
    /// </summary>
    public string PrestadoraContratadaPlanPdss { get; set; } = null!;

    /// <summary>
    /// Nos indica con (S/N) si el prestador de servicio de salud (PSS) contratado por la  ARS, fue contratado para presta servicios a sus afiliados bajo los Planes Complementarios.
    /// </summary>
    public string PrestadoraContratadaPlanComplementario { get; set; } = null!;

    /// <summary>
    /// Nos indica con (S/N) si el prestador de servicio de salud (PSS) contratado por la  ARS, fue contratado para presta servicios a sus afiliados bajo los Planes Voluntarios.
    /// </summary>
    public string PrestadoraContratadaPlanVoluntario { get; set; } = null!;

    /// <summary>
    /// Nos indica con (S/N) si el prestador de servicio de salud (PSS) contratado por la  ARS, fue contratado para presta servicios a sus afiliados bajo los Plan Especiales y de Medicina Pre pagada.
    /// </summary>
    public string PrestadoraContratadaPlanMedicinaEspecial { get; set; } = null!;

    /// <summary>
    /// Nos indica con (S/N) si el prestador de servicio de salud (PSS) contratado por la  ARS, fue contratado para presta servicios a sus afiliados bajo el Plan Especial de Pensionados del Ministerio de Hacienda.
    /// </summary>
    public string PrestadoraContratadaPlanPensionados { get; set; } = null!;

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
}
