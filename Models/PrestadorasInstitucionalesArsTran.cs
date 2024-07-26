using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran las Prestadoras de Servicios de Salud (PSS) institucionales contratadas por las ARS/ARL,  su fuente de datos es el esquema 26 procesado por el Robot Simon. 
/// </summary>
public partial class PrestadorasInstitucionalesArsTran
{
    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número único asignado a cada tipo de plan de salud.
    /// </summary>
    public byte PlanTipoNumero { get; set; }

    public int SeguimientoPeriodo { get; set; }

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
    /// Cantidad de médicos contratados que tiene la prestadora de servicios de salud (PSS).
    /// </summary>
    public short PrestadoraMedicos { get; set; }

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
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

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

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual PlanesTipoCatum PlanTipoNumeroNavigation { get; set; } = null!;

    public virtual PrestadorasInstitucionalesMaster PrestadoraNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosLotesTran Seguimiento { get; set; } = null!;
}
