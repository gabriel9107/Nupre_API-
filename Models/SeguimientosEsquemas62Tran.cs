using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas62Tran
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
    /// Número único asignado a cada registro del archivo temporal de una carga de esquema especifica (Seguimiento + Lote).
    /// </summary>
    public long ArchivoLinea { get; set; }

    /// <summary>
    /// Para reportar el número de expediente dado por la ARL SS.
    /// </summary>
    public string? NumeroExpedienteArl { get; set; }

    /// <summary>
    /// Fecha de Calificación del AT /EP, contendrá el siguiente formato DDMMYYYY.
    /// </summary>
    public string? FechaCalificacion { get; set; }

    /// <summary>
    /// 1= Aprobado, 2 = Declinado. Si el estado de la calificación = 2, reportar grado de lesión 5 y tipo contingencia = 0.
    /// </summary>
    public string? EstadoCalificacion { get; set; }

    /// <summary>
    /// Código valido para reportar el tipo de contingencia de acuerdo al accidente reportado.
    /// </summary>
    public string? TipoContingencia { get; set; }

    /// <summary>
    /// Para identificar el tipo de notificación 1 .Notificación AT y 2. Notificación E.P.
    /// </summary>
    public string? TipoNotificacion { get; set; }

    /// <summary>
    /// Fecha en la que sucedió el  AT o Diagnostico de EP. Contendrá el siguiente formato DDMMYYYY.
    /// </summary>
    public string? FechaEvento { get; set; }

    /// <summary>
    /// Hora en la que sucedió el accidente contendrá el siguiente formato hh:mm, hora marina, será válido para el tipo de notificación 1. Caso contrario en blanco.
    /// </summary>
    public string? HoraAccidente { get; set; }

    /// <summary>
    /// Fecha en la salió de sus labores previo a el  accidente de trabajo contendrá el siguiente  formato DDMMYYYY. Esto solo aplica para el tipo de notificación 1, caso contrario en blanco.
    /// </summary>
    public string? FechaDejoTrabajar { get; set; }

    /// <summary>
    /// Para especificar si se tiene identificado la PSS de atención,  indicar S o N.
    /// </summary>
    public string? IdentificoPss { get; set; }

    /// <summary>
    /// Indica número de PSS donde se le brindo la atención al trabajador. Sera validada la PSS cuando el tipo de notificación sea  1, en caso contrario deberá ser reportado en 0.
    /// </summary>
    public string? LugarAtencion { get; set; }

    /// <summary>
    /// Código del diagnostico, Según codificación CIE-10.
    /// </summary>
    public string? Diagnostico { get; set; }

    /// <summary>
    /// Identifica el número único asignado de PSS al Medico en el SIMON. Ver Catálogo de PSS (SIMON).
    /// </summary>
    public string? PssMedicoTratante { get; set; }

    /// <summary>
    /// Código valido para reportar  el  tipo de lesión de acuerdo al accidente reportado.
    /// </summary>
    public string? GradoLesion { get; set; }

    /// <summary>
    /// Tipo de proceso en el cual se encuentra la solicitud AT /EP. Ver catálogo Tipo Proceso.
    /// </summary>
    public string? TipoProceso { get; set; }

    /// <summary>
    /// OK = Activo, RE = Rechazado.
    /// </summary>
    public string? RegistroValidacionEstado { get; set; }

    /// <summary>
    /// Número que identifica los posibles errores reportados.
    /// </summary>
    public string? RegistroValidacionErrores { get; set; }

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
