using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ArlAccidentesEnfermedadesTran
{
    /// <summary>
    /// Periodo (Año y Mes) correspondiente a la información o hechos que deben ser reportados mediante una carga de informe (Esquema) para un número de seguimiento específico.
    /// </summary>
    public int SeguimientoPeriodo { get; set; }

    /// <summary>
    /// Para reportar el número de expediente dado por la ARL SS.
    /// </summary>
    public long ExpedienteArlNumero { get; set; }

    /// <summary>
    /// Número de Cédula del trabajador asignada por la Junta Central Electoral.
    /// </summary>
    public string TrabajadorCedula { get; set; } = null!;

    /// <summary>
    /// Registro Nacional de Contribuyente de la Empresa que reportó al trabajador.
    /// </summary>
    public string EmpleadorRncOCedula { get; set; } = null!;

    /// <summary>
    /// Código de Ocupacióm, según clasificación internacional de ocupaciones CIUO 88.
    /// </summary>
    public string CiioCodigo { get; set; } = null!;

    /// <summary>
    /// Fecha de notificación del Accidente de Trabajo / Enfermedad Profesional. Debe contener el siguiente formato DDMMYYYY.
    /// </summary>
    public DateTime NotificacionFecha { get; set; }

    /// <summary>
    /// Para identificar el tipo de notificación 1 .Notificación AT y 2. Notificación E.P.
    /// </summary>
    public byte NotificacionTipoNumero { get; set; }

    /// <summary>
    /// Fecha en la Ingreso a la  Empresa. Debe contener el siguiente formato DDMMYYYY.
    /// </summary>
    public DateTime IngresoFecha { get; set; }

    /// <summary>
    /// Para especificar si se tiene identificado la PSS de atención,  indicar S o N.
    /// </summary>
    public string PrestadoraIdentificada { get; set; } = null!;

    /// <summary>
    /// Indica número de PSS donde se le brindo la atención al trabajador. Sera validada la PSS cuando el tipo de notificación sea  1, en caso contrario deberá ser reportado en 0.
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// Fecha del Accidente Reportado. Debe contener el siguiente formato DDMMYYYY.  Solo aplica cuando el tipo notificación es 1 en caso reportar en blanco.
    /// </summary>
    public DateTime AccidenteFecha { get; set; }

    /// <summary>
    /// Hora del accidente, contendrá el siguiente formato HH:MM, hora marina. Solo aplica cuando el tipo notificación es 1 en caso reportar en blanco.
    /// </summary>
    public string AccidenteHora { get; set; } = null!;

    /// <summary>
    /// Número del municipio donde sucedió el accidente.
    /// </summary>
    public short MunicipioNumero { get; set; }

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
}
