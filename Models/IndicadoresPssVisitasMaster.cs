using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro que contiene las informaciones generales de las visitas de evaluación realizadas de las PSS, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class IndicadoresPssVisitasMaster
{
    /// <summary>
    /// Número único asignado automáticamente por el sistema por cada visita que se registra a una  prestadora  de servicio de salud de categoría institucional. Por cada prestadora este número se incrementa de 1 a N.
    /// </summary>
    public byte VisitaNumero { get; set; }

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// Número único que identifica cada uno de los regímenes definidos en la ley 87-01, (Contributivo, Subsidiado y Contributivo Subsidiado).
    /// </summary>
    public byte RegimenNumero { get; set; }

    /// <summary>
    /// Nombre de la persona (Contacto) que participo de parte de la prestadora  en una visita de supervisión a la prestadora de servicio de  salud institucional.
    /// </summary>
    public string VisitaContacto { get; set; } = null!;

    /// <summary>
    /// Descripción del cargo de la persona (Contacto) que participo de parte de la prestadora  en una visita de supervisión a la prestadora de servicio de  salud institucional.
    /// </summary>
    public string VisitaCargo { get; set; } = null!;

    /// <summary>
    /// Hora en que inicio una visita de supervisión a la prestadora de servicio de  salud institucional.
    /// </summary>
    public DateTime VisitaHoraInicio { get; set; }

    /// <summary>
    /// Hora en que finalizo una visita de supervisión a la prestadora de servicio de  salud institucional.
    /// </summary>
    public DateTime? VisitaHoraFinal { get; set; }

    /// <summary>
    /// Detalle de las observaciones que se registraron a partir de un proceso de una visita de supervisión a la prestadora de servicio de salud institucional.
    /// </summary>
    public string VisitaObservaciones { get; set; } = null!;

    /// <summary>
    /// Número único que identifica el estado del proceso de captura de datos del formulario de visitas a las PSS.
    /// </summary>
    public byte VisitaEstadoNumero { get; set; }

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

    public virtual ICollection<IndicadoresPssVisitasDetalleTran> IndicadoresPssVisitasDetalleTrans { get; set; } = new List<IndicadoresPssVisitasDetalleTran>();

    public virtual PrestadorasInstitucionalesMaster PrestadoraNumeroNavigation { get; set; } = null!;

    public virtual ComunesRegimenesCatum RegimenNumeroNavigation { get; set; } = null!;

    public virtual IndicadoresPssVisitasEstadoCatum VisitaEstadoNumeroNavigation { get; set; } = null!;
}
