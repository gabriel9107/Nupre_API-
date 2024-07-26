using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas61Tran
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
    /// Registro Nacional de Contribuyente de la Empresa que reportó al trabajador.
    /// </summary>
    public string RncEmpresa { get; set; } = null!;

    /// <summary>
    /// Número de Cédula del trabajador asignada por la Junta Central Electoral.
    /// </summary>
    public string CedulaTrabajador { get; set; } = null!;

    /// <summary>
    /// Código de Ocupación, según clasificación internacional de ocupaciones CIUO 88.
    /// </summary>
    public string OcupacionTrabajador { get; set; } = null!;

    /// <summary>
    /// Para reportar el número de expediente dado por la ARL SS.
    /// </summary>
    public string NumeroExpedienteArl { get; set; } = null!;

    /// <summary>
    /// Fecha de notificación del Accidente de Trabajo / Enfermedad Profesional. Debe contener el siguiente formato DDMMYYYY.
    /// </summary>
    public string FechaNotificacion { get; set; } = null!;

    /// <summary>
    /// Para identificar el tipo de notificación 1 .Notificación AT y 2. Notificación E.P.
    /// </summary>
    public string TipoNotificacion { get; set; } = null!;

    /// <summary>
    /// Fecha en la Ingreso a la  Empresa. Debe contener el siguiente formato DDMMYYYY.
    /// </summary>
    public string FechaIngreso { get; set; } = null!;

    /// <summary>
    /// Para especificar si se tiene identificado la PSS de atención,  indicar S o N.
    /// </summary>
    public string IdentificoPss { get; set; } = null!;

    /// <summary>
    /// Indica número de PSS donde se le brindo la atención al trabajador. Sera validada la PSS cuando el tipo de notificación sea  1, en caso contrario deberá ser reportado en 0.
    /// </summary>
    public string LugarAtencion { get; set; } = null!;

    /// <summary>
    /// Fecha del Accidente Reportado. Debe contener el siguiente formato DDMMYYYY.  Solo aplica cuando el tipo notificación es 1 en caso reportar en blanco.
    /// </summary>
    public string FechaAccidente { get; set; } = null!;

    /// <summary>
    /// Hora del accidente, contendrá el siguiente formato HH:MM, hora marina. Solo aplica cuando el tipo notificación es 1 en caso reportar en blanco.
    /// </summary>
    public string HoraAccidente { get; set; } = null!;

    /// <summary>
    /// Número del municipio donde sucedió el accidente.
    /// </summary>
    public string MunicipioNumero { get; set; } = null!;

    /// <summary>
    /// OK = Activo, RE = Rechazado.
    /// </summary>
    public string RegistroValidacionEstado { get; set; } = null!;

    /// <summary>
    /// Número que identifica los posibles errores reportados.
    /// </summary>
    public string RegistroValidacionErrores { get; set; } = null!;

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
